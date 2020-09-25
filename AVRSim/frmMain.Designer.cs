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
            this.sregC = new System.Windows.Forms.Label();
            this.sregZ = new System.Windows.Forms.Label();
            this.sregN = new System.Windows.Forms.Label();
            this.sregV = new System.Windows.Forms.Label();
            this.sregS = new System.Windows.Forms.Label();
            this.sregH = new System.Windows.Forms.Label();
            this.sregT = new System.Windows.Forms.Label();
            this.sregI = new System.Windows.Forms.Label();
            this.txtSreg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.txtInstr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNextInst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRegisters = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPrg
            // 
            this.btnLoadPrg.Location = new System.Drawing.Point(12, 15);
            this.btnLoadPrg.Name = "btnLoadPrg";
            this.btnLoadPrg.Size = new System.Drawing.Size(92, 25);
            this.btnLoadPrg.TabIndex = 0;
            this.btnLoadPrg.Text = "&Load Program";
            this.btnLoadPrg.UseVisualStyleBackColor = true;
            this.btnLoadPrg.Click += new System.EventHandler(this.btnLoadPrg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cycles counter";
            // 
            // txtPc
            // 
            this.txtPc.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPc.Location = new System.Drawing.Point(9, 32);
            this.txtPc.Name = "txtPc";
            this.txtPc.ReadOnly = true;
            this.txtPc.Size = new System.Drawing.Size(171, 23);
            this.txtPc.TabIndex = 3;
            this.txtPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sregC);
            this.groupBox1.Controls.Add(this.sregZ);
            this.groupBox1.Controls.Add(this.sregN);
            this.groupBox1.Controls.Add(this.sregV);
            this.groupBox1.Controls.Add(this.sregS);
            this.groupBox1.Controls.Add(this.sregH);
            this.groupBox1.Controls.Add(this.sregT);
            this.groupBox1.Controls.Add(this.sregI);
            this.groupBox1.Controls.Add(this.txtSreg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWords);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCycles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // sregC
            // 
            this.sregC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregC.ForeColor = System.Drawing.Color.White;
            this.sregC.Location = new System.Drawing.Point(163, 110);
            this.sregC.Name = "sregC";
            this.sregC.Size = new System.Drawing.Size(20, 20);
            this.sregC.TabIndex = 19;
            this.sregC.Text = "C";
            this.sregC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregZ
            // 
            this.sregZ.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregZ.ForeColor = System.Drawing.Color.White;
            this.sregZ.Location = new System.Drawing.Point(141, 110);
            this.sregZ.Name = "sregZ";
            this.sregZ.Size = new System.Drawing.Size(20, 20);
            this.sregZ.TabIndex = 18;
            this.sregZ.Text = "Z";
            this.sregZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregN
            // 
            this.sregN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregN.ForeColor = System.Drawing.Color.White;
            this.sregN.Location = new System.Drawing.Point(119, 110);
            this.sregN.Name = "sregN";
            this.sregN.Size = new System.Drawing.Size(20, 20);
            this.sregN.TabIndex = 17;
            this.sregN.Text = "N";
            this.sregN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregV
            // 
            this.sregV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregV.ForeColor = System.Drawing.Color.White;
            this.sregV.Location = new System.Drawing.Point(97, 110);
            this.sregV.Name = "sregV";
            this.sregV.Size = new System.Drawing.Size(20, 20);
            this.sregV.TabIndex = 16;
            this.sregV.Text = "V";
            this.sregV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregS
            // 
            this.sregS.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregS.ForeColor = System.Drawing.Color.White;
            this.sregS.Location = new System.Drawing.Point(75, 110);
            this.sregS.Name = "sregS";
            this.sregS.Size = new System.Drawing.Size(20, 20);
            this.sregS.TabIndex = 15;
            this.sregS.Text = "S";
            this.sregS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregH
            // 
            this.sregH.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregH.ForeColor = System.Drawing.Color.White;
            this.sregH.Location = new System.Drawing.Point(53, 110);
            this.sregH.Name = "sregH";
            this.sregH.Size = new System.Drawing.Size(20, 20);
            this.sregH.TabIndex = 14;
            this.sregH.Text = "H";
            this.sregH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregT
            // 
            this.sregT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sregT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregT.ForeColor = System.Drawing.Color.White;
            this.sregT.Location = new System.Drawing.Point(31, 110);
            this.sregT.Name = "sregT";
            this.sregT.Size = new System.Drawing.Size(20, 20);
            this.sregT.TabIndex = 13;
            this.sregT.Text = "T";
            this.sregT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sregI
            // 
            this.sregI.BackColor = System.Drawing.Color.DarkGray;
            this.sregI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sregI.ForeColor = System.Drawing.Color.White;
            this.sregI.Location = new System.Drawing.Point(9, 110);
            this.sregI.Name = "sregI";
            this.sregI.Size = new System.Drawing.Size(20, 20);
            this.sregI.TabIndex = 12;
            this.sregI.Text = "I";
            this.sregI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSreg
            // 
            this.txtSreg.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSreg.Location = new System.Drawing.Point(9, 84);
            this.txtSreg.Name = "txtSreg";
            this.txtSreg.ReadOnly = true;
            this.txtSreg.Size = new System.Drawing.Size(174, 23);
            this.txtSreg.TabIndex = 10;
            this.txtSreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SREG - Status register";
            // 
            // txtWords
            // 
            this.txtWords.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords.Location = new System.Drawing.Point(372, 32);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.Size = new System.Drawing.Size(162, 23);
            this.txtWords.TabIndex = 8;
            this.txtWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Instructions counter";
            // 
            // txtCycles
            // 
            this.txtCycles.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycles.Location = new System.Drawing.Point(372, 84);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.ReadOnly = true;
            this.txtCycles.Size = new System.Drawing.Size(162, 23);
            this.txtCycles.TabIndex = 4;
            this.txtCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInstr
            // 
            this.txtInstr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstr.Location = new System.Drawing.Point(9, 32);
            this.txtInstr.Name = "txtInstr";
            this.txtInstr.ReadOnly = true;
            this.txtInstr.Size = new System.Drawing.Size(162, 23);
            this.txtInstr.TabIndex = 6;
            this.txtInstr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Instruction";
            // 
            // btnStep
            // 
            this.btnStep.Enabled = false;
            this.btnStep.Location = new System.Drawing.Point(230, 28);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(73, 25);
            this.btnStep.TabIndex = 5;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(309, 28);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(73, 25);
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
            // cmbSpeed
            // 
            this.cmbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Location = new System.Drawing.Point(9, 31);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(121, 21);
            this.cmbSpeed.TabIndex = 7;
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbSpeed_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Speed";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(110, 16);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(448, 23);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(466, 45);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(92, 25);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "&Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.groupBox2);
            this.grp1.Controls.Add(this.btnStop);
            this.grp1.Controls.Add(this.btnPause);
            this.grp1.Controls.Add(this.btnBegin);
            this.grp1.Controls.Add(this.label6);
            this.grp1.Controls.Add(this.cmbSpeed);
            this.grp1.Controls.Add(this.btnStep);
            this.grp1.Controls.Add(this.btnRun);
            this.grp1.Enabled = false;
            this.grp1.Location = new System.Drawing.Point(12, 76);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(546, 134);
            this.grp1.TabIndex = 11;
            this.grp1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNextInst);
            this.groupBox2.Controls.Add(this.txtInstr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(9, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 67);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txtNextInst
            // 
            this.txtNextInst.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextInst.Location = new System.Drawing.Point(363, 32);
            this.txtNextInst.Name = "txtNextInst";
            this.txtNextInst.ReadOnly = true;
            this.txtNextInst.Size = new System.Drawing.Size(162, 23);
            this.txtNextInst.TabIndex = 13;
            this.txtNextInst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Next Instruction";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(467, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 25);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(388, 28);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(73, 25);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(151, 28);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(73, 25);
            this.btnBegin.TabIndex = 9;
            this.btnBegin.Text = "&Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(110, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 25);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 25);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRegisters
            // 
            this.btnRegisters.Location = new System.Drawing.Point(12, 369);
            this.btnRegisters.Name = "btnRegisters";
            this.btnRegisters.Size = new System.Drawing.Size(91, 32);
            this.btnRegisters.TabIndex = 14;
            this.btnRegisters.Text = "Registers";
            this.btnRegisters.UseVisualStyleBackColor = true;
            this.btnRegisters.Click += new System.EventHandler(this.btnRegisters_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 411);
            this.Controls.Add(this.btnRegisters);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadPrg);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtSreg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sregC;
        private System.Windows.Forms.Label sregZ;
        private System.Windows.Forms.Label sregN;
        private System.Windows.Forms.Label sregV;
        private System.Windows.Forms.Label sregS;
        private System.Windows.Forms.Label sregH;
        private System.Windows.Forms.Label sregT;
        private System.Windows.Forms.Label sregI;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNextInst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegisters;
    }
}

