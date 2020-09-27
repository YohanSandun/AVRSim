namespace AVRSim
{
    partial class ctrlMcPin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(28, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "T";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(44, 1);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "OFF";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // ctrlMcPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlMcPin";
            this.Size = new System.Drawing.Size(240, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl;
    }
}
