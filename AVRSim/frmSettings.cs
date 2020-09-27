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
using System.Windows.Forms;

namespace AVRSim
{
    public partial class frmSettings : Form
    {
        public frmSettings(int flashSize, int sramSize)
        {
            InitializeComponent();
            txtFlash.Text = flashSize.ToString();
            txtSram.Text = sramSize.ToString();
        }

        bool ValidateFields() {
            int flash, sram;
            if (int.TryParse(txtFlash.Text.Trim(), out flash) & flash >= 512)
            {
                if (int.TryParse(txtSram.Text.Trim(), out sram) & sram >= 256)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter valid size for memory(SRAM)\nMinimum size is 256 bytes.", "No program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSram.Focus();
                    txtSram.SelectAll();
                }
            }
            else {
                MessageBox.Show("Please enter valid size for program memory(Flash)\nMinimum size is 512 bytes.", "No program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFlash.Focus();
                txtFlash.SelectAll();
            }
            return false;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) {
                //TODO
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            txtFlash.Text = "32768";
            txtSram.Text = "1024";
        }
    }
}
