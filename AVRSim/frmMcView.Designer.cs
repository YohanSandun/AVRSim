namespace AVRSim
{
    partial class frmMcView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.d13 = new AVRSim.ctrlMcPin();
            this.a0 = new AVRSim.ctrlMcPin();
            this.a1 = new AVRSim.ctrlMcPin();
            this.a2 = new AVRSim.ctrlMcPin();
            this.a3 = new AVRSim.ctrlMcPin();
            this.a4 = new AVRSim.ctrlMcPin();
            this.a5 = new AVRSim.ctrlMcPin();
            this.a6 = new AVRSim.ctrlMcPin();
            this.a7 = new AVRSim.ctrlMcPin();
            this.d12 = new AVRSim.ctrlMcPin();
            this.d11 = new AVRSim.ctrlMcPin();
            this.d10 = new AVRSim.ctrlMcPin();
            this.d9 = new AVRSim.ctrlMcPin();
            this.d8 = new AVRSim.ctrlMcPin();
            this.d7 = new AVRSim.ctrlMcPin();
            this.d6 = new AVRSim.ctrlMcPin();
            this.d5 = new AVRSim.ctrlMcPin();
            this.d4 = new AVRSim.ctrlMcPin();
            this.d3 = new AVRSim.ctrlMcPin();
            this.d2 = new AVRSim.ctrlMcPin();
            this.d1 = new AVRSim.ctrlMcPin();
            this.d0 = new AVRSim.ctrlMcPin();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AVRSim.Properties.Resources.arduino_nano;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // d13
            // 
            this.d13.Direction = AVRSim.Direction.Right;
            this.d13.Information = null;
            this.d13.Location = new System.Drawing.Point(376, 370);
            this.d13.Margin = new System.Windows.Forms.Padding(0);
            this.d13.Name = "d13";
            this.d13.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d13.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d13.PinMode = AVRSim.PinMode.Output;
            this.d13.Size = new System.Drawing.Size(63, 24);
            this.d13.State = false;
            this.d13.TabIndex = 30;
            // 
            // a0
            // 
            this.a0.Direction = AVRSim.Direction.Right;
            this.a0.Information = null;
            this.a0.Location = new System.Drawing.Point(376, 295);
            this.a0.Margin = new System.Windows.Forms.Padding(0);
            this.a0.Name = "a0";
            this.a0.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a0.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a0.PinMode = AVRSim.PinMode.Output;
            this.a0.Size = new System.Drawing.Size(63, 24);
            this.a0.State = false;
            this.a0.TabIndex = 27;
            // 
            // a1
            // 
            this.a1.Direction = AVRSim.Direction.Right;
            this.a1.Information = null;
            this.a1.Location = new System.Drawing.Point(376, 270);
            this.a1.Margin = new System.Windows.Forms.Padding(0);
            this.a1.Name = "a1";
            this.a1.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a1.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a1.PinMode = AVRSim.PinMode.Output;
            this.a1.Size = new System.Drawing.Size(63, 24);
            this.a1.State = false;
            this.a1.TabIndex = 26;
            // 
            // a2
            // 
            this.a2.Direction = AVRSim.Direction.Right;
            this.a2.Information = null;
            this.a2.Location = new System.Drawing.Point(376, 245);
            this.a2.Margin = new System.Windows.Forms.Padding(0);
            this.a2.Name = "a2";
            this.a2.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a2.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a2.PinMode = AVRSim.PinMode.Output;
            this.a2.Size = new System.Drawing.Size(63, 24);
            this.a2.State = false;
            this.a2.TabIndex = 25;
            // 
            // a3
            // 
            this.a3.Direction = AVRSim.Direction.Right;
            this.a3.Information = null;
            this.a3.Location = new System.Drawing.Point(376, 220);
            this.a3.Margin = new System.Windows.Forms.Padding(0);
            this.a3.Name = "a3";
            this.a3.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a3.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a3.PinMode = AVRSim.PinMode.Output;
            this.a3.Size = new System.Drawing.Size(63, 24);
            this.a3.State = false;
            this.a3.TabIndex = 24;
            // 
            // a4
            // 
            this.a4.Direction = AVRSim.Direction.Right;
            this.a4.Information = null;
            this.a4.Location = new System.Drawing.Point(376, 195);
            this.a4.Margin = new System.Windows.Forms.Padding(0);
            this.a4.Name = "a4";
            this.a4.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a4.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a4.PinMode = AVRSim.PinMode.Output;
            this.a4.Size = new System.Drawing.Size(63, 24);
            this.a4.State = false;
            this.a4.TabIndex = 23;
            // 
            // a5
            // 
            this.a5.Direction = AVRSim.Direction.Right;
            this.a5.Information = null;
            this.a5.Location = new System.Drawing.Point(376, 170);
            this.a5.Margin = new System.Windows.Forms.Padding(0);
            this.a5.Name = "a5";
            this.a5.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a5.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a5.PinMode = AVRSim.PinMode.Output;
            this.a5.Size = new System.Drawing.Size(63, 24);
            this.a5.State = false;
            this.a5.TabIndex = 22;
            // 
            // a6
            // 
            this.a6.Direction = AVRSim.Direction.Right;
            this.a6.Information = null;
            this.a6.Location = new System.Drawing.Point(376, 145);
            this.a6.Margin = new System.Windows.Forms.Padding(0);
            this.a6.Name = "a6";
            this.a6.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a6.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a6.PinMode = AVRSim.PinMode.Output;
            this.a6.Size = new System.Drawing.Size(63, 24);
            this.a6.State = false;
            this.a6.TabIndex = 21;
            // 
            // a7
            // 
            this.a7.Direction = AVRSim.Direction.Right;
            this.a7.Information = null;
            this.a7.Location = new System.Drawing.Point(376, 120);
            this.a7.Margin = new System.Windows.Forms.Padding(0);
            this.a7.Name = "a7";
            this.a7.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.a7.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.a7.PinMode = AVRSim.PinMode.Output;
            this.a7.Size = new System.Drawing.Size(63, 24);
            this.a7.State = false;
            this.a7.TabIndex = 20;
            // 
            // d12
            // 
            this.d12.Direction = AVRSim.Direction.Left;
            this.d12.Information = null;
            this.d12.Location = new System.Drawing.Point(85, 370);
            this.d12.Margin = new System.Windows.Forms.Padding(0);
            this.d12.Name = "d12";
            this.d12.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d12.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d12.PinMode = AVRSim.PinMode.Output;
            this.d12.Size = new System.Drawing.Size(63, 24);
            this.d12.State = false;
            this.d12.TabIndex = 15;
            // 
            // d11
            // 
            this.d11.Direction = AVRSim.Direction.Left;
            this.d11.Information = null;
            this.d11.Location = new System.Drawing.Point(85, 345);
            this.d11.Margin = new System.Windows.Forms.Padding(0);
            this.d11.Name = "d11";
            this.d11.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d11.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d11.PinMode = AVRSim.PinMode.Output;
            this.d11.Size = new System.Drawing.Size(63, 24);
            this.d11.State = false;
            this.d11.TabIndex = 14;
            // 
            // d10
            // 
            this.d10.Direction = AVRSim.Direction.Left;
            this.d10.Information = null;
            this.d10.Location = new System.Drawing.Point(85, 320);
            this.d10.Margin = new System.Windows.Forms.Padding(0);
            this.d10.Name = "d10";
            this.d10.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d10.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d10.PinMode = AVRSim.PinMode.Output;
            this.d10.Size = new System.Drawing.Size(63, 24);
            this.d10.State = false;
            this.d10.TabIndex = 13;
            // 
            // d9
            // 
            this.d9.Direction = AVRSim.Direction.Left;
            this.d9.Information = null;
            this.d9.Location = new System.Drawing.Point(85, 295);
            this.d9.Margin = new System.Windows.Forms.Padding(0);
            this.d9.Name = "d9";
            this.d9.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d9.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d9.PinMode = AVRSim.PinMode.Output;
            this.d9.Size = new System.Drawing.Size(63, 24);
            this.d9.State = false;
            this.d9.TabIndex = 12;
            // 
            // d8
            // 
            this.d8.Direction = AVRSim.Direction.Left;
            this.d8.Information = null;
            this.d8.Location = new System.Drawing.Point(85, 270);
            this.d8.Margin = new System.Windows.Forms.Padding(0);
            this.d8.Name = "d8";
            this.d8.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d8.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d8.PinMode = AVRSim.PinMode.Output;
            this.d8.Size = new System.Drawing.Size(63, 24);
            this.d8.State = false;
            this.d8.TabIndex = 11;
            // 
            // d7
            // 
            this.d7.Direction = AVRSim.Direction.Left;
            this.d7.Information = null;
            this.d7.Location = new System.Drawing.Point(85, 245);
            this.d7.Margin = new System.Windows.Forms.Padding(0);
            this.d7.Name = "d7";
            this.d7.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d7.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d7.PinMode = AVRSim.PinMode.Output;
            this.d7.Size = new System.Drawing.Size(63, 24);
            this.d7.State = false;
            this.d7.TabIndex = 10;
            // 
            // d6
            // 
            this.d6.Direction = AVRSim.Direction.Left;
            this.d6.Information = null;
            this.d6.Location = new System.Drawing.Point(85, 220);
            this.d6.Margin = new System.Windows.Forms.Padding(0);
            this.d6.Name = "d6";
            this.d6.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d6.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d6.PinMode = AVRSim.PinMode.Output;
            this.d6.Size = new System.Drawing.Size(63, 24);
            this.d6.State = false;
            this.d6.TabIndex = 9;
            // 
            // d5
            // 
            this.d5.Direction = AVRSim.Direction.Left;
            this.d5.Information = null;
            this.d5.Location = new System.Drawing.Point(85, 195);
            this.d5.Margin = new System.Windows.Forms.Padding(0);
            this.d5.Name = "d5";
            this.d5.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d5.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d5.PinMode = AVRSim.PinMode.Output;
            this.d5.Size = new System.Drawing.Size(63, 24);
            this.d5.State = false;
            this.d5.TabIndex = 8;
            // 
            // d4
            // 
            this.d4.Direction = AVRSim.Direction.Left;
            this.d4.Information = null;
            this.d4.Location = new System.Drawing.Point(85, 170);
            this.d4.Margin = new System.Windows.Forms.Padding(0);
            this.d4.Name = "d4";
            this.d4.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d4.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d4.PinMode = AVRSim.PinMode.Output;
            this.d4.Size = new System.Drawing.Size(63, 24);
            this.d4.State = false;
            this.d4.TabIndex = 7;
            // 
            // d3
            // 
            this.d3.Direction = AVRSim.Direction.Left;
            this.d3.Information = null;
            this.d3.Location = new System.Drawing.Point(85, 145);
            this.d3.Margin = new System.Windows.Forms.Padding(0);
            this.d3.Name = "d3";
            this.d3.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d3.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d3.PinMode = AVRSim.PinMode.Output;
            this.d3.Size = new System.Drawing.Size(63, 24);
            this.d3.State = false;
            this.d3.TabIndex = 6;
            // 
            // d2
            // 
            this.d2.Direction = AVRSim.Direction.Left;
            this.d2.Information = null;
            this.d2.Location = new System.Drawing.Point(85, 120);
            this.d2.Margin = new System.Windows.Forms.Padding(0);
            this.d2.Name = "d2";
            this.d2.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d2.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d2.PinMode = AVRSim.PinMode.Output;
            this.d2.Size = new System.Drawing.Size(63, 24);
            this.d2.State = false;
            this.d2.TabIndex = 5;
            // 
            // d1
            // 
            this.d1.Direction = AVRSim.Direction.Left;
            this.d1.Information = null;
            this.d1.Location = new System.Drawing.Point(85, 45);
            this.d1.Margin = new System.Windows.Forms.Padding(0);
            this.d1.Name = "d1";
            this.d1.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d1.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d1.PinMode = AVRSim.PinMode.Output;
            this.d1.Size = new System.Drawing.Size(63, 24);
            this.d1.State = false;
            this.d1.TabIndex = 2;
            // 
            // d0
            // 
            this.d0.Direction = AVRSim.Direction.Left;
            this.d0.Information = new string[] {
        "Digital Pin \tPCINT17",
        "Port Pin\t\tPD1",
        "Serial Pin\t\tTX"};
            this.d0.Location = new System.Drawing.Point(85, 20);
            this.d0.Margin = new System.Windows.Forms.Padding(0);
            this.d0.Name = "d0";
            this.d0.OffBackgroundColor = System.Drawing.Color.DarkGray;
            this.d0.OnBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.d0.PinMode = AVRSim.PinMode.Output;
            this.d0.Size = new System.Drawing.Size(63, 24);
            this.d0.State = false;
            this.d0.TabIndex = 1;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 1;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // frmMcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 418);
            this.Controls.Add(this.d13);
            this.Controls.Add(this.a0);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a5);
            this.Controls.Add(this.a6);
            this.Controls.Add(this.a7);
            this.Controls.Add(this.d12);
            this.Controls.Add(this.d11);
            this.Controls.Add(this.d10);
            this.Controls.Add(this.d9);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.d7);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.d5);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.d0);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMcView";
            this.Text = "Pin Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlMcPin d0;
        private ctrlMcPin d1;
        private ctrlMcPin d5;
        private ctrlMcPin d4;
        private ctrlMcPin d3;
        private ctrlMcPin d2;
        private ctrlMcPin d9;
        private ctrlMcPin d8;
        private ctrlMcPin d7;
        private ctrlMcPin d6;
        private ctrlMcPin d12;
        private ctrlMcPin d11;
        private ctrlMcPin d10;
        private ctrlMcPin d13;
        private ctrlMcPin a0;
        private ctrlMcPin a1;
        private ctrlMcPin a2;
        private ctrlMcPin a3;
        private ctrlMcPin a4;
        private ctrlMcPin a5;
        private ctrlMcPin a6;
        private ctrlMcPin a7;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}