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
using System.Threading;
using System.Windows.Forms;

//---------------------------------------------------------------------------
namespace AVRSim
{
    public partial class frmMain : Form
    {
        private AVR avr;
        private Thread cpuThread = null;

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
                AVR.SRAM = new byte[1024];
                avr = new AVR()
                {
                    FLASH = new AVR.Flash(32 * 1024, flashBytes),
                    GPR = new AVR.Registers(0),
                    IOR = new AVR.Registers(32)
                };
            }
        }

        private void fCpuThread()
        {
            avr.Run();
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
            txtWords.Text = avr.words.ToString();
            txtInstr.Text = Instructions.GetInstructionString(avr.currentInstruction, avr.nextInstruction);
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
    }
}