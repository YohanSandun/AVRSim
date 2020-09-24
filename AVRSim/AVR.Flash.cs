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
using System.Collections.Generic;

namespace AVRSim
{
    partial class AVR
    {
        public Flash FLASH;

        /**********************************
         * Flash
         * Returns 16bit (2 byte) integers
         **********************************/

        public class Flash
        {
            private byte[] FlashMemory;

            public Flash(int size, List<byte> byteList)
            {
                FlashMemory = new byte[size];
                for (int i = 0; i < byteList.Count; i++)
                    FlashMemory[i] = byteList[i];
            }

            public int this[int index]
            {
                get
                {
                    return (FlashMemory[index << 1] << 8) | FlashMemory[(index << 1) + 1];
                }
            }

            public int Length
            {
                get { return FlashMemory.Length; }
            }
        }
    }
}