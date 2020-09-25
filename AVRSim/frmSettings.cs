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
                frmMain.sramSize = int.Parse(txtSram.Text.Trim());
                frmMain.flashSize = int.Parse(txtFlash.Text.Trim());
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
            txtSram.Text = "2048";
        }
    }
}
