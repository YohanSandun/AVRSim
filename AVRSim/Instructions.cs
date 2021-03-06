﻿//---------------------------------------------------------------------------
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

namespace AVRSim
{
    internal class Instructions
    {
        private static string GetRd(int instruction)
        {
            return GetRegisterName((instruction >> 4) & 0x1F);
        }

        private static string GetRr(int instruction)
        {
            return GetRegisterName(((instruction >> 5) & 0x10) | (instruction & 0xF));
        }

        private static string GetHex(int num)
        {
            return "$" + Convert.ToString(num, 16).ToUpper();
        }

        private static string GetHexByte(int num)
        {
            if (num > 15)
                return "$" + Convert.ToString(num, 16).ToUpper();
            else
                return "$0" + Convert.ToString(num, 16).ToUpper();
        }

        public static string GetInstructionString(int currentInstruction, int nextInstruction)
        {
            // CLI
            // 1001 0100 1111 1000
            if (currentInstruction == 0x94F8)
            {
                return "CLI";
            }

            // BREAK
            // 1001 0101 1001 1000
            else if (currentInstruction == 0x9598)
            {
                return "BREAK";
            }

            // SEI
            // 1001 0100 0111 1000
            else if (currentInstruction == 0x9478)
            {
                return "SEI";
            }

            // CLC
            // 1001 0100 1000 1000
            else if (currentInstruction == 0x9488)
            {
                return "";
            }

            // CLH
            // 1001 0100 1101 1000
            else if (currentInstruction == 0x94D8)
            {
                return "CLC";
            }

            // CLN
            // 1001 0100 1010 1000
            else if (currentInstruction == 0x94A8)
            {
                return "CLN";
            }

            // CLS
            // 1001 0100 1100 1000
            else if (currentInstruction == 0x94C8)
            {
                return "CLS";
            }

            // CLT
            // 1001 0100 1110 1000
            else if (currentInstruction == 0x94E8)
            {
                return "CLT";
            }

            // CLV
            // 1001 0100 1011 1000
            else if (currentInstruction == 0x94B8)
            {
                return "CLV";
            }

            // CLZ
            // 1001 0100 1001 1000
            else if (currentInstruction == 0x9498)
            {
                return "CLZ";
            }

            // EICALL
            // 1001 0101 0001 1001
            else if (currentInstruction == 0x9519)
            {
                return "EICALL";
            }

            // EIJMP
            // 1001 0100 0001 1001
            else if (currentInstruction == 0x9419)
            {
                return "EIJMP";
            }

            // ELPM
            // 1001 0101 1101 1000
            else if (currentInstruction == 0x95D8)
            {
                return "ELPM";
            }

            // ICALL
            // 1001 0101 0000 1001
            else if (currentInstruction == 0x9509)
            {
                return "ICALL";
            }

            // IJMP
            // 1001 0100 0000 1001
            else if (currentInstruction == 0x9409)
            {
                return "IJMP";
            }

            // LPM
            // 1001 0101 1100 1000
            else if (currentInstruction == 0x95C8)
            {
                return "LPM";
            }

            // NOP
            // 0000 0000 0000 0000
            else if (currentInstruction == 0x0000)
            {
                return "NOP";
            }

            // RET
            // 1001 0101 0000 1000
            else if (currentInstruction == 0x9508)
            {
                return "RET";
            }

            // RETI
            // 1001 0101 0001 1000
            else if (currentInstruction == 0x9518)
            {
                return "RETI";
            }

            // SEC
            // 1001 0100 0000 1000
            else if (currentInstruction == 0x9408)
            {
                return "SEC";
            }

            // SEH
            // 1001 0100 0101 1000
            else if (currentInstruction == 0x9458)
            {
                return "SEH";
            }

            // SEN
            // 1001 0100 0010 1000
            else if (currentInstruction == 0x9428)
            {
                return "SEN";
            }

            // SES
            // 1001 0100 0100 1000
            else if (currentInstruction == 0x9448)
            {
                return "SES";
            }

            // SET
            // 1001 0100 0110 1000
            else if (currentInstruction == 0x9468)
            {
                return "SET";
            }

            // SEV
            // 1001 0100 0011 1000
            else if (currentInstruction == 0x9438)
            {
                return "SEV";
            }

            // SEZ
            // 1001 0100 0001 1000
            else if (currentInstruction == 0x9418)
            {
                return "SEZ";
            }

            // SLEEP
            // 1001 0101 1000 1000
            else if (currentInstruction == 0x9588)
            {
                return "SLEEP";
            }

            // SPM
            // 1001 0101 1110 1000
            else if (currentInstruction == 0x95E8)
            {
                return "SPM";
            }

            // SPM
            // 1001 0101 1110 1000
            else if (currentInstruction == 0x95F8)
            {
                return "SPM";
            }

            // WDR
            // 1001 0101 1010 1000
            else if (currentInstruction == 0x95A8)
            {
                return "WDR";
            }

            // LSL
            // 0000 11dd dddd dddd
            else if ((currentInstruction & 0xFC00) == 0x0C00)
            {
                return "LSL";
            }

            // XCH
            // 1001 0101 1010 1000
            else if ((currentInstruction & 0xFE0F) == 0x9204)
            {
                return "XCH";
            }

            #region 0000

            // FMUL
            // 0000 0011 0ddd 1rrr
            else if ((currentInstruction & 0xFF88) == 0x0308)
            {
                return "FMUL";
            }

            // MULSU
            // 0000 0011 0ddd 0rrr
            else if ((currentInstruction & 0xFF88) == 0x0300)
            {
                return "MULSU";
            }

            // FMULS
            // 0000 0011 1ddd 0rrr
            else if ((currentInstruction & 0xFF88) == 0x0380)
            {
                return "FMULS";
            }

            // FMULSU
            // 0000 0011 1ddd 1rrr
            else if ((currentInstruction & 0xFF88) == 0x0388)
            {
                return "FMULSU";
            }

            // MOVW
            // 0000 0001 dddd rrrr
            else if ((currentInstruction & 0xFF00) == 0x0100)
            {
                return "MOVW " + GetRegisterName((((currentInstruction >> 4) & 0xF) << 1) + 1) + ":" + GetRegisterName(((currentInstruction >> 4) & 0xF) << 1) + ", " + GetRegisterName(((currentInstruction & 0xF) << 1) + 1) + ":" + GetRegisterName((currentInstruction & 0xF) << 1);
            }

            // MULS
            // 0000 0010 dddd rrrr
            else if ((currentInstruction & 0xFF00) == 0x0200)
            {
                return "MULS";
            }

            // ADD
            // 0000 11rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x0C00)
            {
                string rd = GetRd(currentInstruction);
                string rr = GetRr(currentInstruction);
                if (rd == rr)
                    return "LSL " + rd;
                else
                    return "ADD " + rd + ", " + rr;
            }

            // CPC
            // 0000 01rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x0400)
            {
                return "CPC " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }

            // SBC
            // 0000 10rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x0800)
            {
                return "SBC " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }
            #endregion

            #region 0001
            // ADC
            // 0001 11rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x1C00)
            {
                string rd = GetRd(currentInstruction);
                string rr = GetRr(currentInstruction);
                if (rd == rr)
                    return "ROL " + rd;
                else
                    return "ADC " + rd + ", " + rr;
            }

            // CP
            // 0001 01rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x1400)
            {
                return "CP " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }

            // CPSE
            // 0001 00rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x1000)
            {
                return "CPSE " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }

            // SUB
            // 0001 10rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x1800)
            {
                return "SUB " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }
            #endregion

            #region 0010
            // AND
            // 0010 00rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x2000)
            {
                return "AND " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }

            // EOR
            // 0010 01rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x2400)
            {
                if (GetRd(currentInstruction).Equals(GetRr(currentInstruction)))
                    return "CLR " + GetRd(currentInstruction);
                return "EOR " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }

            // MOV
            // 0010 11rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x2C00)
            {
                return "MOV " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }

            // OR
            // 0010 10rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x2800)
            {
                return "OR " + GetRd(currentInstruction) + ", " + GetRr(currentInstruction);
            }
            #endregion

            #region 0011
            // CPI
            // 0011 KKKK dddd KKKK
            else if ((currentInstruction & 0xF000) == 0x3000)
            {
                return "CPI " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10) + ", " + GetHexByte(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
            }
            #endregion

            #region 0100
            // SBCI
            // 0100 KKKK dddd KKKK
            else if ((currentInstruction & 0xF000) == 0x4000)
            {
                return "SBCI " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10) + ", " + GetHexByte(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
            }
            #endregion

            #region 0101
            // SUBI
            // 0101 KKKK dddd KKKK
            else if ((currentInstruction & 0xF000) == 0x5000)
            {
                return "SUBI " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10) + ", " + GetHexByte(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
            }
            #endregion

            #region 0110
            // ORI or SBR
            // 0110 KKKK dddd KKKK
            else if ((currentInstruction & 0xF000) == 0x6000)
            {
                return "ORI " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10) + ", " + GetHexByte(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
            }
            #endregion

            #region 0111
            // ANDI
            // 0111 KKKK dddd KKKK
            else if ((currentInstruction & 0xF000) == 0x7000)
            {
                return "ANDI " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10) + ", " + GetHexByte(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
            }
            #endregion

            #region 1000
            // LD Y
            // 1000 000d dddd 1000
            else if ((currentInstruction & 0xFE0F) == 0x8008)
            {
                return "LD Y";
            }

            // LD Z
            // 1000 000d dddd 0000
            else if ((currentInstruction & 0xFE0F) == 0x8000)
            {
                return "LD " + GetRd(currentInstruction) + ", Z";
            }

            // ST Y
            // 1000 001r rrrr 1000
            else if ((currentInstruction & 0xFE0F) == 0x8208)
            {
                return "ST Y";
            }

            // ST Z
            // 1000 001r rrrr 0000
            else if ((currentInstruction & 0xFE0F) == 0x8200)
            {
                return "ST Z";
            }
            #endregion

            #region 1001
            // BSET
            // 1001 0100 0sss 1000
            else if ((currentInstruction & 0xFF8F) == 0x9408)
            {
                return "BSET";
            }

            // BCLR
            // 1001 0100 1sss 1000
            else if ((currentInstruction & 0xFF8F) == 0x9488)
            {
                return "BCLR";
            }

            // DES
            // 1001 0100 KKKK 1011
            else if ((currentInstruction & 0xFF0F) == 0x940B)
            {
                return "DES";
            }

            // ASR
            // 1001 010d dddd 0101
            else if ((currentInstruction & 0xFE0F) == 0x9405)
            {
                return "ASR";
            }

            // COM
            // 1001 010d dddd 0000
            else if ((currentInstruction & 0xFE0F) == 0x9400)
            {
                return "COM " + GetRd(currentInstruction);
            }

            // DEC
            // 1001 010d dddd 1010
            else if ((currentInstruction & 0xFE0F) == 0x940A)
            {
                return "DEC " + GetRd(currentInstruction);
            }

            // ELPM Z
            // 1001 000d dddd 0110
            else if ((currentInstruction & 0xFE0F) == 0x9006)
            {
                return "ELPM Z";
            }

            // ELPM Z+
            // 1001 000d dddd 0111
            else if ((currentInstruction & 0xFE0F) == 0x9007)
            {
                return "ELPM Z+";
            }

            // INC
            // 1001 010d dddd 0011
            else if ((currentInstruction & 0xFE0F) == 0x9403)
            {
                return "INC " + GetRd(currentInstruction);
            }

            // LAC
            // 1001 001r rrrr 0110
            else if ((currentInstruction & 0xFE0F) == 0x9206)
            {
                return "LAC";
            }

            // LAS
            // 1001 001r rrrr 0101
            else if ((currentInstruction & 0xFE0F) == 0x9205)
            {
                return "LAS";
            }

            // LAT
            // 1001 001r rrrr 0111
            else if ((currentInstruction & 0xFE0F) == 0x9207)
            {
                return "LAT";
            }

            // LD X
            // 1001 000d dddd 1100
            else if ((currentInstruction & 0xFE0F) == 0x900C)
            {
                return "LD " + GetRd(currentInstruction) + ", X";
            }

            // LD X+
            // 1001 000d dddd 1101
            else if ((currentInstruction & 0xFE0F) == 0x900D)
            {
                return "LD X+";
            }

            // LD -X
            // 1001 000d dddd 1110
            else if ((currentInstruction & 0xFE0F) == 0x900E)
            {
                return "LD -X";
            }

            // LD Y+
            // 1001 000d dddd 1001
            else if ((currentInstruction & 0xFE0F) == 0x9009)
            {
                return "LD Y+";
            }

            // LD -Y
            // 1001 000d dddd 1010
            else if ((currentInstruction & 0xFE0F) == 0x900A)
            {
                return "LD -Y";
            }

            // LD Z+
            // 1001 000d dddd 0001
            else if ((currentInstruction & 0xFE0F) == 0x9001)
            {
                return "LD Z+";
            }

            // LD -Z
            // 1001 000d dddd 0010
            else if ((currentInstruction & 0xFE0F) == 0x9002)
            {
                return "LD -Z";
            }

            // LPM Z
            // 1001 000d dddd 0100
            else if ((currentInstruction & 0xFE0F) == 0x9004)
            {
                return "LPM " + GetRd(currentInstruction) + ", Z";
            }

            // LPM Z+
            // 1001 000d dddd 0101
            else if ((currentInstruction & 0xFE0F) == 0x9005)
            {
                return "LPM " + GetRd(currentInstruction) + ", Z+";
            }

            // LSR
            // 1001 010d dddd 0110
            else if ((currentInstruction & 0xFE0F) == 0x9406)
            {
                return "LSR " + GetRd(currentInstruction);
            }

            // NEG
            // 1001 010d dddd 0001
            else if ((currentInstruction & 0xFE0F) == 0x9401)
            {
                return "NEG";
            }

            // POP
            // 1001 000d dddd 1111
            else if ((currentInstruction & 0xFE0F) == 0x900F)
            {
                return "POP " + GetRd(currentInstruction);
            }

            // PUSH
            // 1001 001d dddd 1111
            else if ((currentInstruction & 0xFE0F) == 0x920F)
            {
                return "PUSH " + GetRd(currentInstruction);
            }

            // ROR
            // 1001 010d dddd 0111
            else if ((currentInstruction & 0xFE0F) == 0x9407)
            {
                return "ROR " + GetRd(currentInstruction);
            }

            // ST X
            // 1001 001r rrrr 1100
            else if ((currentInstruction & 0xFE0F) == 0x920C)
            {
                return "ST X, " + GetRd(currentInstruction);
            }

            // ST X+
            // 1001 001r rrrr 1101
            else if ((currentInstruction & 0xFE0F) == 0x920D)
            {
                return "ST X+, " + GetRegisterName((currentInstruction >> 4) & 0x1F);
            }

            // ST -X
            // 1001 001r rrrr 1110
            else if ((currentInstruction & 0xFE0F) == 0x920E)
            {
                return "ST -X";
            }

            // ST Y+
            // 1001 001r rrrr 1001
            else if ((currentInstruction & 0xFE0F) == 0x9209)
            {
                return "ST Y+";
            }

            // ST -Y
            // 1001 001r rrrr 1010
            else if ((currentInstruction & 0xFE0F) == 0x920A)
            {
                return "ST -Y";
            }

            // ST Z+
            // 1001 001r rrrr 0001
            else if ((currentInstruction & 0xFE0F) == 0x9201)
            {
                return "ST Z+";
            }

            // ST -Z
            // 1001 001r rrrr 0010
            else if ((currentInstruction & 0xFE0F) == 0x9202)
            {
                return "ST -Z";
            }

            // SWAP
            // 1001 010d dddd 0010
            else if ((currentInstruction & 0xFE0F) == 0x9402)
            {
                return "SWAP";
            }

            // TST
            // 1001 010d dddd 0010
            else if ((currentInstruction & 0xFC00) == 0x2000)
            {
                return "TST";
            }

            // STS
            // 1001 001d dddd 0000
            // kkkk kkkk kkkk kkkk
            else if ((currentInstruction & 0xFE0F) == 0x9200)
            {
                return "STS " + GetHex(nextInstruction) + ", " + GetRd(currentInstruction);
            }

            // LDS
            // 1001 000d dddd 0000
            // kkkk kkkk kkkk kkkk
            else if ((currentInstruction & 0xFE0F) == 0x9000)
            {
                return "LDS " + GetRd(currentInstruction) + ", " + GetHex(nextInstruction);
            }

            // CALL
            // 1001 010k kkkk 111k
            // kkkk kkkk kkkk kkkk
            else if ((currentInstruction & 0xFE0E) == 0x940E)
            {
                return "CALL " + GetHex(((currentInstruction & 0x01F0) << 17) | ((currentInstruction & 0x1) << 16) | nextInstruction);
            }

            // JMP
            // 1001 010k kkkk 110k
            // kkkk kkkk kkkk kkkk
            else if ((currentInstruction & 0xFE0E) == 0x940C)
            {
                return "JMP " + GetHex(nextInstruction);
            }

            // CBI
            // 1001 1000 AAAA Abbb
            else if ((currentInstruction & 0xFF00) == 0x9800)
            {
                return "CBI";
            }

            // SBI
            // 1001 1010 AAAA Abbb
            else if ((currentInstruction & 0xFF00) == 0x9A00)
            {
                return "SBI";
            }

            // SBIC
            // 1001 1001 AAAA Abbb
            else if ((currentInstruction & 0xFF00) == 0x9900)
            {
                return "SBIC";
            }

            // SBIS
            // 1001 1011 AAAA Abbb
            else if ((currentInstruction & 0xFF00) == 0x9B00)
            {
                return "SBIS " + GetRegisterName((currentInstruction >> 3 & 0x1F)) + ", " + (currentInstruction & 0x7);
            }

            // CBR
            // 1001 1000 AAAA Abbb
            //else if ((currentInstruction & 0xFF00) == 0x9800)
            //{
            //    return "CBR";
            //}

            // ADIW
            // 1001 0110 KKdd KKKK
            else if ((currentInstruction & 0xFF00) == 0x9600)
            {
                int rd = (((currentInstruction >> 4) & 0x3) * 2) + 24;
                return "ADIW " + GetRegisterName(rd + 1) + ":" + GetRegisterName(rd) + ", " + GetHex(((currentInstruction >> 2) & 0x30) | (currentInstruction & 0xF));
            }

            // SBIW
            // 1001 0111 KKdd KKKK
            else if ((currentInstruction & 0xFF00) == 0x9700)
            {
                int rd = (((currentInstruction >> 4) & 0x3) * 2) + 24;
                return "SBIW " + GetRegisterName(rd + 1) + ":" + GetRegisterName(rd) + ", " + GetHex(((currentInstruction >> 2) & 0x30) | (currentInstruction & 0xF));
            }

            // MUL
            // 1001 11rd dddd rrrr
            else if ((currentInstruction & 0xFC00) == 0x9C00)
            {
                return "MUL";
            }
            #endregion

            #region 1010
            // LDS
            // 1010 0kkk dddd kkkk
            else if ((currentInstruction & 0xF800) == 0xA000)
            {
                return "LDS";
            }

            // STS
            // 1010 1kkk dddd kkkk
            else if ((currentInstruction & 0xF800) == 0xA800)
            {
                return "STS";
            }
            #endregion

            #region 1011
            // IN
            // 1011 0AAd dddd AAAA
            else if ((currentInstruction & 0xF800) == 0xB000)
            {
                return "IN " + GetRd(currentInstruction) + ", " + GetRegisterName((((currentInstruction >> 5) & 0x30) | (currentInstruction & 0xF)) + 0x20);
            }

            // OUT
            // 1011 1AAr rrrr AAAA
            else if ((currentInstruction & 0xF800) == 0xB800)
            {
                return "OUT " + GetRegisterName((((currentInstruction >> 5) & 0x30) | (currentInstruction & 0xF)) + 0x20) + ", " + GetRd(currentInstruction);
            }
            #endregion

            #region 1100
            // RJMP
            // 1100 kkkk kkkk kkkk
            else if ((currentInstruction & 0xF000) == 0xC000)
            {
                int pos = ((currentInstruction << 20) >> 20) + 1;
                if (pos < 0)
                    return "RJMP -" + GetHexByte(pos * -1);
                return "RJMP +" + GetHexByte(pos);
            }
            #endregion

            #region 1101
            // RCALL
            // 1101 kkkk kkkk kkkk
            else if ((currentInstruction & 0xF000) == 0xD000)
            {
                return "RCALL";
            }
            #endregion

            #region 1110
            // LDI
            // 1110 KKKK dddd KKKK
            else if ((currentInstruction & 0xF000) == 0xE000)
            {
                int val = (currentInstruction >> 4) & 0xF0 | (currentInstruction & 0xF);
                if (val == 0xFF)
                    return "SER " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10);
                else
                    return "LDI " + GetRegisterName(((currentInstruction >> 4) & 0xF) + 0x10) + ", " + GetHexByte(val);
            }
            #endregion

