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
    public partial class frmVariables : Form
    {
        List<Variable> varList = new List<Variable>();

        public frmVariables()
        {
            InitializeComponent();
            varList = new List<Variable>();
        }

        private void frmVariables_Load(object sender, EventArgs e)
        {
            panel.AutoScroll = true;
            panel.VerticalScroll.Visible = true;
            panel.VerticalScroll.Enabled = true;

            cmbType.Items.Add("boolean");
            cmbType.Items.Add("char");
            cmbType.Items.Add("unsigned char");
            cmbType.Items.Add("byte");
            cmbType.Items.Add("int (2-byte)");
            cmbType.Items.Add("unsigned int (2-byte)");
            cmbType.Items.Add("int (4-byte)");
            cmbType.Items.Add("unsigned int (4-byte)");
            cmbType.Items.Add("word (2-byte)");
            cmbType.Items.Add("word (4-byte)");
            cmbType.Items.Add("long (4-byte)");
            cmbType.Items.Add("unsigned long (4-byte)");
            cmbType.Items.Add("short (2-byte)");
            cmbType.Items.Add("float (4-byte)");
            cmbType.Items.Add("double (4-byte)");
            cmbType.Items.Add("double (8-byte)");
            cmbType.Items.Add("string");
            cmbType.SelectedIndex = 3;
        }

        bool ValidateFields() {
            int adr;
            if (txtName.Text.Trim() != "") {
                try
                {
                    adr = Convert.ToInt32(txtAdr.Text.Trim(), 16);
                    
                    if (adr < frmMain.currentDevice.SRamSize && adr >= 0/*TODO : ramstart*/)
                    {
                        return true;
                    }
                    else
                    {
                        //TODO msgbox out of ram
                    }
                    
                }
                catch { }
            }
            else { 
                //TODO msg box
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) {
                AddVariable(txtName.Text.Trim(), (VariableType)cmbType.SelectedIndex, Convert.ToInt32(txtAdr.Text.Trim(), 16), cmbType.SelectedItem.ToString());
            }
        }

        int lastY = -19;

        void AddVariable(string name, VariableType type, int adr, string typeStr) {
            Variable variable = new Variable() { Address = adr, Type = type, Name = name };

            Label nameLbl = new Label();
            nameLbl.AutoSize = false;
            nameLbl.BorderStyle = BorderStyle.FixedSingle;
            nameLbl.Size = new Size(100, 20);
            nameLbl.Location = new Point(0, lastY + 19);
            nameLbl.Text = name;
            nameLbl.TextAlign = ContentAlignment.MiddleCenter;
            variable.NameLable = nameLbl;
            panel.Controls.Add(nameLbl);

            Label typeLbl = new Label();
            typeLbl.AutoSize = false;
            typeLbl.BorderStyle = BorderStyle.FixedSingle;
            typeLbl.Size = new Size(157, 20);
            typeLbl.Location = new Point(99, lastY + 19);
            typeLbl.Text = typeStr;
            typeLbl.TextAlign = ContentAlignment.MiddleCenter;
            variable.TypeLable = typeLbl;
            panel.Controls.Add(typeLbl);

            Label adrLbl = new Label();
            adrLbl.AutoSize = false;
            adrLbl.BorderStyle = BorderStyle.FixedSingle;
            adrLbl.Size = new Size(88, 20);
            adrLbl.Location = new Point(255, lastY + 19);
            adrLbl.Text = GetHex(adr);
            adrLbl.TextAlign = ContentAlignment.MiddleCenter;
            variable.AddressLable = adrLbl;
            panel.Controls.Add(adrLbl);

            TextBox valTxt = new TextBox();
            valTxt.ReadOnly = true;
            valTxt.Size = new Size(187, 20);
            valTxt.Location = new Point(342, lastY + 19);
            variable.ValueTextBox = valTxt;
            panel.Controls.Add(valTxt);

            varList.Add(variable);

            lastY += 19;
        }
        string GetHex(int num)
        {
            return "0x" + Convert.ToString(num, 16).ToUpper();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < varList.Count; i++)
            {
                //TODO check sram out of range
                if (varList[i].Type == VariableType.Int2Byte || varList[i].Type == VariableType.Short2Byte)
                    varList[i].ValueTextBox.Text = (short)((AVR.SRAM[varList[i].Address + 1] << 8) | AVR.SRAM[varList[i].Address]) + "";

                else if (varList[i].Type == VariableType.UInt2Byte || varList[i].Type == VariableType.Word2Byte)
                    varList[i].ValueTextBox.Text = (ushort)((AVR.SRAM[varList[i].Address + 1] << 8) | AVR.SRAM[varList[i].Address]) + "";

                else if (varList[i].Type == VariableType.Byte || varList[i].Type == VariableType.UChar)
                    varList[i].ValueTextBox.Text = AVR.SRAM[varList[i].Address] + "";

                else if (varList[i].Type == VariableType.Char)
                    varList[i].ValueTextBox.Text = (sbyte)(AVR.SRAM[varList[i].Address]) + "";

                else if (varList[i].Type == VariableType.Boolean)
                    varList[i].ValueTextBox.Text = AVR.SRAM[varList[i].Address] == 0 ? "False" : "True";

                else if (varList[i].Type == VariableType.Long4Byte || varList[i].Type == VariableType.Int4Byte)
                    varList[i].ValueTextBox.Text = ((AVR.SRAM[varList[i].Address + 3] << 24) | (AVR.SRAM[varList[i].Address + 2] << 16) | (AVR.SRAM[varList[i].Address + 1] << 8) | AVR.SRAM[varList[i].Address]) + "";

                else if (varList[i].Type == VariableType.ULong4Byte || varList[i].Type == VariableType.UInt4Byte || varList[i].Type == VariableType.Word4Byte)
                    varList[i].ValueTextBox.Text = (uint)((AVR.SRAM[varList[i].Address + 3] << 24) | (AVR.SRAM[varList[i].Address + 2] << 16) | (AVR.SRAM[varList[i].Address + 1] << 8) | AVR.SRAM[varList[i].Address]) + "";

                else if (varList[i].Type == VariableType.Float4Byte || varList[i].Type == VariableType.Double4Byte)
                    varList[i].ValueTextBox.Text = BitConverter.ToSingle(AVR.SRAM, varList[i].Address) + "";

                else if (varList[i].Type == VariableType.Double8Byte)
                    varList[i].ValueTextBox.Text = BitConverter.ToDouble(AVR.SRAM, varList[i].Address) + "";

                else if (varList[i].Type == VariableType.String)
                    varList[i].ValueTextBox.Text = "TODO: Not programmed yet!";//TODO
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tmrRefresh.Enabled = false;
            varList.Clear();
            panel.Controls.Clear();
            lastY = -20;
            tmrRefresh.Enabled = true;
        }
    }

    enum VariableType
    {
        Boolean = 0,
        Char,
        UChar,
        Byte,
        Int2Byte,
        UInt2Byte,
        Int4Byte,
        UInt4Byte,
        Word2Byte,
        Word4Byte,
        Long4Byte,
        ULong4Byte,
        Short2Byte,
        Float4Byte,
        Double4Byte,
        Double8Byte,
        String
    }
    class Variable { 
        public VariableType Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Address { get; set; }

        public Label NameLable { get; set; }
        public Label TypeLable { get; set; }
        public Label AddressLable { get; set; }
        public TextBox ValueTextBox { get; set; }

    }
}
