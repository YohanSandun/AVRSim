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
        // General purpose and IO registers
        public Registers GPR, IOR;

        public ushort X
        {
            get
            {
                return (ushort)((SRAM[27] << 8) | SRAM[26]);
            }
            set
            {
                SRAM[27] = (byte)((value >> 8) & 0xFF);
                SRAM[26] = (byte)(value & 0xFF);
            }
        }

        public ushort Y
        {
            get
            {
                return (ushort)((SRAM[29] << 8) | SRAM[28]);
            }
            set
            {
                SRAM[29] = (byte)((value >> 8) & 0xFF);
                SRAM[28] = (byte)(value & 0xFF);
            }
        }

        public ushort Z
        {
            get
            {
                return (ushort)((SRAM[31] << 8) | SRAM[30]);
            }
            set
            {
                SRAM[31] = (byte)((value >> 8) & 0xFF);
                SRAM[30] = (byte)(value & 0xFF);
            }
        }

        public byte RAMPD
        {
            get
            {
                return IOR[0x38];
            }
            set
            {
                IOR[0x38] = value;
            }
        }

        public class Registers
        {
            private int mStart { get; set; }

            public Registers(int start)
            {
                mStart = start;
            }

            public byte this[int index]
            {
                get
                {
                    return SRAM[mStart + index];
                }
                set
                {
                    SRAM[mStart + index] = value;
                }
            }
        }
    }
}