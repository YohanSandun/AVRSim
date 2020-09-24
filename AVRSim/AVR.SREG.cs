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
namespace AVRSim
{
    partial class AVR
    {
        private byte sreg_location = 0x5F;

        private bool SREG_I
        {
            get { return (SRAM[sreg_location] & (1 << 7)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0x7F) | (value ? 1 : 0) << 7); }
        }

        private bool SREG_T
        {
            get { return (SRAM[sreg_location] & (1 << 6)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xBF) | (value ? 1 : 0) << 6); }
        }

        private bool SREG_H
        {
            get { return (SRAM[sreg_location] & (1 << 5)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xDF) | (value ? 1 : 0) << 5); }
        }

        private bool SREG_S
        {
            get { return (SRAM[sreg_location] & (1 << 4)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xEF) | (value ? 1 : 0) << 4); }
        }

        private bool SREG_V
        {
            get { return (SRAM[sreg_location] & (1 << 3)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xF7) | (value ? 1 : 0) << 3); }
        }

        private bool SREG_N
        {
            get { return (SRAM[sreg_location] & (1 << 2)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xFB) | (value ? 1 : 0) << 2); }
        }

        private bool SREG_Z
        {
            get { return (SRAM[sreg_location] & (1 << 1)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xFD) | (value ? 1 : 0) << 1); }
        }

        private bool SREG_C
        {
            get { return (SRAM[sreg_location] & (1 << 0)) != 0; }
            set { SRAM[sreg_location] = (byte)((SRAM[sreg_location] & 0xFE) | (value ? 1 : 0) << 0); }
        }
    }
}