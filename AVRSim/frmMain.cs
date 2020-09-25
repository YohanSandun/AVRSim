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
        public static int flashSize = 0x8000;
        public static int sramSize = 2048;

        bool isProgramLoaded = false;
        bool isStarted = false;

        private AVR avr;
        private Thread cpuThread = null;

        int sleepMs = 0;

        public frmMain()
        {
            InitializeComponent();
            FormClosed += FrmMain_FormClosed;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLoadPrg_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                List<byte> flashBytes = HexDecoder.Decode(dlgOpen.FileName); //Application.StartupPath + "\\sketch\\sketch.ino.eightanaloginputs.hex"
                SetStatusText(flashBytes.Count);
                AVR.SRAM = new byte[2048];
                avr = new AVR()
                {
                    FLASH = new AVR.Flash(32 * 1024, flashBytes),
                    GPR = new AVR.Registers(0),
                    IOR = new AVR.Registers(32)
                };
                isProgramLoaded = true;
                grp1.Enabled = true;
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
            while (!avr.isHalted)
            {
                avr.Step();
                Thread.Sleep(sleepMs);
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
            if (cpuThread == null)
            {
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
            cmbSpeed.SelectedIndex = 4;
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpeed.SelectedIndex == 0)
                sleepMs = 1000;
            else if (cmbSpeed.SelectedIndex == 1)
                sleepMs = 500;
            else if(cmbSpeed.SelectedIndex == 2)
                sleepMs = 100;
            else if(cmbSpeed.SelectedIndex == 3)
                sleepMs = 10;
            else
                sleepMs = 0;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (isProgramLoaded && avr != null)
            {
                RefreshTextboxes();
                btnStep.Enabled = true;
                btnRun.Enabled = true;
                btnPause.Enabled = true;
                btnStop.Enabled = true;
                btnBegin.Enabled = false;
                isStarted = true;
            }
            else
                MessageBox.Show("Please load a program first!", "No program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isProgramLoaded)
            {
                //TODO
            }
            else 
                MessageBox.Show("Please load a program first!", "No program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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
                frmSettings settings = new frmSettings(flashSize, sramSize);
                settings.ShowDialog();
            } else
                MessageBox.Show("Can't change settings now!\nClear all and try again.", "Program loaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRegisters_Click(object sender, EventArgs e)
        {
            frmRegisters registers = new frmRegisters();
            registers.Show();
        }
    }
}