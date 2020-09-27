//---------------------------------------------------------------------------
//  Version 1.0.0
//  Copyright (C) 2020 Yohan Sandun (yohan99ysk@gmail.com)
//
//  This file is part of AVRSim.
//
//  AVRSim is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  AVRSim is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with AVRSim.  If not, see <https://www.gnu.org/licenses/>.
//
//---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

//---------------------------------------------------------------------------
namespace AVRSim
{
    public partial class frmMain : Form
    {
        public static Device currentDevice;

        List<Device> devices = new List<Device>();

        bool isProgramLoaded = false;
        bool isStarted = false;

        private AVR avr;
        private Thread cpuThread = null;

        int sleepMs = 0;

        public frmMain()
        {
            InitializeComponent();
            InitializeDevices();
            FormClosed += FrmMain_FormClosed;
        }

        void InitializeDevices() {
            devices.Add(new Device()
            {
                SRamSize = 2048,
                FlashSize = 0x8000,
                EEPROMSize = 1024,
                GPRStart = 0,
                IORStart = 32,
                Speed = 16,
                Name = "Arduino Nano (ATmega328P)"
            }); 
            devices.Add(new Device()
            {
                SRamSize = 1024,
                FlashSize = 0x4000,
                EEPROMSize = 512,
                GPRStart = 0,
                IORStart = 32,
                Speed = 16,
                Name = "Arduino Nano (ATmega168)"
            });
            currentDevice = devices[0];

            cmbDevice.Items.AddRange(devices.ToArray());
            cmbDevice.SelectedIndex = 0;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLoadPrg_Click(object sender, EventArgs e)
        {
            LoadProgram();
        }

        void LoadProgram() {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                List<byte> flashBytes = HexDecoder.Decode(dlgOpen.FileName); //Application.StartupPath + "\\sketch\\sketch.ino.eightanaloginputs.hex"
                SetStatusText(flashBytes.Count);
                AVR.SRAM = new byte[currentDevice.SRamSize + 0x100];
                avr = new AVR()
                {
                    FLASH = new AVR.Flash(currentDevice.FlashSize, flashBytes),
                    GPR = new AVR.Registers(currentDevice.GPRStart),
                    IOR = new AVR.Registers(currentDevice.IORStart)
                };
                isProgramLoaded = true;
                grp1.Enabled = true;
                RefreshTextboxes();
                btnStep.Enabled = true;
                btnRun.Enabled = true;
                btnStop.Enabled = true;
                isStarted = true;
            }
        }

        void SetStatusText(int flashLen) {
            if (flashLen < 0x2800)
                txtStatus.Text = "Program uses " + flashLen + " bytes of program storage space.";
            else
                txtStatus.Text = "Program uses " + Math.Round(flashLen/1024f,2) + " kb of program storage space.";
        }

        private void fCpuThread()
        {
            int i = 0;
            while (!avr.isHalted)
            {
                avr.Step();
                i++;
                if (i == 1550 && ((AVR.SRAM[0x6E] & 1) == 1))
                {
                    AVR.SRAM[0x35] |= 1; // Set TIFR0's 0bit
                    i = 0;
                }
            }
            
        }

