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