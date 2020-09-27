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
using System.Windows.Forms;

namespace AVRSim
{
    public partial class frmRegisters : Form
    {
        List<RegisterWatch> regList = new List<RegisterWatch>();
        List<RegisterPairWatch> regPairList = new List<RegisterPairWatch>();

        public frmRegisters()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void frmRegisters_Load(object sender, EventArgs e)
        {
            panel.AutoScroll = true;
            panel.VerticalScroll.Visible = true;
            panel.VerticalScroll.Enabled = true;

            panelPair.AutoScroll = true;
            panelPair.VerticalScroll.Visible = true;
            panelPair.VerticalScroll.Enabled = true;

            List<string> registers = new List<string>();
            for (int i = 0; i < 255; i++)
                registers.Add(Instructions.GetRegisterName(i));

            cmbRegister.Items.AddRange(registers.ToArray());
            cmbRegister.SelectedIndex = 0;
            cmbLow.Items.AddRange(registers.ToArray());
            cmbLow.SelectedIndex = 0;
            cmbHigh.Items.AddRange(registers.ToArray());
            cmbHigh.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbRegister.SelectedIndex >= 0)
                AddSingleReg(cmbRegister.SelectedItem.ToString(), cmbRegister.SelectedIndex);
            else {
                //TODO Error msg
            }
        }

        int lastY = -20;
        int lastPairY = -20;

        void AddSingleReg(string name, int adr) {
            RegisterWatch watch = new RegisterWatch() { Address = adr, Name = name };

            Label nameLbl = new Label();
            nameLbl.Text = name;
            nameLbl.BorderStyle = BorderStyle.FixedSingle;
            nameLbl.TextAlign = ContentAlignment.MiddleCenter;
            nameLbl.AutoSize = false;
            nameLbl.Size = new Size(70, 21);
            nameLbl.Location = new Point(10, lastY + 20);
            nameLbl.Visible = true;
            watch.NameLabel = nameLbl;
            nameLbl.BackColor = Color.LightGray;
            panel.Controls.Add(nameLbl);

            Label adrLbl = new Label();
            adrLbl.Text = GetHex(adr);
            adrLbl.BorderStyle = BorderStyle.FixedSingle;
            adrLbl.TextAlign = ContentAlignment.MiddleCenter;
            adrLbl.AutoSize = false;
            adrLbl.Size = new Size(76, 21);
            adrLbl.Location = new Point(79, lastY + 20);
            adrLbl.Visible = true;
            adrLbl.BackColor = Color.LightGray;
            watch.AddressLabel = adrLbl;
            panel.Controls.Add(adrLbl);

            Label hexLbl = new Label();
            hexLbl.AutoSize = false;
            hexLbl.BorderStyle = BorderStyle.FixedSingle;
            hexLbl.TextAlign = ContentAlignment.MiddleCenter;
            hexLbl.Size = new Size(66, 21);
            hexLbl.Location = new Point(154, lastY + 20);
            hexLbl.Visible = true;
            hexLbl.BackColor = Color.LightGray;
            watch.HexLabel = hexLbl;
            panel.Controls.Add(hexLbl);

            Label decLbl = new Label();
            decLbl.AutoSize = false;
            decLbl.BorderStyle = BorderStyle.FixedSingle;
            decLbl.TextAlign = ContentAlignment.MiddleCenter;
            decLbl.Size = new Size(66, 21);
            decLbl.Location = new Point(219, lastY + 20);
            decLbl.Visible = true;
            watch.DecLabel = decLbl;
            decLbl.BackColor = Color.LightGray;
            panel.Controls.Add(decLbl);

            regList.Add(watch);

            lastY += 20;
        }