        private void fCpuThreadSlow()
        {
            DateTime start = DateTime.Now;
            int i = 0;
            while (!avr.isHalted)
            {
                avr.Step();
                i++;
                while ((DateTime.Now - start).Ticks < sleepMs) { }
                start = DateTime.Now;
                if (i == 1550 && ((AVR.SRAM[0x6E] & 1) == 1))
                {
                    AVR.SRAM[0x35] |= 1; // Set TIFR0's 0bit
                    i = 0;
                }
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            avr.Step();
            RefreshTextboxes();
        }

        private void RefreshTextboxes()
        {
            txtPc.Text = "0x" + Convert.ToString(avr.PC, 16).ToUpper();
            txtCycles.Text = avr.cycles.ToString();
            txtWords.Text = avr.instructionCounter.ToString();
            txtInstr.Text = Instructions.GetInstructionString(avr.currentInstruction, avr.nextInstruction);
            if (avr.PC < avr.FLASH.Length)
                txtNextInst.Text = Instructions.GetInstructionString(avr.FLASH[avr.PC], (avr.PC + 1 < avr.FLASH.Length ? avr.FLASH[avr.PC + 1] : 0));
            RefreshSreg();
        }

        void RefreshSreg(){
            int sreg = AVR.SRAM[0x5F];
            txtSreg.Text = "0x" + Convert.ToString(sreg, 16).ToUpper();
            ChangeLabelState(sregI, ((sreg >> 7) & 0x1) == 1);
            ChangeLabelState(sregT, ((sreg >> 6) & 0x1) == 1);
            ChangeLabelState(sregH, ((sreg >> 5) & 0x1) == 1);
            ChangeLabelState(sregS, ((sreg >> 4) & 0x1) == 1);
            ChangeLabelState(sregV, ((sreg >> 3) & 0x1) == 1);
            ChangeLabelState(sregN, ((sreg >> 2) & 0x1) == 1);
            ChangeLabelState(sregZ, ((sreg >> 1) & 0x1) == 1);
            ChangeLabelState(sregC, ((sreg >> 0) & 0x1) == 1);
        }

        void ChangeLabelState(Label label, bool state) {
            if (state) label.BackColor = Color.Black;
            else label.BackColor = Color.DarkGray;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Start();   
        }

        void Start() {
            if (cpuThread == null)
            {
                if (sleepMs != 0)
                    cpuThread = new Thread(new ThreadStart(fCpuThreadSlow));
                else
                    cpuThread = new Thread(new ThreadStart(fCpuThread));
                cpuThread.Start();
                tmrRefresh.Enabled = true;
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            RefreshTextboxes();
            if (avr.isHalted)
                tmrRefresh.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbSpeed.Items.Add("Extreamly slow");
            cmbSpeed.Items.Add("Slow");
            cmbSpeed.Items.Add("General");
            cmbSpeed.Items.Add("Fast");
            cmbSpeed.Items.Add("Extreamly fast");
            cmbSpeed.Items.Add("Realtime");
            cmbSpeed.SelectedIndex = 5;
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpeed.SelectedIndex == 0)
                sleepMs = 5000000;
            else if (cmbSpeed.SelectedIndex == 1)
                sleepMs = 1000000;
            else if(cmbSpeed.SelectedIndex == 2)
                sleepMs = 100000;
            else if(cmbSpeed.SelectedIndex == 3)
                sleepMs = 50000;
            else if (cmbSpeed.SelectedIndex == 4)
                sleepMs = 1;
            else
                sleepMs = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        void ClearAll() {
            if (isProgramLoaded)
            {
                avr.isHalted = true;
                tmrRefresh.Enabled = false;
                if (cpuThread != null && cpuThread.IsAlive)
                    cpuThread.Abort();
                txtStatus.Text = "";
                txtPc.Text = "";
                txtCycles.Text = "";
                txtInstr.Text = "";
                txtNextInst.Text = "";
                txtWords.Text = "";
                txtSreg.Text = "";
                grp1.Enabled = false;
                ChangeLabelState(sregI, false);
                ChangeLabelState(sregT, false);
                ChangeLabelState(sregH, false);
                ChangeLabelState(sregS, false);
                ChangeLabelState(sregV, false);
                ChangeLabelState(sregN, false);
                ChangeLabelState(sregZ, false);
                ChangeLabelState(sregC, false);
                avr = null;
                cpuThread = null;
                isProgramLoaded = false;
                isStarted = false;
            }
            else
                MessageBox.Show("Please load a program first!", "No program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!isProgramLoaded && !isStarted) {
                frmSettings settings = new frmSettings(currentDevice.FlashSize, currentDevice.SRamSize);
                settings.ShowDialog();
            } else
                MessageBox.Show("Can't change settings now!\nClear all and try again.", "Program loaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRegisters_Click(object sender, EventArgs e)
        {
            frmRegisters registers = new frmRegisters();
            registers.Show();
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            frmVariables variables = new frmVariables();
            variables.Show();
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            frmMcView mcView = new frmMcView();
            mcView.Show();
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDevice = devices[cmbDevice.SelectedIndex];
            RefreshDeviceDetails();
        }

        void RefreshDeviceDetails() {
            if (currentDevice.SRamSize >= 1024)
                lblSram.Text = Math.Round(currentDevice.SRamSize / 1024f, 2) + " KB";
            else
                lblSram.Text = currentDevice.SRamSize + " bytes";

            if (currentDevice.FlashSize >= 1024)
                lblFlash.Text = Math.Round(currentDevice.FlashSize / 1024f, 2) + " KB (Usable " + Math.Round((currentDevice.FlashSize-2048) / 1024f, 2) + " KB)";
            else
                lblFlash.Text = currentDevice.FlashSize + " bytes";

            if (currentDevice.EEPROMSize >= 1024)
                lblEEPROM.Text = Math.Round(currentDevice.EEPROMSize / 1024f, 2) + " KB";
            else
                lblEEPROM.Text = currentDevice.EEPROMSize + " bytes";

            lblClock.Text = currentDevice.Speed + " MHz";
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avr.Step();
            RefreshTextboxes();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            avr.isHalted = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avr.isHalted = true;
        }

        private void loadProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProgram();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void extreamlySlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbSpeed.SelectedIndex = 0;
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbSpeed.SelectedIndex = 1;
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbSpeed.SelectedIndex = 2;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbSpeed.SelectedIndex = 3;
        }

        private void extreamlyFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbSpeed.SelectedIndex = 4;
        }

        private void realtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbSpeed.SelectedIndex = 5;
        }

        private void registersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisters registers = new frmRegisters();
            registers.Show();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVariables variables = new frmVariables();
            variables.Show();
        }

        private void microcontrollerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMcView McView = new frmMcView();
            McView.Show();
        }

        private void arduinoNanoATmega328PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbDevice.SelectedIndex = 0;
        }

        private void arduinoNanoATmega168ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbDevice.SelectedIndex = 1;
        }
    }
}