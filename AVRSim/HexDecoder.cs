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
using System.Collections.Generic;
using System.IO;

//---------------------------------------------------------------------------
namespace AVRSim
{
    public class HexDecoder
    {
        public static List<byte> Decode(string fname)
        {
            List<byte> byteList = new List<byte>();

            string[] lines = File.ReadAllText(fname).Split(':');
            foreach (string sLine in lines)
            {
                string line = sLine.Trim();
                string data = "";

                int byteCount = 0;
                string hexData = "";
                for (int i = 0; i < line.Length; i++)
                {
                    data += line[i];
                    if (i == 1) // Byte count
                    {
                        byteCount = Convert.ToInt32(data, 16);
                        data = "";
                    }
                    else if (i == 5 // Address
                          || i == 7 // Record Type
                          || i == (2 * byteCount) + 9 // Check-sum
                          )
                        data = "";
                    else if (i == (2 * byteCount) + 7) // Data
                    {
                        hexData = data;
                        data = "";
                    }
                }
                byteList.AddRange(ParseHexData(hexData));
            }
            return byteList;
        }

        private static List<byte> ParseHexData(string hexData)
        {
            List<byte> byteList = new List<byte>();
            for (int i = 0; i < hexData.Length; i += 4)
            {
                if (i + 3 < hexData.Length)
                {
                    byteList.Add(Convert.ToByte(hexData.Substring(i + 2, 2), 16));
                    byteList.Add(Convert.ToByte(hexData.Substring(i, 2), 16));
                }
            }
            return byteList;
        }
    }
}