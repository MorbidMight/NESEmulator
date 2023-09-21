using System;
using System.Collections.Generic;

namespace _6502Emulator
{
    public class CPU
    {
        private int cycles;
        private ushort programCounter;
        private byte register_a;
        private byte register_x;
        private byte register_y;
        private byte register_status;
        private int numBytesOfMemory;
        private byte[] memory;

        public enum addressingTypes {Implied, Accumulator, Immediate, 
                                   Absolute, XIndexedAbsolute, YIndexedAbsolute, 
                                   AbsoluteIndirect, ZeroPage, XIndexedZeroPage, 
                                   YIndexedZeroPage, XIndexedZeroPageIndirect, ZeroPageIndirectYIndexed, Relative}
        
        private void ResetCPU()
        {
            cycles = 100;
            memory = new byte[numBytesOfMemory];
            register_a = 0;
            register_x = 0;
            register_y = 0;
            register_status = 0;
        }

        public CPU(int numBytesOfMemory)
        {
            this.numBytesOfMemory = numBytesOfMemory;
            memory = new byte[numBytesOfMemory];
            ResetCPU();    
        }

        public void RunCPU(List<List<byte>> operations, int length)
        {
            int cutoff = 100;
            int numBytesInProgram 
            while (programCounter < operations.)
            {
                byte opcode = operations[programCounter][0];
                List<byte> otherBytes = operations[programCounter];
                
                HandleOperation(opcode, otherBytes);
                programCounter++;
                cutoff--;
            }
        }

        private void HandleOperation(byte opcode, List<byte> otherBytes)
        {
            //declare variables addressing might need
            ushort effectiveAddress;
            switch (opcode)
            {
                case Opcodes.LDA_IMMEDIATE:
                    register_a = otherBytes[1];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_ABSOLUTE:
                    effectiveAddress = EffectiveAddressFromAddressingType((int)addressingTypes.Absolute, otherBytes);
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_ABSOLUTEX:
                    effectiveAddress = EffectiveAddressFromAddressingType((int)addressingTypes.XIndexedAbsolute, otherBytes);
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_ABSOLUTEY:
                    effectiveAddress = EffectiveAddressFromAddressingType((int)addressingTypes.YIndexedAbsolute, otherBytes);;
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_ZEROPAGE:
                    effectiveAddress = EffectiveAddressFromAddressingType((int)addressingTypes.ZeroPage, otherBytes);
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_ZEROPAGEX:
                    effectiveAddress = EffectiveAddressFromAddressingType((int)addressingTypes.XIndexedZeroPage, otherBytes);;
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_INDIRECTX:
                    effectiveAddress = EffectiveAddressFromAddressingType((int) addressingTypes.XIndexedZeroPageIndirect, otherBytes);
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
                case Opcodes.LDA_INDIRECTY:
                    //stuff with carry bit
                    effectiveAddress = EffectiveAddressFromAddressingType((int) addressingTypes.ZeroPageIndirectYIndexed, otherBytes);
                    register_a = memory[effectiveAddress];
                    cycles -= Opcodes.getOperationByteLength(otherBytes[0]);
                    
                    if ((register_a & (1 << 7)) != 0) {SetNegativeFlag(true); }
                    else {SetNegativeFlag(false); }
                    
                    if (register_a == 0) {SetZeroFlag(true);}
                    else {SetZeroFlag(false);}
                    break;
            }
        }
        
        //will return -1 if addressing mode is negative 1
        public ushort EffectiveAddressFromAddressingType(int addressingMode, List<byte> bytes)
        {
            switch (addressingMode)
            {
                case (int)addressingTypes.Absolute:
                {
                    ushort effectiveAddress = BitConverter.ToUInt16(new byte[] { bytes[2], bytes[1] }, 0);
                    return effectiveAddress;
                }
                case (int)addressingTypes.XIndexedAbsolute:
                {
                    ushort effectiveAddress = (byte)(BitConverter.ToUInt16(new[] { bytes[2], bytes[1] }, 0) + register_x);
                    return effectiveAddress;
                }
                case (int)addressingTypes.YIndexedAbsolute:
                {
                    ushort effectiveAddress = (byte)(BitConverter.ToUInt16(new[] { bytes[2], bytes[1] }, 0) + register_y);
                    return effectiveAddress;
                }
                case (int)addressingTypes.ZeroPage:
                {
                    ushort effectiveAddress = BitConverter.ToUInt16(new[] { bytes[1], (byte)0 }, 0);
                    return effectiveAddress;
                }
                case (int)addressingTypes.XIndexedZeroPage:
                {
                    ushort effectiveAddress = (ushort)(bytes[1] + register_x);
                    return effectiveAddress;
                }
                case (int)addressingTypes.YIndexedZeroPage:
                {
                    ushort effectiveAddress = (ushort)(bytes[1] + register_y);
                    return effectiveAddress;
                }
                //returns program counter + offset
                case (int)addressingTypes.Relative:
                {
                    ushort effectiveAddress = unchecked((ushort)((short)programCounter + bytes[1]));
                    return effectiveAddress;
                }
                case (int)addressingTypes.AbsoluteIndirect:
                {
                    ushort effectiveAddress = BitConverter.ToUInt16(new[] { bytes[2], bytes[1] }, 0);
                    effectiveAddress =
                        BitConverter.ToUInt16(new[] { memory[effectiveAddress], memory[effectiveAddress + 1] }, 0);
                    return effectiveAddress;
                }
                case (int)addressingTypes.XIndexedZeroPageIndirect:
                {
                    byte indirectLowOrder = (byte)(memory[bytes[1]] + register_x);
                    byte indirectHighOrder = memory[bytes[1] + 1];
                    ushort effectiveAddress = BitConverter.ToUInt16(new[] { indirectHighOrder, indirectLowOrder }, 0);
                    return effectiveAddress;
                }
                case (int)addressingTypes.ZeroPageIndirectYIndexed:
                {
                    bool carryBit = false;
                    byte indirectLowOrder = (byte) (memory[bytes[1]] + register_y);
                    try
                    {
                        indirectLowOrder = (byte) checked(memory[bytes[1]] + register_y);
                    }
                    catch
                    {
                        carryBit = true;
                    }
                    byte indirectHighOrder = (byte) (memory[bytes[1] + 1] + (carryBit ? 1: 0));
                    ushort effectiveAddress = BitConverter.ToUInt16(new [] { indirectHighOrder, indirectLowOrder}, 0);
                    return effectiveAddress;
                }
            }

            return 0;
        }

        private void SetNegativeFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | (1 << 7));
            }
            else
            {
                register_status = (byte) (register_status & ~(1 << 7));
            }
        }
        private void SetOverflowFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | (1 << 6));
            }
            else
            {
                register_status = (byte) (register_status & ~(1 << 6));
            }
        }
        private void SetBFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | (1 << 4));
            }
            else
            {
                register_status = (byte) (register_status & ~(1 << 4));
            }
        }
        private void SetDecimalFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | (1 << 3));
            }
            else
            {
                register_status = (byte) (register_status & ~(1 << 3));
            }
        }
        private void SetInterruptDisableFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | (1 << 2));
            }
            else
            {
                register_status = (byte) (register_status & ~(1 << 2));
            }
        }
        private void SetZeroFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | (1 << 1));
            }
            else
            {
                register_status = (byte) (register_status & ~(1 << 1));
            }
        }
        private void SetCarryFlag(bool bit)
        {
            if (bit)
            {
                register_status = (byte) (register_status | 1);
            }
            else
            {
                register_status = (byte) (register_status & ~1);
            }
        }
    }
}