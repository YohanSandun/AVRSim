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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AVRSim
{
    partial class AVR
    {
        public static byte[] SRAM;
        public int currentInstruction = 0, nextInstruction = 0;
        public int PC = 0;
        public int words = 0, cycles = 0;
        public bool isHalted = false;
        public long instructionCounter = 0;

        public void Step()
        {
            if (!isHalted)
            {

                instructionCounter++;
                currentInstruction = FLASH[PC];

                #region Constant instructions
                // NOP
                // 0000 0000 0000 0000
                if (currentInstruction == 0x0000)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLI
                // 1001 0100 1111 1000
                else if (currentInstruction == 0x94F8)
                {
                    SREG_I = false;
                    PC++;
                    cycles++;
                }

                // BREAK
                // 1001 0101 1001 1000
                else if (currentInstruction == 0x9598)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // SEI
                // 1001 0100 0111 1000
                else if (currentInstruction == 0x9478)
                {
                    SREG_I = true;
                    PC++;
                    cycles++;
                }

                // CLC
                // 1001 0100 1000 1000
                else if (currentInstruction == 0x9488)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLH
                // 1001 0100 1101 1000
                else if (currentInstruction == 0x94D8)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLN
                // 1001 0100 1010 1000
                else if (currentInstruction == 0x94A8)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLS
                // 1001 0100 1100 1000
                else if (currentInstruction == 0x94C8)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLT
                // 1001 0100 1110 1000
                else if (currentInstruction == 0x94E8)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLV
                // 1001 0100 1011 1000
                else if (currentInstruction == 0x94B8)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // CLZ
                // 1001 0100 1001 1000
                else if (currentInstruction == 0x9498)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // EICALL
                // 1001 0101 0001 1001
                else if (currentInstruction == 0x9519)
                {
                    PC++;
                    cycles += 4;
                    isHalted = true;
                }

                // EIJMP
                // 1001 0100 0001 1001
                else if (currentInstruction == 0x9419)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // ELPM
                // 1001 0101 1101 1000
                else if (currentInstruction == 0x95D8)
                {
                    PC++;

                    cycles += 3;
                    isHalted = true;
                }

                // ICALL
                // 1001 0101 0000 1001
                else if (currentInstruction == 0x9509)
                {
                    PC++;

                    cycles += 3;
                    isHalted = true;
                }

                // IJMP
                // 1001 0100 0000 1001
                else if (currentInstruction == 0x9409)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LPM
                // 1001 0101 1100 1000
                else if (currentInstruction == 0x95C8)
                {
                    PC++;

                    cycles += 3;
                    isHalted = true;
                }

                // RET
                // 1001 0101 0000 1000
                else if (currentInstruction == 0x9508)
                {
                    PC = SRAM[++SP] << 8 | SRAM[++SP];
                    //TODO : see avr instruction set manual
                    //if (FLASH.Length > 0x20000)
                    //    PC |= SRAM[++SP] << 16;
                    cycles += 4;
                }

                // RETI
                // 1001 0101 0001 1000
                else if (currentInstruction == 0x9518)
                {
                    PC = SRAM[++SP] << 8 | SRAM[++SP];
                    //if (FLASH.Length > 0x20000)
                    //    PC |= SRAM[++SP] << 16;
                    SREG_I = true;
                    cycles += 4;
                }

                // SEC
                // 1001 0100 0000 1000
                else if (currentInstruction == 0x9408)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SEH
                // 1001 0100 0101 1000
                else if (currentInstruction == 0x9458)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SEN
                // 1001 0100 0010 1000
                else if (currentInstruction == 0x9428)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SES
                // 1001 0100 0100 1000
                else if (currentInstruction == 0x9448)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SET
                // 1001 0100 0110 1000
                else if (currentInstruction == 0x9468)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SEV
                // 1001 0100 0011 1000
                else if (currentInstruction == 0x9438)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SEZ
                // 1001 0100 0001 1000
                else if (currentInstruction == 0x9418)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SLEEP
                // 1001 0101 1000 1000
                else if (currentInstruction == 0x9588)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SPM
                // 1001 0101 1110 1000
                else if (currentInstruction == 0x95E8)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SPM
                // 1001 0101 1110 1000
                else if (currentInstruction == 0x95F8)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // WDR
                // 1001 0101 1010 1000
                else if (currentInstruction == 0x95A8)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // XCH
                // 1001 0101 1010 1000
                else if ((currentInstruction & 0xFE0F) == 0x9204)
                {
                    PC++;
                    cycles += 2;
                    isHalted = true;
                }
                #endregion

                #region Instructions starts with 0000
                // FMUL
                // 0000 0011 0ddd 1rrr
                else if ((currentInstruction & 0xFF88) == 0x0308)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // MULSU
                // 0000 0011 0ddd 0rrr
                else if ((currentInstruction & 0xFF88) == 0x0300)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // FMULS
                // 0000 0011 1ddd 0rrr
                else if ((currentInstruction & 0xFF88) == 0x0380)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // FMULSU
                // 0000 0011 1ddd 1rrr
                else if ((currentInstruction & 0xFF88) == 0x0388)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // MOVW
                // 0000 0001 dddd rrrr
                else if ((currentInstruction & 0xFF00) == 0x0100)
                {
                    GPR[(((currentInstruction >> 4) & 0xF) << 1) + 1] = GPR[((currentInstruction & 0xF) << 1) + 1];
                    GPR[((currentInstruction >> 4) & 0xF) << 1] = GPR[(currentInstruction & 0xF) << 1];
                    PC++;
                    cycles++;
                }

                // MULS
                // 0000 0010 dddd rrrr
                else if ((currentInstruction & 0xFF00) == 0x0200)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // ADD
                // 0000 11rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x0C00)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] + GPR[rr]);
                    SREG_C = (((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) | ((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((result & 0x80) >> 7) & ((GPR[rd] & 0x80) >> 7)) != 0;
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ~((GPR[rr] & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (((GPR[rd] & 0x8) >> 3) & ((GPR[rr] & 0x8) >> 3) | ((GPR[rr] & 0x8) >> 3) & ~((result & 0x8) >> 3) | ~((result & 0x8) >> 3) & ((GPR[rd] & 0x8) >> 3)) != 0;
                    GPR[rd] = result;
                    PC++;
                    cycles++;
                }

                // CPC
                // 0000 01rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x0400)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] - GPR[rr] - (SREG_C ? 1 : 0));
                    SREG_C = GPR[rr] + (SREG_C ? 1 : 0) > GPR[rd];
                    SREG_Z &= result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ~((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((GPR[rd] & 0x8) >> 3) & ((GPR[rr] & 0x8) >> 3) | ((GPR[rr] & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((GPR[rd] & 0x8) >> 3)) != 0;
                    PC++;

                    cycles++;
                }

                // SBC
                // 0000 10rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x0800)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] - GPR[rr] - (SREG_C ? 1 : 0));
                    SREG_C = (GPR[rr] + (SREG_C ? 1 : 0)) > GPR[rd];
                    SREG_Z &= result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ~((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((GPR[rd] & 0x8) >> 3) & ((GPR[rr] & 0x8) >> 3) | ((GPR[rr] & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((GPR[rd] & 0x8) >> 3)) != 0;
                    GPR[rd] = result;
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 0001
                // ADC & ROL
                // 0001 11rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1C00)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] + GPR[rr] + (SREG_C ? 1 : 0));
                    SREG_C = (((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) | ((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((result & 0x80) >> 7) & ((GPR[rd] & 0x80) >> 7)) != 0;
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ~((GPR[rr] & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (((GPR[rd] & 0x8) >> 3) & ((GPR[rr] & 0x8) >> 3) | ((GPR[rr] & 0x8) >> 3) & ~((result & 0x8) >> 3) | ~((result & 0x8) >> 3) & ((GPR[rd] & 0x8) >> 3)) != 0;
                    GPR[rd] = result;
                    PC++;
                    cycles++;
                }

                // CP
                // 0001 01rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1400)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] - GPR[rr]);
                    SREG_C = GPR[rr] > GPR[rd];
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ~((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((GPR[rd] & 0x8) >> 3) & ((GPR[rr] & 0x8) >> 3) | ((GPR[rr] & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((GPR[rd] & 0x8) >> 3)) != 0;
                    PC++;
                    cycles++;
                }

                // CPSE
                // 0001 00rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1000)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    if (GPR[rd] == GPR[rr])
                    {
                        if (Is16BitInstruction(FLASH[PC + 1]))
                        {
                            PC += 3;
                            cycles += 3;
                        }
                        else {
                            PC += 2;
                            cycles += 2;
                        }
                    }
                    else {
                        PC++;
                        cycles++;
                    }
                }

                // SUB
                // 0001 10rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x1800)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] - GPR[rr]);
                    SREG_C = GPR[rr] > GPR[rd];
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ~((GPR[rr] & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ((GPR[rr] & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((GPR[rd] & 0x8) >> 3) & ((GPR[rr] & 0x8) >> 3) | ((GPR[rr] & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((GPR[rd] & 0x8) >> 3)) != 0;
                    GPR[rd] = result;
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 0010
                // AND
                // 0010 00rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x2000)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    int result = GPR[rd] & GPR[rr];
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = false;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[rd] = (byte)result;
                    PC++;
                    cycles++;
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

                    cycles++;
                }

                // MOV
                // 0010 11rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x2C00)
                {
                    GPR[(currentInstruction >> 4) & 0x1F] = GPR[((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF)];
                    PC++;
                    cycles++;
                }

                // OR
                // 0010 10rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x2800)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    int rr = ((currentInstruction >> 5) & 0x10) | (currentInstruction & 0xF);
                    int result = GPR[rd] | GPR[rr];
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = false;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[rd] = (byte)result;
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 0011
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

                    cycles++;
                }
                #endregion

                #region Instructions starts with 0100
                // SBCI
                // 0100 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x4000)
                {
                    int rd = ((currentInstruction >> 4) & 0xF) + 0x10;
                    int kk = ((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF);
                    byte result = (byte)(GPR[rd] - kk - (SREG_C ? 1 : 0));
                    SREG_C = (kk + (SREG_C ? 1 : 0)) > GPR[rd];
                    SREG_Z &= result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ~((kk & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ((kk & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((GPR[rd] & 0x8) >> 3) & ((kk & 0x8) >> 3) | ((kk & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((GPR[rd] & 0x8) >> 3)) != 0;
                    GPR[rd] = result;
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 0101
                // SUBI
                // 0101 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x5000)
                {
                    int rd = ((currentInstruction >> 4) & 0xF) + 0x10;
                    byte kk = (byte)(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
                    byte result = (byte)(GPR[rd] - kk);
                    SREG_C = kk > GPR[rd];
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((GPR[rd] & 0x80) >> 7) & ~((kk & 0x80) >> 7) & ~((result & 0x80) >> 7) | ~((GPR[rd] & 0x80) >> 7) & ((kk & 0x80) >> 7) & ((result & 0x80) >> 7)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    SREG_H = (~((GPR[rd] & 0x8) >> 3) & ((kk & 0x8) >> 3) | ((kk & 0x8) >> 3) & ((result & 0x8) >> 3) | ((result & 0x8) >> 3) & ~((GPR[rd] & 0x8) >> 3)) != 0;
                    GPR[rd] = result;
                    PC++;

                    cycles++;
                }
                #endregion

                #region Instructions starts with 0110
                // ORI or SBR
                // 0110 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x6000)
                {
                    GPR[((currentInstruction >> 4) & 0xF) + 0x10] |= (byte)(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
                    SREG_Z = GPR[((currentInstruction >> 4) & 0xF) + 0x10] == 0;
                    SREG_N = ((GPR[((currentInstruction >> 4) & 0xF) + 0x10] & 0x80) >> 7) != 0;
                    SREG_V = false;
                    SREG_S = SREG_N ^ SREG_V;
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 0111
                // ANDI
                // 0111 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0x7000)
                {
                    GPR[((currentInstruction >> 4) & 0xF) + 0x10] &= (byte)(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
                    SREG_Z = GPR[((currentInstruction >> 4) & 0xF) + 0x10] == 0;
                    SREG_N = ((GPR[((currentInstruction >> 4) & 0xF) + 0x10] & 0x80) >> 7) != 0;
                    SREG_V = false;
                    SREG_S = SREG_N ^ SREG_V;
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 1000
                // LD Y
                // 1000 000d dddd 1000
                else if ((currentInstruction & 0xFE0F) == 0x8008)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // LD Z
                // 1000 000d dddd 0000
                else if ((currentInstruction & 0xFE0F) == 0x8000)
                {
                    GPR[(currentInstruction >> 4) & 0x1F] = SRAM[Z];
                    PC++;
                    cycles++;
                }

                // ST Y
                // 1000 001r rrrr 1000
                else if ((currentInstruction & 0xFE0F) == 0x8208)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // ST Z
                // 1000 001r rrrr 0000
                else if ((currentInstruction & 0xFE0F) == 0x8200)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }
                #endregion

                #region Instructions starts with 1001
                // BSET
                // 1001 0100 0sss 1000
                else if ((currentInstruction & 0xFF8F) == 0x9408)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // BCLR
                // 1001 0100 1sss 1000
                else if ((currentInstruction & 0xFF8F) == 0x9488)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // DES
                // 1001 0100 KKKK 1011
                else if ((currentInstruction & 0xFF0F) == 0x940B)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // ASR
                // 1001 010d dddd 0101
                else if ((currentInstruction & 0xFE0F) == 0x9405)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // COM
                // 1001 010d dddd 0000
                else if ((currentInstruction & 0xFE0F) == 0x9400)
                {
                    int rd = (currentInstruction >> 4) & 0x1F;
                    GPR[rd] = (byte)(0xFF - GPR[rd]);
                    SREG_C = true;
                    SREG_Z = GPR[rd] == 0;
                    SREG_N = ((GPR[rd] & 0x80) >> 7) != 0;
                    SREG_V = false;
                    SREG_S = SREG_N ^ SREG_V;
                    PC++;
                    cycles++;
                }

                // DEC
                // 1001 010d dddd 1010
                else if ((currentInstruction & 0xFE0F) == 0x940A)
                {
                    byte result = (byte)(GPR[(currentInstruction >> 4) & 0x1F] - 1);
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (~((result & 0x80) >> 7) & ((result & 0x40) >> 6) & ((result & 0x20) >> 5) & ((result & 0x10) >> 4) & ((result & 0x8) >> 3) & ((result & 0x4) >> 2) & ((result & 0x2) >> 1) & (result & 0x1)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[(currentInstruction >> 4) & 0x1F] = result;
                    PC++;
                    cycles++;
                }

                // ELPM Z
                // 1001 000d dddd 0110
                else if ((currentInstruction & 0xFE0F) == 0x9006)
                {
                    PC++;

                    cycles += 3;
                    isHalted = true;
                }

                // ELPM Z+
                // 1001 000d dddd 0111
                else if ((currentInstruction & 0xFE0F) == 0x9007)
                {
                    PC++;

                    cycles += 3;
                    isHalted = true;
                }

                // INC
                // 1001 010d dddd 0011
                else if ((currentInstruction & 0xFE0F) == 0x9403)
                {
                    byte result = (byte)(GPR[(currentInstruction >> 4) & 0x1F] + 1);
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x80) >> 7) != 0;
                    SREG_V = (((result & 0x80) >> 7) & ~((result & 0x40) >> 6) & ~((result & 0x20) >> 5) & ~((result & 0x10) >> 4) & ~((result & 0x8) >> 3) & ~((result & 0x4) >> 2) & ~((result & 0x2) >> 1) & ~(result & 0x1)) != 0;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[(currentInstruction >> 4) & 0x1F] = result;
                    PC++;
                    cycles++;
                }

                // LAC
                // 1001 001r rrrr 0110
                else if ((currentInstruction & 0xFE0F) == 0x9206)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LAS
                // 1001 001r rrrr 0101
                else if ((currentInstruction & 0xFE0F) == 0x9205)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LAT
                // 1001 001r rrrr 0111
                else if ((currentInstruction & 0xFE0F) == 0x9207)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LD X
                // 1001 000d dddd 1100
                else if ((currentInstruction & 0xFE0F) == 0x900C)
                {
                    GPR[(currentInstruction >> 4) & 0x1F] = SRAM[X];
                    PC++;
                    cycles++;
                }

                // LD X+
                // 1001 000d dddd 1101
                else if ((currentInstruction & 0xFE0F) == 0x900D)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LD -X
                // 1001 000d dddd 1110
                else if ((currentInstruction & 0xFE0F) == 0x900E)
                {
                    PC++;

                    cycles += 3; // 1 more for access sram
                    isHalted = true;
                }

                // LD Y+
                // 1001 000d dddd 1001
                else if ((currentInstruction & 0xFE0F) == 0x9009)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LD -Y
                // 1001 000d dddd 1010
                else if ((currentInstruction & 0xFE0F) == 0x900A)
                {
                    PC++;

                    cycles += 3; // 1 more for access sram
                    isHalted = true;
                }

                // LD Z+
                // 1001 000d dddd 0001
                else if ((currentInstruction & 0xFE0F) == 0x9001)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // LD -Z
                // 1001 000d dddd 0010
                else if ((currentInstruction & 0xFE0F) == 0x9002)
                {
                    PC++;

                    cycles += 3; // 1 more for access sram
                    isHalted = true;
                }

                // LPM Z
                // 1001 000d dddd 0100
                else if ((currentInstruction & 0xFE0F) == 0x9004)
                {
                    if ((Z & 0x1) == 0)
                        GPR[(currentInstruction >> 4) & 0x1F] = (byte)(FLASH[Z >> 1] & 0xFF);
                    else
                        GPR[(currentInstruction >> 4) & 0x1F] = (byte)((FLASH[Z >> 1] >> 8) & 0xFF);
                    PC++;
                    cycles += 3;
                }

                // LPM Z+
                // 1001 000d dddd 0101
                else if ((currentInstruction & 0xFE0F) == 0x9005)
                {
                    if ((Z & 0x1) == 0)
                        GPR[(currentInstruction >> 4) & 0x1F] = (byte)(FLASH[Z >> 1] & 0xFF);
                    else
                        GPR[(currentInstruction >> 4) & 0x1F] = (byte)((FLASH[Z >> 1] >> 8) & 0xFF);
                    Z++;
                    PC++;
                    cycles += 3;
                }

                // LSR
                // 1001 010d dddd 0110
                else if ((currentInstruction & 0xFE0F) == 0x9406)
                {
                    int rdadr = (currentInstruction >> 4) & 0x1F;
                    bool tempC = (GPR[rdadr] & 0x1) == 1;
                    GPR[rdadr] >>= 1;
                    GPR[rdadr] |= (byte)((SREG_C ? 1 : 0) << 7);
                    SREG_C = tempC;
                    SREG_Z = GPR[rdadr] == 0;
                    SREG_N = false;
                    SREG_V = SREG_N ^ SREG_C;
                    SREG_S = SREG_N ^ SREG_V;
                    PC++;
                    cycles++;
                }

                // NEG
                // 1001 010d dddd 0001
                else if ((currentInstruction & 0xFE0F) == 0x9401)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // POP
                // 1001 000d dddd 1111
                else if ((currentInstruction & 0xFE0F) == 0x900F)
                {
                    GPR[(currentInstruction >> 4) & 0x1F] = SRAM[++SP];
                    PC++;
                    cycles += 2;
                }

                // PUSH
                // 1001 001d dddd 1111
                else if ((currentInstruction & 0xFE0F) == 0x920F)
                {
                    SRAM[SP--] = GPR[(currentInstruction >> 4) & 0x1F];
                    PC++;
                    cycles += 2;
                }

                // ROR
                // 1001 010d dddd 0111
                else if ((currentInstruction & 0xFE0F) == 0x9407)
                {
                    int rdadr = (currentInstruction >> 4) & 0x1F;
                    bool tempC = (GPR[rdadr] & 0x1) == 1;
                    GPR[rdadr] >>= 1;
                    GPR[rdadr] |= (byte)((SREG_C ? 1 : 0) << 7);
                    SREG_C = tempC;
                    SREG_Z = GPR[rdadr] == 0;
                    SREG_N = (GPR[rdadr] & 0x80) == 1;
                    SREG_V = SREG_N ^ SREG_C;
                    SREG_S = SREG_N ^ SREG_V;
                    PC++;
                    cycles++;
                }

                // ST X
                // 1001 001r rrrr 1100
                else if ((currentInstruction & 0xFE0F) == 0x920C)
                {
                    SRAM[X] = GPR[(currentInstruction >> 4) & 0x1F];
                    PC++;
                    cycles++;
                }

                // ST X+
                // 1001 001r rrrr 1101
                else if ((currentInstruction & 0xFE0F) == 0x920D)
                {
                    SRAM[X++] = GPR[(currentInstruction >> 4) & 0x1F];
                    PC++;

                    cycles++;
                }

                // ST -X
                // 1001 001r rrrr 1110
                else if ((currentInstruction & 0xFE0F) == 0x920E)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // ST Y+
                // 1001 001r rrrr 1001
                else if ((currentInstruction & 0xFE0F) == 0x9209)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // ST -Y
                // 1001 001r rrrr 1010
                else if ((currentInstruction & 0xFE0F) == 0x920A)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // ST -Z
                // 1001 001r rrrr 0010
                else if ((currentInstruction & 0xFE0F) == 0x9202)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // ST Z+
                // 1001 001r rrrr 0001
                else if ((currentInstruction & 0xFE0F) == 0x9201)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // SWAP
                // 1001 010d dddd 0010
                else if ((currentInstruction & 0xFE0F) == 0x9402)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // TST
                // 1001 010d dddd 0010
                else if ((currentInstruction & 0xFC00) == 0x2000)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }

                // STS
                // 1001 001d dddd 0000
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0F) == 0x9200)
                {
                    nextInstruction = FLASH[PC + 1];
                    SRAM[nextInstruction + RAMPD] = GPR[(currentInstruction >> 4) & 0x1F];
                    nextInstruction += RAMPD;
                    PC += 2;
                    words += 2;
                    cycles += 2;
                }

                // LDS
                // 1001 000d dddd 0000
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0F) == 0x9000)
                {
                    nextInstruction = FLASH[PC + 1];
                    GPR[(currentInstruction >> 4) & 0x1F] = SRAM[nextInstruction + RAMPD];
                    nextInstruction += RAMPD;
                    PC += 2;
                    words += 2;
                    cycles += 2;
                }

                // CALL
                // 1001 010k kkkk 111k
                // kkkk kkkk kkkk kkkk
                else if ((currentInstruction & 0xFE0E) == 0x940E)
                {
                    nextInstruction = FLASH[PC + 1];
                    SRAM[SP--] = (byte)((PC + 2) & 0xFF);
                    SRAM[SP--] = (byte)(((PC + 2) >> 8) & 0xFF);

                    //TODO: see avr instruction set manual
                    //if (FLASH.Length > 0x20000)
                    //    SRAM[SP--] = (byte)((PC + 3 >> 16) & 0xFF);

                    PC = ((currentInstruction & 0x01F0) << 17) | ((currentInstruction & 0x1) << 16) | nextInstruction;
                    words += 2;
                    cycles += 4;
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

                // CBI
                // 1001 1000 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9800)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // SBI
                // 1001 1010 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9A00)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }

                // SBIC
                // 1001 1001 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9900)
                {
                    PC++;

                    cycles++;//1 = no skip, 2,3 skip next instr
                    isHalted = true;
                }

                // SBIS
                // 1001 1011 AAAA Abbb
                else if ((currentInstruction & 0xFF00) == 0x9B00)
                {
                    if (((IOR[((currentInstruction >> 3) & 0x1F)] & (1 << (currentInstruction & 0x7))) >> (currentInstruction & 0x7)) == 1)
                    {
                        if (Is16BitInstruction(FLASH[PC + 1]))
                        {
                            PC += 3;
                            cycles += 3;
                        }
                        else {
                            PC += 2;
                            cycles += 2;
                        }
                    }
                    else 
                    {
                        PC++;
                        cycles++;
                    }
                }

                // CBR
                // 1001 1000 AAAA Abbb
                //else if ((currentInstruction & 0xFF00) == 0x9800)
                //{
                //    PC++;
                //    
                //    cycles++;
                //    isHalted = true;
                //}

                // ADIW
                // 1001 0110 KKdd KKKK
                else if ((currentInstruction & 0xFF00) == 0x9600)
                {
                    int rd = (((currentInstruction >> 4) & 0x3) * 2) + 24;
                    ushort result = (ushort)(((GPR[rd + 1] << 8) | GPR[rd]) + (((currentInstruction >> 2) & 0x30) | (currentInstruction & 0xF)));
                    SREG_C = (~((result & 0x8000) >> 15) & ((GPR[rd + 1] & 0x80) >> 7)) == 1;
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x8000) >> 15) != 0;
                    SREG_V = (((result & 0x8000) >> 15) & ~((GPR[rd + 1] & 0x80) >> 7)) == 1;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[rd + 1] = (byte)((result >> 8) & 0xFF);
                    GPR[rd] = (byte)(result & 0xFF);
                    PC++;
                    cycles++;
                }

                // SBIW
                // 1001 0111 KKdd KKKK
                else if ((currentInstruction & 0xFF00) == 0x9700)
                {
                    int rd = (((currentInstruction >> 4) & 0x3) * 2) + 24;
                    ushort result = (ushort)(((GPR[rd + 1] << 8) | GPR[rd]) - (((currentInstruction >> 2) & 0x30) | (currentInstruction & 0xF)));
                    SREG_C = (((result & 0x8000) >> 15) & ~((GPR[rd + 1] & 0x80) >> 7)) == 1;
                    SREG_Z = result == 0;
                    SREG_N = ((result & 0x8000) >> 15) != 0;
                    SREG_V = (((result & 0x8000) >> 15) & ~((GPR[rd + 1] & 0x80) >> 7)) == 1;
                    SREG_S = SREG_N ^ SREG_V;
                    GPR[rd + 1] = (byte)((result >> 8) & 0xFF);
                    GPR[rd] = (byte)(result & 0xFF);
                    PC++;

                    cycles += 2;
                }

                // MUL
                // 1001 11rd dddd rrrr
                else if ((currentInstruction & 0xFC00) == 0x9C00)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }
                #endregion

                #region Instructions starts with 1010
                // LDS
                // 1010 0kkk dddd kkkk
                else if ((currentInstruction & 0xF800) == 0xA000)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // STS
                // 1010 1kkk dddd kkkk
                else if ((currentInstruction & 0xF800) == 0xA800)
                {
                    PC++;

                    cycles++;
                    isHalted = true;
                }
                #endregion

                #region Instructions starts with 1011
                // IN
                // 1011 0AAd dddd AAAA
                else if ((currentInstruction & 0xF800) == 0xB000)
                {
                    GPR[(currentInstruction >> 4) & 0x1F] = IOR[((currentInstruction >> 5) & 0x30) | (currentInstruction & 0xF)];
                    PC++;

                    cycles++;
                }

                // OUT
                // 1011 1AAr rrrr AAAA
                else if ((currentInstruction & 0xF800) == 0xB800)
                {
                    IOR[((currentInstruction >> 5) & 0x30) | (currentInstruction & 0xF)] = GPR[(currentInstruction >> 4) & 0x1F];
                    PC++;

                    cycles++;
                }
                #endregion

                #region Instructions starts with 1100
                // RJMP
                // 1100 kkkk kkkk kkkk
                else if ((currentInstruction & 0xF000) == 0xC000)
                {
                    PC += (((currentInstruction << 20) >> 20) + 1);

                    cycles += 2;
                }
                #endregion

                #region Instructions starts with 1101
                // RCALL
                // 1101 kkkk kkkk kkkk
                else if ((currentInstruction & 0xF000) == 0xD000)
                {
                    PC++;

                    cycles += 3;
                    isHalted = true;
                }
                #endregion

                #region Instructions starts with 1110
                // LDI
                // 1110 KKKK dddd KKKK
                else if ((currentInstruction & 0xF000) == 0xE000)
                {
                    GPR[((currentInstruction >> 4) & 0xF) + 0x10] = (byte)(((currentInstruction >> 4) & 0xF0) | (currentInstruction & 0xF));
                    PC++;
                    cycles++;
                }
                #endregion

                #region Instructions starts with 1111
                // BREQ
                // 1111 00kk kkkk k001
                else if ((currentInstruction & 0xFC07) == 0xF001)
                {
                    if (SREG_Z)
                    {
                        PC += (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                        cycles += 2;
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }
                }

                // BRCS
                // 1111 00kk kkkk k000
                else if ((currentInstruction & 0xFC07) == 0xF000)
                {
                    if (SREG_C)
                    {
                        PC += (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                        cycles += 2;
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }
                }

                // BRCC
                // 1111 01kk kkkk k000
                else if ((currentInstruction & 0xFC07) == 0xF400)
                {
                    if (!SREG_C)
                    {
                        PC += (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                        cycles += 2;
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }
                }

                // BRGE
                // 1111 01kk kkkk k100
                else if ((currentInstruction & 0xFC07) == 0xF404)
                {
                    if (!SREG_S)
                    {
                        PC += (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                        cycles += 2;
                    }
                    else
                    {
                        PC++;
                        cycles++; 
                    }
                }

                // BRHC
                // 1111 01kk kkkk k101
                else if ((currentInstruction & 0xFC07) == 0xF405)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRHS
                // 1111 00kk kkkk k101
                else if ((currentInstruction & 0xFC07) == 0xF005)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRID
                // 1111 01kk kkkk k111
                else if ((currentInstruction & 0xFC07) == 0xF407)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRIE
                // 1111 00kk kkkk k111
                else if ((currentInstruction & 0xFC07) == 0xF007)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRLO
                // 1111 00kk kkkk k000
                //else if ((currentInstruction & 0xFC07) == 0xF000)
                //{
                //    PC++;
                //    
                //    cycles++; // 2 if cond is true
                //    isHalted = true;
                //}

                // BRLT
                // 1111 00kk kkkk k100
                else if ((currentInstruction & 0xFC07) == 0xF004)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRMI
                // 1111 00kk kkkk k010
                else if ((currentInstruction & 0xFC07) == 0xF002)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRNE
                // 1111 01kk kkkk k001
                else if ((currentInstruction & 0xFC07) == 0xF401)
                {
                    if (!SREG_Z)
                    {
                        PC += (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                        cycles += 2;
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }

                }

                // BRTC
                // 1111 01kk kkkk k110
                else if ((currentInstruction & 0xFC07) == 0xF406)
                {
                    if (!SREG_T)
                    {
                        PC += (((currentInstruction & 0x03F8) << 22) >> 25) + 1;
                        cycles += 2;
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }
                }

                // BRPL
                // 1111 01kk kkkk k010
                else if ((currentInstruction & 0xFC07) == 0xF402)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRSH
                // 1111 01kk kkkk k000
                //else if ((currentInstruction & 0xFC07) == 0xF400)
                //{
                //    PC++;
                //    
                //    cycles++; // 2 if cond is true
                //    isHalted = true;
                //}

                // BRTS
                // 1111 00kk kkkk k110
                else if ((currentInstruction & 0xFC07) == 0xF006)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRVC
                // 1111 01kk kkkk k011
                else if ((currentInstruction & 0xFC07) == 0xF403)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRVS
                // 1111 00kk kkkk k011
                else if ((currentInstruction & 0xFC07) == 0xF003)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BLD
                // 1111 100d dddd 0bbb
                else if ((currentInstruction & 0xFE08) == 0xF800)
                {
                    PC++;
                    cycles++;
                    isHalted = true;
                }

                // BST
                // 1111 101d dddd 0bbb
                else if ((currentInstruction & 0xFE08) == 0xFA00)
                {
                    SREG_T = ((GPR[(currentInstruction >> 4) & 0x1F] >> (currentInstruction & 0x7)) & 0x1) == 1;
                    PC++;
                    cycles++;
                }

                // SBRC
                // 1111 110r rrrr 0bbb
                else if ((currentInstruction & 0xFE08) == 0xFC00)
                {
                    if (((GPR[(currentInstruction >> 4) & 0x1F] >> (currentInstruction & 0x7)) & 0x1) == 0)
                    {
                        if (Is16BitInstruction(FLASH[PC + 1]))
                        {
                            PC += 3;
                            cycles += 3;
                        }
                        else
                        {
                            PC += 2;
                            cycles += 2;
                        }
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }
                }

                // SBRS
                // 1111 111r rrrr 0bbb
                else if ((currentInstruction & 0xFE08) == 0xFE00)
                {
                    if (((GPR[(currentInstruction >> 4) & 0x1F] >> (currentInstruction & 0x7)) & 0x1) == 1)
                    {
                        if (Is16BitInstruction(FLASH[PC + 1]))
                        {
                            PC += 3;
                            cycles += 3;
                        }
                        else
                        {
                            PC += 2;
                            cycles += 2;
                        }
                    }
                    else
                    {
                        PC++;
                        cycles++;
                    }
                }

                // BRBS
                // 1111 00kk kkkk ksss
                else if ((currentInstruction & 0xFC00) == 0xF000)
                {
                    PC++;
                    cycles++; // 2 if cond is true
                    isHalted = true;
                }

                // BRBC
                // 1111 01kk kkkk ksss
                else if ((currentInstruction & 0xFC00) == 0xF400)
                {
                    PC++;

                    cycles++; // 2 if cond is true
                    isHalted = true;
                }
                #endregion

                #region Instructions starts with 10q0
                // LDD Y+q
                // 10q0 qq0d dddd 1qqq
                else if ((currentInstruction & 0xD208) == 0x8008)
                {
                    int q = ((currentInstruction & 0x2000) >> 8) | ((currentInstruction & 0xC00) >> 7) | (currentInstruction & 0x7); //TOTO check: is it correct
                    GPR[(currentInstruction >> 4) & 0x1F] = SRAM[Y + q];
                    PC++;
                    cycles += 3;
                }

                // LDD Z+q
                // 10q0 qq0d dddd 0qqq
                else if ((currentInstruction & 0xD208) == 0x8000)
                {
                    int q = ((currentInstruction & 0x2000) >> 8) | ((currentInstruction & 0xC00) >> 7) | (currentInstruction & 0x7); //TOTO check is it correct
                    GPR[(currentInstruction >> 4) & 0x1F] = SRAM[Z + q];
                    PC++;
                    cycles += 2; 
                }

                // STD Y+q
                // 10q0 qq1r rrrr 1qqq
                else if ((currentInstruction & 0xD208) == 0x8208)
                {
                    int q = ((currentInstruction & 0x2000) >> 8) | ((currentInstruction & 0xC00) >> 7) | (currentInstruction & 0x7); //TOTO check: is it correct
                    SRAM[Y + q] = GPR[(currentInstruction >> 4) & 0x1F];
                    PC++;
                    cycles += 2;
                }

                // STD Z+q
                // 10q0 qq1r rrrr 0qqq
                else if ((currentInstruction & 0xD208) == 0x8200)
                {
                    PC++;

                    cycles += 2;
                    isHalted = true;
                }
                #endregion

                #region Interrupts
                if (SREG_I)
                {
                    if ((SRAM[0x35] & 1) == 1)
                    {
                        SREG_I = false; //TODO check if that this is cleared by software?
                        SRAM[SP--] = (byte)((PC) & 0xFF);
                        SRAM[SP--] = (byte)(((PC) >> 8) & 0xFF);

                        //if (FLASH.Length > 0x20000)
                        //    SRAM[SP--] = (byte)((PC >> 16) & 0xFF); //Maybe 0x3F
                        AVR.SRAM[0x35] &= 0xFE; // Clear TIF0's 0bit
                        PC = 0x20;
                    }
                }
                #endregion

            }
        }

        bool Is16BitInstruction(int instruction) {

            if ((currentInstruction & 0xFE0E) == 0x940C)
                return true;
            else if ((currentInstruction & 0xFE0E) == 0x940E)
                return true;
            else if ((currentInstruction & 0xFE0F) == 0x9200)
                return true;
            else if ((currentInstruction & 0xFE0F) == 0x9000)
                return true;
            
            return false;
        }
    }
}