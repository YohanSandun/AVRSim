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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegisters = new System.Windows.Forms.Button();
            this.btnVariables = new System.Windows.Forms.Button();
            this.btnPins = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSram = new System.Windows.Forms.Label();
            this.lblFlash = new System.Windows.Forms.Label();
            this.lblEEPROM = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extreamlySlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extreamlyFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.microcontrollerViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoNanoATmega328PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoNanoATmega168ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPrg
            // 
            this.btnLoadPrg.Location = new System.Drawing.Point(12, 177);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 348);
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
            this.txtInstr.Size = new System.Drawing.Size(206, 23);
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
            this.btnStep.Location = new System.Drawing.Point(388, 28);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(73, 25);
            this.btnStep.TabIndex = 5;
            this.btnStep.Text = "S&tep (F6)";
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
            this.btnRun.Text = "&Start (F5)";
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
            this.cmbSpeed.Size = new System.Drawing.Size(130, 21);
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
            this.txtStatus.Location = new System.Drawing.Point(110, 178);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(448, 23);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(189, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(92, 25);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Customize";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.groupBox2);
            this.grp1.Controls.Add(this.btnStop);
            this.grp1.Controls.Add(this.label6);
            this.grp1.Controls.Add(this.cmbSpeed);
            this.grp1.Controls.Add(this.btnStep);
            this.grp1.Controls.Add(this.btnRun);
            this.grp1.Enabled = false;
            this.grp1.Location = new System.Drawing.Point(12, 208);
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
            this.txtNextInst.Location = new System.Drawing.Point(319, 32);
            this.txtNextInst.Name = "txtNextInst";
            this.txtNextInst.ReadOnly = true;
            this.txtNextInst.Size = new System.Drawing.Size(206, 23);
            this.txtNextInst.TabIndex = 13;
            this.txtNextInst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 16);
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
            this.btnStop.Text = "Sto&p (F7)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(467, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegisters
            // 
            this.btnRegisters.Location = new System.Drawing.Point(12, 501);
            this.btnRegisters.Name = "btnRegisters";
            this.btnRegisters.Size = new System.Drawing.Size(91, 32);
            this.btnRegisters.TabIndex = 14;
            this.btnRegisters.Text = "Registers";
            this.btnRegisters.UseVisualStyleBackColor = true;
            this.btnRegisters.Click += new System.EventHandler(this.btnRegisters_Click);
            // 
            // btnVariables
            // 
            this.btnVariables.Location = new System.Drawing.Point(109, 501);
            this.btnVariables.Name = "btnVariables";
            this.btnVariables.Size = new System.Drawing.Size(91, 32);
            this.btnVariables.TabIndex = 15;
            this.btnVariables.Text = "Variables";
            this.btnVariables.UseVisualStyleBackColor = true;
            this.btnVariables.Click += new System.EventHandler(this.btnVariables_Click);
            // 
            // btnPins
            // 
            this.btnPins.Location = new System.Drawing.Point(206, 501);
            this.btnPins.Name = "btnPins";
            this.btnPins.Size = new System.Drawing.Size(91, 33);
            this.btnPins.TabIndex = 17;
            this.btnPins.Text = "Microcontroller";
            this.btnPins.UseVisualStyleBackColor = true;
            this.btnPins.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(6, 19);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(177, 21);
            this.cmbDevice.TabIndex = 19;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblClock);
            this.groupBox3.Controls.Add(this.lblEEPROM);
            this.groupBox3.Controls.Add(this.lblFlash);
            this.groupBox3.Controls.Add(this.lblSram);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbDevice);
            this.groupBox3.Controls.Add(this.btnSettings);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 144);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Memory (SRAM) size : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Program memory (Flash) size :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "EEPROM size :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Clock speed :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSram
            // 
            this.lblSram.AutoSize = true;
            this.lblSram.Location = new System.Drawing.Point(167, 52);
            this.lblSram.Name = "lblSram";
            this.lblSram.Size = new System.Drawing.Size(30, 13);
            this.lblSram.TabIndex = 24;
            this.lblSram.Text = "0 KB";
            // 
            // lblFlash
            // 
            this.lblFlash.AutoSize = true;
            this.lblFlash.Location = new System.Drawing.Point(167, 74);
            this.lblFlash.Name = "lblFlash";
            this.lblFlash.Size = new System.Drawing.Size(30, 13);
            this.lblFlash.TabIndex = 25;
            this.lblFlash.Text = "0 KB";
            // 
            // lblEEPROM
            // 
            this.lblEEPROM.AutoSize = true;
            this.lblEEPROM.Location = new System.Drawing.Point(167, 96);
            this.lblEEPROM.Name = "lblEEPROM";
            this.lblEEPROM.Size = new System.Drawing.Size(30, 13);
            this.lblEEPROM.TabIndex = 26;
            this.lblEEPROM.Text = "0 KB";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(167, 118);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(38, 13);
            this.lblClock.TabIndex = 27;
            this.lblClock.Text = "0 MHz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.speedToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProgramToolStripMenuItem,
            this.saveProgramToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.fileToolStripMenuItem.Text = "Program";
            // 
            // loadProgramToolStripMenuItem
            // 
            this.loadProgramToolStripMenuItem.Name = "loadProgramToolStripMenuItem";
            this.loadProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadProgramToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadProgramToolStripMenuItem.Text = "Load Program";
            this.loadProgramToolStripMenuItem.Click += new System.EventHandler(this.loadProgramToolStripMenuItem_Click);
            // 
            // saveProgramToolStripMenuItem
            // 
            this.saveProgramToolStripMenuItem.Name = "saveProgramToolStripMenuItem";
            this.saveProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProgramToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveProgramToolStripMenuItem.Text = "Save Program";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // beginToolStripMenuItem
            // 
            this.beginToolStripMenuItem.Name = "beginToolStripMenuItem";
            this.beginToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.beginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beginToolStripMenuItem.Text = "Start";
            this.beginToolStripMenuItem.Click += new System.EventHandler(this.beginToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extreamlySlowToolStripMenuItem,
            this.slowToolStripMenuItem,
            this.generalToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.extreamlyFastToolStripMenuItem,
            this.realtimeToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // extreamlySlowToolStripMenuItem
            // 
            this.extreamlySlowToolStripMenuItem.Name = "extreamlySlowToolStripMenuItem";
            this.extreamlySlowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extreamlySlowToolStripMenuItem.Text = "Extreamly Slow";
            this.extreamlySlowToolStripMenuItem.Click += new System.EventHandler(this.extreamlySlowToolStripMenuItem_Click);
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.slowToolStripMenuItem.Text = "Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fastToolStripMenuItem.Text = "Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // extreamlyFastToolStripMenuItem
            // 
            this.extreamlyFastToolStripMenuItem.Name = "extreamlyFastToolStripMenuItem";
            this.extreamlyFastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extreamlyFastToolStripMenuItem.Text = "Extreamly Fast";
            this.extreamlyFastToolStripMenuItem.Click += new System.EventHandler(this.extreamlyFastToolStripMenuItem_Click);
            // 
            // realtimeToolStripMenuItem
            // 
            this.realtimeToolStripMenuItem.Name = "realtimeToolStripMenuItem";
            this.realtimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realtimeToolStripMenuItem.Text = "Realtime";
            this.realtimeToolStripMenuItem.Click += new System.EventHandler(this.realtimeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registersToolStripMenuItem,
            this.variablesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.microcontrollerViewToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // registersToolStripMenuItem
            // 
            this.registersToolStripMenuItem.Name = "registersToolStripMenuItem";
            this.registersToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registersToolStripMenuItem.Text = "Registers";
            this.registersToolStripMenuItem.Click += new System.EventHandler(this.registersToolStripMenuItem_Click);
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.variablesToolStripMenuItem.Text = "Variables";
            this.variablesToolStripMenuItem.Click += new System.EventHandler(this.variablesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // microcontrollerViewToolStripMenuItem
            // 
            this.microcontrollerViewToolStripMenuItem.Name = "microcontrollerViewToolStripMenuItem";
            this.microcontrollerViewToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.microcontrollerViewToolStripMenuItem.Text = "Microcontroller View";
            this.microcontrollerViewToolStripMenuItem.Click += new System.EventHandler(this.microcontrollerViewToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customDeviceToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // customDeviceToolStripMenuItem
            // 
            this.customDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arduinoNanoATmega328PToolStripMenuItem,
            this.arduinoNanoATmega168ToolStripMenuItem});
            this.customDeviceToolStripMenuItem.Name = "customDeviceToolStripMenuItem";
            this.customDeviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customDeviceToolStripMenuItem.Text = "Select Device";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Help Topics";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // arduinoNanoATmega328PToolStripMenuItem
            // 
            this.arduinoNanoATmega328PToolStripMenuItem.Name = "arduinoNanoATmega328PToolStripMenuItem";
            this.arduinoNanoATmega328PToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.arduinoNanoATmega328PToolStripMenuItem.Text = "Arduino Nano (ATmega328P)";
            this.arduinoNanoATmega328PToolStripMenuItem.Click += new System.EventHandler(this.arduinoNanoATmega328PToolStripMenuItem_Click);
            // 
            // arduinoNanoATmega168ToolStripMenuItem
            // 
            this.arduinoNanoATmega168ToolStripMenuItem.Name = "arduinoNanoATmega168ToolStripMenuItem";
            this.arduinoNanoATmega168ToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.arduinoNanoATmega168ToolStripMenuItem.Text = "Arduino Nano (ATmega168)";
            this.arduinoNanoATmega168ToolStripMenuItem.Click += new System.EventHandler(this.arduinoNanoATmega168ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPins);
            this.Controls.Add(this.btnVariables);
            this.Controls.Add(this.btnRegisters);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadPrg);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "AVRSim";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNextInst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegisters;
        private System.Windows.Forms.Button btnVariables;
        private System.Windows.Forms.Button btnPins;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblEEPROM;
        private System.Windows.Forms.Label lblFlash;
        private System.Windows.Forms.Label lblSram;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extreamlySlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extreamlyFastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realtimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem microcontrollerViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arduinoNanoATmega328PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoNanoATmega168ToolStripMenuItem;
    }
}