        void AddRegPair(string hName, string lName, int hAdr, int lAdr) {
            RegisterPairWatch watch = new RegisterPairWatch() { Address = hAdr, Name = hName, LowName = lName, LowAddress = lAdr };

            Label nameLbl = new Label();
            nameLbl.Text = hName;
            nameLbl.BorderStyle = BorderStyle.FixedSingle;
            nameLbl.TextAlign = ContentAlignment.MiddleCenter;
            nameLbl.AutoSize = false;
            nameLbl.Size = new Size(70, 21);
            nameLbl.Location = new Point(10, lastPairY + 20);
            nameLbl.Visible = true;
            nameLbl.BackColor = Color.LightGray;
            watch.NameLabel = nameLbl;
            panelPair.Controls.Add(nameLbl);

            Label lowLbl = new Label();
            lowLbl.Text = lName;
            lowLbl.BorderStyle = BorderStyle.FixedSingle;
            lowLbl.TextAlign = ContentAlignment.MiddleCenter;
            lowLbl.AutoSize = false;
            lowLbl.Size = new Size(70, 21);
            lowLbl.Location = new Point(79, lastPairY + 20);
            lowLbl.Visible = true;
            lowLbl.BackColor = Color.LightGray;
            watch.LowLabel = lowLbl;
            panelPair.Controls.Add(lowLbl);


            Label adrLbl = new Label();
            adrLbl.Text = GetHex(hAdr) + ":" + GetHex(lAdr);
            adrLbl.BorderStyle = BorderStyle.FixedSingle;
            adrLbl.TextAlign = ContentAlignment.MiddleCenter;
            adrLbl.AutoSize = false;
            adrLbl.Size = new Size(76, 21);
            adrLbl.Location = new Point(148, lastPairY + 20);
            adrLbl.Visible = true;
            adrLbl.BackColor = Color.LightGray;
            watch.AddressLabel = adrLbl;
            panelPair.Controls.Add(adrLbl);

            Label hexLbl = new Label();
            hexLbl.AutoSize = false;
            hexLbl.BorderStyle = BorderStyle.FixedSingle;
            hexLbl.TextAlign = ContentAlignment.MiddleCenter;
            hexLbl.Size = new Size(66, 21);
            hexLbl.Location = new Point(223, lastPairY + 20);
            hexLbl.Visible = true;
            hexLbl.BackColor = Color.LightGray;
            watch.HexLabel = hexLbl;
            panelPair.Controls.Add(hexLbl);

            Label decLbl = new Label();
            decLbl.AutoSize = false;
            decLbl.BorderStyle = BorderStyle.FixedSingle;
            decLbl.TextAlign = ContentAlignment.MiddleCenter;
            decLbl.Size = new Size(66, 21);
            decLbl.Location = new Point(288, lastPairY + 20);
            decLbl.Visible = true;
            decLbl.BackColor = Color.LightGray;
            watch.DecLabel = decLbl;
            panelPair.Controls.Add(decLbl);

            regPairList.Add(watch);

            lastPairY += 20;
        }

        string GetHex(int num) {
            return "0x" + Convert.ToString(num, 16).ToUpper();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < regList.Count; i++)
            {
                int regVal = AVR.SRAM[regList[i].Address];
                regList[i].HexLabel.Text = GetHex(regVal);
                regList[i].DecLabel.Text = regVal.ToString();
            }
        }

        private void btnAddPair_Click(object sender, EventArgs e)
        {
            if (cmbLow.SelectedIndex >= 0 && cmbHigh.SelectedIndex >= 0)
                AddRegPair(cmbHigh.SelectedItem.ToString(), cmbLow.SelectedItem.ToString(), cmbHigh.SelectedIndex, cmbLow.SelectedIndex);
            else { 
                //TODO error msg
            }
        }

        private void tmrRefreshPair_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < regPairList.Count; i++)
            {
                int regVal = (AVR.SRAM[regPairList[i].Address] << 8) | AVR.SRAM[regPairList[i].LowAddress];
                regPairList[i].HexLabel.Text = GetHex(regVal);
                regPairList[i].DecLabel.Text = regVal.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tmrRefresh.Enabled = false;
            regList.Clear();
            panel.Controls.Clear();
            lastY = -20;
            tmrRefresh.Enabled = true;
        }

        private void btnClearPair_Click(object sender, EventArgs e)
        {
            tmrRefreshPair.Enabled = false;
            regPairList.Clear();
            panelPair.Controls.Clear();
            lastPairY = -20;
            tmrRefreshPair.Enabled = true;
        }
    }

    class RegisterWatch { 
        public Label NameLabel { get; set; }
        public Label AddressLabel { get; set; }
        public Label HexLabel { get; set; }
        public Label DecLabel { get; set; }
        public int Address { get; set; }
        public string Name { get; set; }
    }

    class RegisterPairWatch : RegisterWatch { 
        public string LowName { get; set; }
        public Label LowLabel { get; set; }
        public int LowAddress { get; set; }
    }
}
