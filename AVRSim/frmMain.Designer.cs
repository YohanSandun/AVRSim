namespace AVRSim
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnLoadPrg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPrg
            // 
            this.btnLoadPrg.Location = new System.Drawing.Point(12, 12);
            this.btnLoadPrg.Name = "btnLoadPrg";
            this.btnLoadPrg.Size = new System.Drawing.Size(117, 41);
            this.btnLoadPrg.TabIndex = 0;
            this.btnLoadPrg.Text = "Load Program";
            this.btnLoadPrg.UseVisualStyleBackColor = true;
            this.btnLoadPrg.Click += new System.EventHandler(this.btnLoadPrg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program Counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cycles";
            // 
            // txtPc
            // 
            this.txtPc.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPc.Location = new System.Drawing.Point(98, 24);
            this.txtPc.Name = "txtPc";
            this.txtPc.ReadOnly = true;
            this.txtPc.Size = new System.Drawing.Size(75, 23);
            this.txtPc.TabIndex = 3;
            this.txtPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWords);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInstr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCycles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtWords
            // 
            this.txtWords.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords.Location = new System.Drawing.Point(98, 76);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.Size = new System.Drawing.Size(75, 23);
            this.txtWords.TabIndex = 8;
            this.txtWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Words";
            // 
            // txtInstr
            // 
            this.txtInstr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstr.Location = new System.Drawing.Point(294, 24);
            this.txtInstr.Name = "txtInstr";
            this.txtInstr.ReadOnly = true;
            this.txtInstr.Size = new System.Drawing.Size(162, 23);
            this.txtInstr.TabIndex = 6;
            this.txtInstr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Instruction";
            // 
            // txtCycles
            // 
            this.txtCycles.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycles.Location = new System.Drawing.Point(98, 50);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.ReadOnly = true;
            this.txtCycles.Size = new System.Drawing.Size(75, 23);
            this.txtCycles.TabIndex = 4;
            this.txtCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(234, 12);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(117, 41);
            this.btnStep.TabIndex = 5;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(357, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(117, 41);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Hex Files(*.hex)|*.hex";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 357);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadPrg);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInstr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

