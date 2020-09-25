namespace AVRSim
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlash = new System.Windows.Forms.TextBox();
            this.txtSram = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDef = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program memory (Flash) size in bytes";
            // 
            // txtFlash
            // 
            this.txtFlash.Location = new System.Drawing.Point(59, 56);
            this.txtFlash.Name = "txtFlash";
            this.txtFlash.Size = new System.Drawing.Size(172, 20);
            this.txtFlash.TabIndex = 1;
            this.txtFlash.Text = "32768";
            // 
            // txtSram
            // 
            this.txtSram.Location = new System.Drawing.Point(59, 111);
            this.txtSram.Name = "txtSram";
            this.txtSram.Size = new System.Drawing.Size(172, 20);
            this.txtSram.TabIndex = 3;
            this.txtSram.Text = "2048";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memory (SRAM) size in bytes";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(203, 174);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDef
            // 
            this.btnDef.Location = new System.Drawing.Point(12, 174);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(75, 23);
            this.btnDef.TabIndex = 5;
            this.btnDef.Text = "&Default";
            this.btnDef.UseVisualStyleBackColor = true;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(122, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDef);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFlash);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlash;
        private System.Windows.Forms.TextBox txtSram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDef;
        private System.Windows.Forms.Button btnCancel;
    }
}