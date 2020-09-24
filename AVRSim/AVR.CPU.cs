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
        public static byte[] SRAM;
        public int currentInstruction = 0, nextInstruction = 0;
        public int PC = 0;
        public int words = 0, cycles = 0;
        public bool isHalted = false;

        public void Run()
        {
            while (!isHalted)
            {
                Step();
            }
        }

        public void Step()
        {
            if (!isHalted)
            {
                currentInstruction = FLASH[PC];

                // ADC
                // 0001 11rd dddd rrrr
                if ((currentInstruction & 0xFC00) == 0x1C00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ADD
                // 0000 11rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x0C00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ADIW
                // 1001 0110 KKdd KKKK
                else if ((currentInstruction & 0xFF00) == 0x9600)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // AND
                // 0010 00rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x2000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ANDI
                // 0111 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x7000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ASR
                // 1001 010d dddd 0101
                else if ((currentInstruction & 0xFE0F) == 0x9405)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // BCLR
                // 1001 0100 1sss 1000
                else if ((currentInstruction & 0xFF8F) == 0x9488)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // BLD
                // 1111 100d dddd 0bbb
                else if ((currentInstruction & 0xFE08) == 0xF800)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // BRBC
                // 1111 01kk kkkk ksss
                else if ((currentInstruction & 0xFC00) == 0xF400)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRBS
                // 1111 00kk kkkk ksss
                else if ((currentInstruction & 0xFC00) == 0xF000)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRCC
                // 1111 01kk kkkk k000
                else if ((currentInstruction & 0xFC07) == 0xF400)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRCS
                // 1111 00kk kkkk k000
                else if ((currentInstruction & 0xFC07) == 0xF000)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BREAK
                // 1001 0101 1001 1000
                else if (currentInstruction == 0x9598)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // BREQ
                // 1111 00kk kkkk k001
                else if ((currentInstruction & 0xFC07) == 0xF001)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRGE
                // 1111 01kk kkkk k100
                else if ((currentInstruction & 0xFC07) == 0xF404)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRHC
                // 1111 01kk kkkk k101
                else if ((currentInstruction & 0xFC07) == 0xF405)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRHS
                // 1111 00kk kkkk k101
                else if ((currentInstruction & 0xFC07) == 0xF005)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRID
                // 1111 01kk kkkk k111
                else if ((currentInstruction & 0xFC07) == 0xF407)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRIE
                // 1111 00kk kkkk k111
                else if ((currentInstruction & 0xFC07) == 0xF007)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRLO
                // 1111 00kk kkkk k000
                //else if ((currentInstruction & 0xFC07) == 0xF000)
                //{
                //    PC++;
                //    words++;
                //    cycles++; // 2 if cond is true
                //    isHalted = true;
                //}

                // BRLT
                // 1111 00kk kkkk k100
                else if ((currentInstruction & 0xFC07) == 0xF004)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRMI
                // 1111 00kk kkkk k010
                else if ((currentInstruction & 0xFC07) == 0xF002)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRNE
                // 1111 01kk kkkk k001
                else if ((currentInstruction & 0xFC07) == 0xF401)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRPL
                // 1111 01kk kkkk k010
                else if ((currentInstruction & 0xFC07) == 0xF402)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRSH
                // 1111 01kk kkkk k000
                //else if ((currentInstruction & 0xFC07) == 0xF400)
                //{
                //    PC++;
                //    words++;
                //    cycles++; // 2 if cond is true
                //    isHalted = true;
                //}

                // BRTC
                // 1111 01kk kkkk k110
                else if ((currentInstruction & 0xFC07) == 0xF406)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRTS
                // 1111 00kk kkkk k110
                else if ((currentInstruction & 0xFC07) == 0xF006)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRVC
                // 1111 01kk kkkk k011
                else if ((currentInstruction & 0xFC07) == 0xF403)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRVS
                // 1111 00kk kkkk k011
                else if ((currentInstruction & 0xFC07) == 0xF003)
                {
                    PC++;
                    words++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BSET
                // 1001 0100 0sss 1000
                else if ((currentInstruction & 0xFF8F) == 0x9408)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // BST
                // 1111 101d dddd 0bbb
                else if ((currentInstruction & 0xFE08) == 0xFA00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CALL
                // 1001 010k kkkk 111k
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0E) == 0x940E)
                {
                    PC += 2;
                    words += 2;
                    cycles += 4;
                    isHalted = true;
                }

                // CBI
                // 1001 1000 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9800)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // CBR
                // 1001 1000 AAAA Abbb
                //else if ((currentInstruction & 0xFF00) == 0x9800)
                //{
                //    PC++;
                //    words++;
                //    cycles++;
                //    isHalted = true;
                //}

                // CLC
                // 1001 0100 1000 1000
                else if (currentInstruction == 0x9488)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLH
                // 1001 0100 1101 1000
                else if (currentInstruction == 0x94D8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLI
                // 1001 0100 1111 1000
                else if (currentInstruction == 0x94F8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLN
                // 1001 0100 1010 1000
                else if (currentInstruction == 0x94A8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLS
                // 1001 0100 1100 1000
                else if (currentInstruction == 0x94C8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLT
                // 1001 0100 1110 1000
                else if (currentInstruction == 0x94E8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLV
                // 1001 0100 1011 1000
                else if (currentInstruction == 0x94B8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CLZ
                // 1001 0100 1001 1000
                else if (currentInstruction == 0x9498)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // COM
                // 1001 010d dddd 0000
                else if ((currentInstruction & 0xFE0F) == 0x9400)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CP
                // 0001 01rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1400)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CPC
                // 0000 01rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x0400)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // CPI
                // 0011 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x3000)
                {
                    byte rd_val = GPR[((currentInstruction >> 4) & 0xF) + 0x10];
                    byte kk = (byte)(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
                    byte result = (byte)(rd_val - kk);
                    SREG_C = kk > rd_val;
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((rd_val & 0x80) >> 7) & ~((kk & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((rd_val & 0x80) >> 7) & ((kk & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((rd_val & 0x8) >> 3) & ((kk & 0x8) >> 3) | ((kk & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((rd_val & 0x8) >> 3)) != 0;
                    PC++;
                    words++;
                    cycles++;
                }

                // CPSE
                // 0001 00rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // DEC
                // 1001 010d dddd 1010
                else if ((currentInstruction & 0xFE0F) == 0x940A)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // DES
                // 1001 0100 KKKK 1011
                else if ((currentInstruction & 0xFF0F) == 0x940B)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // DES
                // 1001 0100 KKKK 1011
                else if ((currentInstruction & 0xFF0F) == 0x940B)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // EICALL
                // 1001 0101 0001 1001
                else if (currentInstruction == 0x9519)
                {
                    PC++;
                    words++;
                    cycles += 4;
                    isHalted = true;
                }

                // EIJMP
                // 1001 0100 0001 1001
                else if (currentInstruction == 0x9419)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // ELPM
                // 1001 0101 1101 1000
                else if (currentInstruction == 0x95D8)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // ELPM Z
                // 1001 000d dddd 0110
                else if ((currentInstruction & 0xFE0F) == 0x9006)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // ELPM Z+
                // 1001 000d dddd 0111
                else if ((currentInstruction & 0xFE0F) == 0x9007)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // EOR or CLR
                // 0010 01rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x2400)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    int result = GPR[rd] ^ GPR[rr];
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = false;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[rd] = (byte)result;
                    PC++;
                    words++;
                    cycles++;
                }

                // FMUL
                // 0000 0011 0ddd 1rrr
                else if ((currentInstruction & 0xFF88) == 0x0308)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // FMULS
                // 0000 0011 1ddd 0rrr
                else if ((currentInstruction & 0xFF88) == 0x0380)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // FMULSU
                // 0000 0011 1ddd 1rrr
                else if ((currentInstruction & 0xFF88) == 0x0388)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // ICALL
                // 1001 0101 0000 1001
                else if (currentInstruction == 0x9509)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // IJMP
                // 1001 0100 0000 1001
                else if (currentInstruction == 0x9409)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // IN
                // 1011 0AAd dddd AAAA
                else if ((currentInstruction & 0xF800) == 0xB000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // INC
                // 1001 010d dddd 0011
                else if ((currentInstruction & 0xFE0F) == 0x9403)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // JMP
                // 1001 010k kkkk 110k
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0E) == 0x940C)
                {
                    nextInstruction = FLASH[PC + 1];
                    PC = ((currentInstruction & 0x01F0) << 17) | ((currentInstruction & 0x1) << 16) | (FLASH[PC + 1] & 0xFFFF);
                    words += 2;
                    cycles += 3;
                }

                // LAC
                // 1001 001r rrrr 0110
                else if ((currentInstruction & 0xFE0F) == 0x9206)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // LAS
                // 1001 001r rrrr 0101
                else if ((currentInstruction & 0xFE0F) == 0x9205)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // LAT
                // 1001 001r rrrr 0111
                else if ((currentInstruction & 0xFE0F) == 0x9207)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // LD X
                // 1001 000d dddd 1100
                else if ((currentInstruction & 0xFE0F) == 0x900C)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // LD X+
                // 1001 000d dddd 1101
                else if ((currentInstruction & 0xFE0F) == 0x900D)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // LD -X
                // 1001 000d dddd 1110
                else if ((currentInstruction & 0xFE0F) == 0x900E)
                {
                    PC++;
                    words++;
                    cycles += 3; // 1 more for access sram
                    isHalted = true;
                }

                // LD Y
                // 1000 000d dddd 1000
                else if ((currentInstruction & 0xFE0F) == 0x8008)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // LD Y+
                // 1001 000d dddd 1001
                else if ((currentInstruction & 0xFE0F) == 0x9009)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // LD -Y
                // 1001 000d dddd 1010
                else if ((currentInstruction & 0xFE0F) == 0x900A)
                {
                    PC++;
                    words++;
                    cycles += 3; // 1 more for access sram
                    isHalted = true;
                }

                // LD Y+q
                // 10q0 qq0d dddd 1qqq
                else if ((currentInstruction & 0xD208) == 0x8008)
                {
                    PC++;
                    words++;
                    cycles += 2; // 1 more for access sram
                    isHalted = true;
                }

                // LD Z
                // 1000 000d dddd 0000
                else if ((currentInstruction & 0xFE0F) == 0x8000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // LD Z+
                // 1001 000d dddd 0001
                else if ((currentInstruction & 0xFE0F) == 0x9001)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // LD -Z
                // 1001 000d dddd 0010
                else if ((currentInstruction & 0xFE0F) == 0x9002)
                {
                    PC++;
                    words++;
                    cycles += 3; // 1 more for access sram
                    isHalted = true;
                }

                // LD Z+q
                // 10q0 qq0d dddd 0qqq
                else if ((currentInstruction & 0xD208) == 0x8000)
                {
                    PC++;
                    words++;
                    cycles += 2; // 1 more for access sram
                    isHalted = true;
                }

                // LDI
                // 1110 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0xE000)
                {
                    GPR[((currentInstruction >> 4) & 0xF) + 0x10] = (byte)(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
                    PC++;
                    words++;
                    cycles++;
                }

                // LDS
                // 1001 000d dddd 0000
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0F) == 0x9000)
                {
                    PC += 2;
                    words += 2;
                    cycles += 2;
                    isHalted = true;
                }

                // LDS
                // 1010 0kkk dddd kkkk
                else if ((currentInstruction & 0xF800) == 0xA000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // LPM
                // 1001 0101 1100 1000
                else if (currentInstruction == 0x95C8)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // LPM Z
                // 1001 000d dddd 0100
                else if ((currentInstruction & 0xFE0F) == 0x9004)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // LPM Z+
                // 1001 000d dddd 0101
                else if ((currentInstruction & 0xFE0F) == 0x9005)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // LSL
                // 0000 11dd dddd dddd
                else if ((currentInstruction & 0xFC00) == 0x0C00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // LSR
                // 1001 010d dddd 0110
                else if ((currentInstruction & 0xFE0F) == 0x9406)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // MOV
                // 1001 010d dddd 0110
                else if ((currentInstruction & 0xFC00) == 0x2C00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // MOVW
                // 0000 0001 dddd rrrr
                else if ((currentInstruction & 0xFF00) == 0x0100)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // MUL
                // 1001 11rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x9C00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // MULS
                // 0000 0010 dddd rrrr
                else if ((currentInstruction & 0xFF00) == 0x0200)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // MULSU
                // 0000 0011 0ddd 0rrr
                else if ((currentInstruction & 0xFF88) == 0x0300)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // NEG
                // 1001 010d dddd 0001
                else if ((currentInstruction & 0xFE0F) == 0x9401)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // NOP
                // 0000 0000 0000 0000
                else if (currentInstruction == 0x0000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // OR
                // 0010 10rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x2800)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ORI
                // 0110 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x6000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // OUT
                // 1011 1AAr rrrr AAAA
                else if ((currentInstruction & 0xF800) == 0xB800)
                {
                    IOR[((currentInstruction >> 5) & 0x30) | (currentInstruction & 0xF)] = GPR[(currentInstruction >> 4) & 0x1F];
                    PC++;
                    words++;
                    cycles++;
                }

                // POP
                // 1001 000d dddd 1111
                else if ((currentInstruction & 0xFE0F) == 0x900F)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // PUSH
                // 1001 001d dddd 1111
                else if ((currentInstruction & 0xFE0F) == 0x920F)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // RCALL
                // 1101 kkkk kkkk kkkk
                else if ((currentInstruction & 0xF000) == 0xD000)
                {
                    PC++;
                    words++;
                    cycles += 3;
                    isHalted = true;
                }

                // RET
                // 1001 0101 0000 1000
                else if (currentInstruction == 0x9508)
                {
                    PC++;
                    words++;
                    cycles += 4;
                    isHalted = true;
                }

                // RETI
                // 1001 0101 0001 1000
                else if (currentInstruction == 0x9518)
                {
                    PC++;
                    words++;
                    cycles += 4;
                    isHalted = true;
                }

                // RJMP
                // 1100 kkkk kkkk kkkk
                else if ((currentInstruction & 0xF000) == 0xC000)
                {
                    PC += (((currentInstruction << 20) >> 20) + 1);
                    words++;
                    cycles += 2;
                }

                // ROL
                // 0001 11dd dddd dddd
                else if ((currentInstruction & 0xFC00) == 0x1C00)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ROR
                // 1001 010d dddd 0111
                else if ((currentInstruction & 0xFE0F) == 0x9407)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SBC
                // 0000 10rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x0800)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SBCI
                // 0100 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x0400)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SBI
                // 1001 1010 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9A00)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // SBIC
                // 1001 1001 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9900)
                {
                    PC++;
                    words++;
                    cycles++;//1 = no skip, 2,3 skip next instr
                    isHalted = true;
                }

                // SBIS
                // 1001 1011 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9B00)
                {
                    PC++;
                    words++;
                    cycles++;//1 = no skip, 2,3 skip next instr
                    isHalted = true;
                }

                // SBIW
                // 1001 0111 KKdd KKKK
                else if ((currentInstruction & 0xFF00) == 0x9700)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // SBR
                // 0110 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x6000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SBRC
                // 1111 110r rrrr 0bbb
                else if ((currentInstruction & 0xFE08) == 0xFC00)
                {
                    PC++;
                    words++;
                    cycles++;//1 = no skip, 2,3 skip next instr
                    isHalted = true;
                }

                // SBRS
                // 1111 111r rrrr 0bbb
                else if ((currentInstruction & 0xFE08) == 0xFE00)
                {
                    PC++;
                    words++;
                    cycles++;//1 = no skip, 2,3 skip next instr
                    isHalted = true;
                }

                // SEC
                // 1001 0100 0000 1000
                else if (currentInstruction == 0x9408)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SEH
                // 1001 0100 0101 1000
                else if (currentInstruction == 0x9458)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SEI
                // 1001 0100 0111 1000
                else if (currentInstruction == 0x9478)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SEN
                // 1001 0100 0010 1000
                else if (currentInstruction == 0x9428)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SER
                // 1110 1111 dddd 1111
                else if ((currentInstruction & 0xFF0F) == 0xEF0F)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SES
                // 1001 0100 0100 1000
                else if (currentInstruction == 0x9448)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SET
                // 1001 0100 0110 1000
                else if (currentInstruction == 0x9468)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SEV
                // 1001 0100 0011 1000
                else if (currentInstruction == 0x9438)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SEZ
                // 1001 0100 0001 1000
                else if (currentInstruction == 0x9418)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SLEEP
                // 1001 0101 1000 1000
                else if (currentInstruction == 0x9588)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SPM
                // 1001 0101 1110 1000
                else if (currentInstruction == 0x95E8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SPM
                // 1001 0101 1110 1000
                else if (currentInstruction == 0x95F8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST X
                // 1001 001r rrrr 1100
                else if ((currentInstruction & 0xFE0F) == 0x920C)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST X+
                // 1001 001r rrrr 1101
                else if ((currentInstruction & 0xFE0F) == 0x920D)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST -X
                // 1001 001r rrrr 1110
                else if ((currentInstruction & 0xFE0F) == 0x920E)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // ST Y
                // 1000 001r rrrr 1000
                else if ((currentInstruction & 0xFE0F) == 0x8208)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST Y+
                // 1001 001r rrrr 1001
                else if ((currentInstruction & 0xFE0F) == 0x9209)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST -Y
                // 1001 001r rrrr 1010
                else if ((currentInstruction & 0xFE0F) == 0x920A)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // ST Y+q
                // 10q0 qq1r rrrr 1qqq
                else if ((currentInstruction & 0xD208) == 0x8208)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // ST Z
                // 1000 001r rrrr 0000
                else if ((currentInstruction & 0xFE0F) == 0x8200)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST Z+
                // 1001 001r rrrr 0001
                else if ((currentInstruction & 0xFE0F) == 0x9201)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // ST -Y
                // 1001 001r rrrr 0010
                else if ((currentInstruction & 0xFE0F) == 0x9202)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // ST Y+q
                // 10q0 qq1r rrrr 1qqq
                else if ((currentInstruction & 0xD208) == 0x8200)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }

                // STS
                // 1001 001d dddd 0000
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0F) == 0x9200)
                {
                    PC += 2;
                    words += 2;
                    cycles += 2;
                    isHalted = true;
                }

                // STS
                // 1010 1kkk dddd kkkk
                else if ((currentInstruction & 0xF800) == 0xA800)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SUB
                // 0001 10rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1800)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SUBI
                // 0101 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x5000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // SWAP
                // 1001 010d dddd 0010
                else if ((currentInstruction & 0xFE0F) == 0x9402)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // TST
                // 1001 010d dddd 0010
                else if ((currentInstruction & 0xFC00) == 0x2000)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // WDR
                // 1001 0101 1010 1000
                else if (currentInstruction == 0x95A8)
                {
                    PC++;
                    words++;
                    cycles++;
                    isHalted = true;
                }

                // XCH
                // 1001 0101 1010 1000
                else if ((currentInstruction & 0xFE0F) == 0x9204)
                {
                    PC++;
                    words++;
                    cycles += 2;
                    isHalted = true;
                }
            }
        }
    }
}