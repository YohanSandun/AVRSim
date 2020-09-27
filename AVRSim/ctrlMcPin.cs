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
using System.Drawing;
using System.Windows.Forms;

namespace AVRSim
{
    public enum Direction
    {
        Left,
        Right
    }

    public enum PinMode
    {
        Input,
        Output,
        InputPullup
    }

    public partial class ctrlMcPin : UserControl
    {
        private Direction mDirection = Direction.Left;
        private PinMode mPinMode = PinMode.Output;
        private bool mState = true;

        public Color OffBackgroundColor { get; set; } = Color.DarkGray;

        public Color OnBackgroundColor { get; set; } = Color.LightSeaGreen;

        public string[] Information { get; set; }

        public Direction Direction
        {
            set { mDirection = value; PlaceControls(); }
            get { return mDirection; }
        }

        public PinMode PinMode
        {
            get { return mPinMode; }
            set
            {
                mPinMode = value;
                RefreshPinMode();
            }
        }

        void RefreshPinMode()
        {
            if (mPinMode == PinMode.Input)
                btn.Enabled = true;
            else
                btn.Enabled = false;
        }

        public bool State
        {
            get { return mState; }
            set
            {
                ChangeState(value);
            }
        }

        private void ChangeState(bool newState)
        {
            if (newState == mState)
                return;
            mState = newState;
            if (mState)
            {
                lbl.Text = "ON";
                lbl.BackColor = OnBackgroundColor;
            }
            else
            {
                lbl.Text = "OFF";
                lbl.BackColor = OffBackgroundColor;
            }
        }

        public ctrlMcPin()
        {
            InitializeComponent();
            Resize += CtrlMcPin_Resize;
            PlaceControls();
            RefreshPinMode();
            ChangeState(false);
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void CtrlMcPin_Resize(object sender, EventArgs e)
        {
            btn.Height = Height;
            lbl.Height = Height;
            Width = lbl.Width + btn.Width;
        }

        private void PlaceControls()
        {
            if (mDirection == Direction.Left)
            {
                btn.Location = new Point(0, 0);
                lbl.Location = new Point(btn.Width, 0);
            }
            else if (mDirection == Direction.Right)
            {
                lbl.Location = new Point(0, 0);
                btn.Location = new Point(lbl.Width, 0);
            }
            Width = lbl.Width + btn.Width;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            if (Information == null) return;
            string str = "";
            for (int i = 0; i < Information.Length; i++)
                str += Information[i] + "\n";
            MessageBox.Show(str, "Pin Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
