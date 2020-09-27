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
using System.Windows.Forms;

namespace AVRSim
{
    public partial class frmMcView : Form
    {
        public frmMcView()
        {
            InitializeComponent();
        }

        private void tmrRefresh_Tick(object sender, System.EventArgs e)
        {
            int portD = AVR.SRAM[0x2B];
            int ddirD = AVR.SRAM[0x2A];
            int portB = AVR.SRAM[0x25];
            int ddirB = AVR.SRAM[0x24];

            d0.PinMode = ((ddirD & 0x1) == 1) ? PinMode.Output : PinMode.Input;
            d1.PinMode = (((ddirD & 0x2) >> 1) == 1) ? PinMode.Output : PinMode.Input;
            d2.PinMode = (((ddirD & 0x4) >> 2) == 1) ? PinMode.Output : PinMode.Input;
            d3.PinMode = (((ddirD & 0x8) >> 3) == 1) ? PinMode.Output : PinMode.Input;
            d4.PinMode = (((ddirD & 0x10) >> 4) == 1) ? PinMode.Output : PinMode.Input;
            d5.PinMode = (((ddirD & 0x20) >> 5) == 1) ? PinMode.Output : PinMode.Input;
            d6.PinMode = (((ddirD & 0x40) >> 6) == 1) ? PinMode.Output : PinMode.Input;
            d7.PinMode = (((ddirD & 0x80) >> 7) == 1) ? PinMode.Output : PinMode.Input;
            d8.PinMode = ((ddirB & 0x1) == 1) ? PinMode.Output : PinMode.Input;
            d9.PinMode = (((ddirB & 0x2) >> 1) == 1) ? PinMode.Output : PinMode.Input;
            d10.PinMode = (((ddirB & 0x4) >> 2) == 1) ? PinMode.Output : PinMode.Input;
            d11.PinMode = (((ddirB & 0x8) >> 3) == 1) ? PinMode.Output : PinMode.Input;
            d12.PinMode = (((ddirB & 0x10) >> 4) == 1) ? PinMode.Output : PinMode.Input;
            d13.PinMode = (((ddirB & 0x20) >> 5) == 1) ? PinMode.Output : PinMode.Input;
            
            d0.State = (portD & 0x1) == 1;
            d1.State = ((portD & 0x2) >> 1) == 1;
            d2.State = ((portD & 0x4) >> 2) == 1;
            d3.State = ((portD & 0x8) >> 3) == 1;
            d4.State = ((portD & 0x10) >> 4) == 1;
            d5.State = ((portD & 0x20) >> 5) == 1;
            d6.State = ((portD & 0x40) >> 6) == 1;
            d7.State = ((portD & 0x80) >> 7) == 1;
            d8.State = (portB & 0x1) == 1;
            d9.State = ((portB & 0x2) >> 1) == 1;
            d10.State = ((portB & 0x4) >> 2) == 1;
            d11.State = ((portB & 0x8) >> 3) == 1;
            d12.State = ((portB & 0x10) >> 4) == 1;
            d13.State = ((portB & 0x20) >> 5) == 1;

        }

    }

}