            #region 1111
            // BREQ
            // 1111 00kk kkkk k001
            else if ((currentInstruction & 0xFC07) == 0xF001)
            {
                int adr = (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                if (adr < 0)
                    return "BREQ -" + GetHexByte(adr * -1);
                return "BREQ +" + GetHexByte(adr);
            }

            // BRCS
            // 1111 00kk kkkk k000
            else if ((currentInstruction & 0xFC07) == 0xF000)
            {
                int adr = (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                if (adr < 0)
                    return "BRCS -" + GetHex(adr * -1);
                else
                    return "BRCS +" + GetHex(adr);
            }

            // BRCC
            // 1111 01kk kkkk k000
            else if ((currentInstruction & 0xFC07) == 0xF400)
            {
                int adr = (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                if (adr < 0)
                    return "BRCC -" + GetHex(adr * -1);
                else
                    return "BRCC +" + GetHex(adr);
            }

            // BRGE
            // 1111 01kk kkkk k100
            else if ((currentInstruction & 0xFC07) == 0xF404)
            {
                int adr = (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                if (adr < 0)
                    return "BRGE -" + GetHex(adr * -1);
                else
                    return "BRGE +" + GetHex(adr);
            }

            // BRHC
            // 1111 01kk kkkk k101
            else if ((currentInstruction & 0xFC07) == 0xF405)
            {
                return "BRHC";
            }

            // BRHS
            // 1111 00kk kkkk k101
            else if ((currentInstruction & 0xFC07) == 0xF005)
            {
                return "BRHS";
            }

            // BRID
            // 1111 01kk kkkk k111
            else if ((currentInstruction & 0xFC07) == 0xF407)
            {
                return "BRID";
            }

            // BRIE
            // 1111 00kk kkkk k111
            else if ((currentInstruction & 0xFC07) == 0xF007)
            {
                return "BRIE";
            }

            // BRLO
            // 1111 00kk kkkk k000
            //else if ((currentInstruction & 0xFC07) == 0xF000)
            //{
            //    return "BRLO";
            //}

            // BRLT
            // 1111 00kk kkkk k100
            else if ((currentInstruction & 0xFC07) == 0xF004)
            {
                return "BRLT";
            }

            // BRMI
            // 1111 00kk kkkk k010
            else if ((currentInstruction & 0xFC07) == 0xF002)
            {
                return "BRMI";
            }

            // BRNE
            // 1111 01kk kkkk k001
            else if ((currentInstruction & 0xFC07) == 0xF401)
            {
                int adr = (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                if (adr < 0)
                    return "BRNE -" + GetHexByte(adr * -1);
                return "BRNE +" + GetHexByte(adr);
            }

            // BRTC
            // 1111 01kk kkkk k110
            else if ((currentInstruction & 0xFC07) == 0xF406)
            {
                int adr = (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                if (adr < 0)
                    return "BRTC -" + GetHexByte(adr * -1);
                return "BRTC +" + GetHexByte(adr);
            }

            // BRPL
            // 1111 01kk kkkk k010
            else if ((currentInstruction & 0xFC07) == 0xF402)
            {
                return "BRPL";
            }

            // BRSH
            // 1111 01kk kkkk k000
            //else if ((currentInstruction & 0xFC07) == 0xF400)
            //{
            //    return "BRSH";
            //}

            // BRTS
            // 1111 00kk kkkk k110
            else if ((currentInstruction & 0xFC07) == 0xF006)
            {
                return "BRTS";
            }

            // BRVC
            // 1111 01kk kkkk k011
            else if ((currentInstruction & 0xFC07) == 0xF403)
            {
                return "BRVC";
            }

            // BRVS
            // 1111 00kk kkkk k011
            else if ((currentInstruction & 0xFC07) == 0xF003)
            {
                return "BRVS";
            }

            // BLD
            // 1111 100d dddd 0bbb
            else if ((currentInstruction & 0xFE08) == 0xF800)
            {
                return "BLD";
            }

            // BST
            // 1111 101d dddd 0bbb
            else if ((currentInstruction & 0xFE08) == 0xFA00)
            {
                return "BST " + GetRd(currentInstruction) + ", " + (currentInstruction & 0x7);
            }

            // SBRC
            // 1111 110r rrrr 0bbb
            else if ((currentInstruction & 0xFE08) == 0xFC00)
            {
                return "SBRC " + GetRd(currentInstruction) + ", " + (currentInstruction & 0x7);
            }

            // SBRS
            // 1111 111r rrrr 0bbb
            else if ((currentInstruction & 0xFE08) == 0xFE00)
            {
                return "SBRS " + GetRd(currentInstruction) + ", " + (currentInstruction & 0x7);
            }

            // BRBS
            // 1111 00kk kkkk ksss
            else if ((currentInstruction & 0xFC00) == 0xF000)
            {
                return "BRBS";
            }

            // BRBC
            // 1111 01kk kkkk ksss
            else if ((currentInstruction & 0xFC00) == 0xF400)
            {
                return "BRBC";
            }
            #endregion

            #region 10q0
            // LDD Y+q
            // 10q0 qq0d dddd 1qqq
            else if ((currentInstruction & 0xD208) == 0x8008)
            {
                return "LDD " + GetRd(currentInstruction) + ", Y+" + (((currentInstruction & 0x2000) >> 8) | ((currentInstruction & 0xC00) >> 7) | (currentInstruction & 0x7));
            }

            // LDD Z+q
            // 10q0 qq0d dddd 0qqq
            else if ((currentInstruction & 0xD208) == 0x8000)
            {
                return "LDD " + GetRd(currentInstruction) + ", Z+" + (((currentInstruction & 0x2000) >> 8) | ((currentInstruction & 0xC00) >> 7) | (currentInstruction & 0x7));
            }

            // STD Y+q
            // 10q0 qq1r rrrr 1qqq
            else if ((currentInstruction & 0xD208) == 0x8208)
            {
                return "STD Y+" + (((currentInstruction & 0x2000) >> 8) | ((currentInstruction & 0xC00) >> 7) | (currentInstruction & 0x7)) + ", " + GetRd(currentInstruction);
            }

            // ST Z+q
            // 10q0 qq1r rrrr 0qqq
            else if ((currentInstruction & 0xD208) == 0x8200)
            {
                return "ST Y+q";
            }
            #endregion

            return "UNKNOWN " + GetHex(currentInstruction);
        }

        public static string GetRegisterName(int register)
        {
            if (register <= 25)
                return "R" + register;
            if (register == 26)
                return "XL";
            if (register == 27)
                return "XH";
            if (register == 28)
                return "YL";
            if (register == 29)
                return "YH";
            if (register == 30)
                return "ZL";
            if (register == 31)
                return "ZH";
            if (register == 0x23)
                return "PINB";
            if (register == 0x24)
                return "DDRB";
            if (register == 0x25)
                return "PORTB";
            if (register == 0x26)
                return "PINC";
            if (register == 0x27)
                return "DDRC";
            if (register == 0x28)
                return "PORTC";
            if (register == 0x29)
                return "PIND";
            if (register == 0x2A)
                return "DDRD";
            if (register == 0x2B)
                return "PORTD";
            if (register == 0x35)
                return "TIFR0";
            if (register == 0x36)
                return "TIFR1";
            if (register == 0x37)
                return "TIFR2";
            if (register == 0x3B)
                return "PCIFR";
            if (register == 0x3C)
                return "EIFR";
            if (register == 0x3D)
                return "EIMSK";
            if (register == 0x3E)
                return "GPIOR";
            if (register == 0x3F)
                return "EECR";
            if (register == 0x40)
                return "EEDR";
            if (register == 0x41)
                return "EEARL";
            if (register == 0x42)
                return "EEARH";
            if (register == 0x43)
                return "GTCCR";
            if (register == 0x44)
                return "TCCR0A";
            if (register == 0x45)
                return "TCCR0B";
            if (register == 0x46)
                return "TCNT0";
            if (register == 0x47)
                return "OCR0A";
            if (register == 0x48)
                return "OCR0B";
            if (register == 0x4A)
                return "GPIOR1";
            if (register == 0x4B)
                return "GPIOR2";
            if (register == 0x4C)
                return "SPCR";
            if (register == 0x4D)
                return "SPSR";
            if (register == 0x4E)
                return "SPDR";
            if (register == 0x50)
                return "ACSR";
            if (register == 0x53)
                return "SMCR";
            if (register == 0x54)
                return "MCUSR";
            if (register == 0x55)
                return "MCUCR";
            if (register == 0x57)
                return "SPMCSR";
            if (register == 0x5D)
                return "SPL";
            if (register == 0x5E)
                return "SPH";
            if (register == 0x5F)
                return "SREG";
            if (register == 0x60)
                return "WDTCSR";
            if (register == 0x61)
                return "CLKPR";
            if (register == 0x64)
                return "PRR";
            if (register == 0x66)
                return "OSCCAL";
            if (register == 0x68)
                return "PCICR";
            if (register == 0x69)
                return "EICRA";
            if (register == 0x6B)
                return "PCMSK0";
            if (register == 0x6C)
                return "PCMSK1";
            if (register == 0x6D)
                return "PCMSK2";
            if (register == 0x6E)
                return "TIMSK0";
            if (register == 0x6F)
                return "TIMSK1";
            if (register == 0x70)
                return "TIMSK2";
            if (register == 0x78)
                return "ADCL";
            if (register == 0x79)
                return "ADCH";
            if (register == 0x7A)
                return "ADCSRA";
            if (register == 0x7B)
                return "ADCSRB";
            if (register == 0x7C)
                return "ADMUX";
            if (register == 0x7E)
                return "DIDR0";
            if (register == 0x7F)
                return "DIDR1";
            if (register == 0x80)
                return "TCCR1A";
            if (register == 0x81)
                return "TCCR1B";
            if (register == 0x82)
                return "TCCR1C";
            if (register == 0x84)
                return "TCNT1L";
            if (register == 0x85)
                return "TCNT1H";
            if (register == 0x86)
                return "ICR1L";
            if (register == 0x87)
                return "ICR1H";
            if (register == 0x88)
                return "OCR1AL";
            if (register == 0x89)
                return "OCR1AH";
            if (register == 0x8A)
                return "OCR1BL";
            if (register == 0x8B)
                return "OCR1BH";
            if (register == 0xB0)
                return "TCCR2A";
            if (register == 0xB1)
                return "TCCR2B";
            if (register == 0xB2)
                return "TCNT2";
            if (register == 0xB3)
                return "OCR2A";
            if (register == 0xB4)
                return "OCR2B";
            if (register == 0xB6)
                return "ASSR";
            if (register == 0xB8)
                return "TWBR";
            if (register == 0xB9)
                return "TWSR";
            if (register == 0xBA)
                return "TWAR";
            if (register == 0xBB)
                return "TWDR";
            if (register == 0xBC)
                return "TWCR";
            if (register == 0xBD)
                return "TWAMR";
            if (register == 0xC0)
                return "UCSR0A";
            if (register == 0xC1)
                return "UCSR0B";
            if (register == 0xC2)
                return "UCSR0C";
            if (register == 0xC4)
                return "UBRR0L";
            if (register == 0xC5)
                return "UBRR0H";
            if (register == 0xC6)
                return "UDR0";
            return "REG 0x" + GetHex(register);
        }
    }
}