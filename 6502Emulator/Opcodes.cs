namespace _6502Emulator
{
    public static class Opcodes
    {
        public const byte ADC_IMMEDIATE = 0x69;
        public const byte ADC_ZEROPAGE = 0x65;
        public const byte ADC_ZEROPAGEX = 0x75;
        public const byte ADC_ABSOLUTE = 0x6D;
        public const byte ADC_ABSOLUTEX = 0x7D;
        public const byte ADC_ABSOLUTEY = 0x79;
        public const byte ADC_INDIRECTX = 0x61;
        public const byte ADC_INDIRECTY = 0x71;
        
        public const byte AND_IMMEDIATE = 0x29;
        public const byte AND_ZEROPAGE = 0x25;
        public const byte AND_ZEROPAGEX = 0x35;
        public const byte AND_ABSOLUTE = 0x2D;
        public const byte AND_ABSOLUTEX = 0x3D;
        public const byte AND_ABSOLUTEY = 0x39;
        public const byte AND_INDIRECTX = 0x21;
        public const byte AND_INDIRECTY = 0x31;
        
        public const byte ASL_IMMEDIATE = 0x0A;
        public const byte ASL_ZEROPAGE = 0x06;
        public const byte ASL_ZEROPAGEX = 0x16;
        public const byte ASL_ABSOLUTE = 0x0E;
        public const byte ASL_ABSOLUTEX = 0x1E;
        
        public const byte BCC_RELATIVE = 0x90;

        public const byte BCS_RELATIVE = 0xB0;

        public const byte BEQ_RELATiVE = 0xF0;

        public const byte BIT_ZEROPAGE = 0x24;
        public const byte BIT_ABSOULTE = 0x2C;
        
        public const byte BMI_RELATIVE = 0x30;
        
        public const byte BNE_RELATIVE = 0xD0;
        
        public const byte BPL_RELATIVE = 0x10;
        
        public const byte BRK_IMPLIED = 0x00;
        
        public const byte BVC_RELATIVE = 0x50;
        
        public const byte BVS_RELATIVE = 0x70;
        
        public const byte CLC_IMPLIED = 0x18;
        
        public const byte CLD_IMPLIED = 0xD8;
        
        public const byte CLI_IMPLIED = 0x58;
        
        public const byte CLV_IMPLIED = 0xB8;
        
        public const byte CMP_IMMEDIATE = 0xc9;
        public const byte CMP_ZEROPAGE = 0xc5;
        public const byte CMP_ZEROPAGEX = 0xd5;
        public const byte CMP_ABSOLUTE = 0xcd;
        public const byte CMP_ABSOLUTEX = 0xdd;
        public const byte CMP_ABSOLUTEY = 0xd9;
        public const byte CMP_INDIRECTX = 0xc1;
        public const byte CMP_INDIRECTY = 0xd1;
        
        public const byte CPX_IMMEDIATE = 0xe0;
        public const byte CPX_ZEROPAGE = 0xe4;
        public const byte CPX_ABSOLUTE = 0xec;
        
        public const byte CPY_IMMEDIATE = 0xc0;
        public const byte CPY_ZEROPAGE = 0xc4;
        public const byte CPY_ABSOLUTE = 0xcc;
        
        public const byte DEC_ZEROPAGE = 0xc6;
        public const byte DEC_ZEROPAGEX = 0xd6;
        public const byte DEC_ABSOLUTE = 0xce;
        public const byte DEC_ABSOLUTEX = 0xde;
        
        public const byte DEX_IMPLIED = 0xCA;
        
        public const byte DEY_IMPLIED = 0x88;
        
        public const byte EOR_IMMEDIATE = 0x49;
        public const byte EOR_ZEROPAGE = 0x45;
        public const byte EOR_ZEROPAGEX = 0x55;
        public const byte EOR_ABSOLUTE = 0x4D;
        public const byte EOR_ABSOLUTEX = 0x5D;
        public const byte EOR_ABSOLUTEY = 0x59;
        public const byte EOR_INDIRECTX = 0x41;
        public const byte EOR_INDIRECTY = 0x51;
        
        public const byte INC_ZEROPAGE = 0xE6;
        public const byte INC_ZEROPAGEX = 0xF6;
        public const byte INC_ABSOLUTE = 0xEE;
        public const byte INC_ABSOLUTEX = 0xFE;
        
        public const byte INX_IMPLIED = 0xE8;
        
        public const byte INY_IMPLIED = 0xC8;
        
        public const byte JMP_ABSOLUTE = 0x4C;
        public const byte JMP_INDIRECT = 0x6C;
        
        public const byte JSR_ABSOLUTE = 0x20;
        
        public const byte LDA_IMMEDIATE = 0xA9;
        public const byte LDA_ZEROPAGE = 0xA5;
        public const byte LDA_ZEROPAGEX = 0xB5;
        public const byte LDA_ABSOLUTE = 0xAD;
        public const byte LDA_ABSOLUTEX = 0xBD;
        public const byte LDA_ABSOLUTEY = 0xB9;
        public const byte LDA_INDIRECTX = 0xA1;
        public const byte LDA_INDIRECTY = 0xB1;
        
        public const byte LDX_IMMEDIATE = 0xA2;
        public const byte LDX_ZEROPAGE = 0xA6;
        public const byte LDX_ZEROPAGEY = 0xB6;
        public const byte LDX_ABSOLUTE = 0xAE;
        public const byte LDX_ABSOLUTEY = 0xBE;
        
        public const byte LDY_IMMEDIATE = 0xA0;
        public const byte LDY_ZEROPAGE = 0xA4;
        public const byte LDY_ZEROPAGEX = 0xB4;
        public const byte LDY_ABSOLUTE = 0xAC;
        public const byte LDY_ABSOLUTEX = 0xBC;
        
        public const byte LSR_ACCUMULATOR = 0x4A;
        public const byte LSR_ZEROPAGE = 0x46;
        public const byte LSR_ZEROPAGEX = 0x56;
        public const byte LSR_ABSOLUTE = 0x4E;
        public const byte LSR_ABSOLUTEX = 0x5E;
        
        public const byte NOP_IMPLIED = 0xEA;
        
        public const byte ORA_IMMEDIATE = 0x09;
        public const byte ORA_ZEROPAGE = 0x05;
        public const byte ORA_ZEROPAGEX = 0x15;
        public const byte ORA_ABSOLUTE = 0x0D;
        public const byte ORA_ABSOLUTEX = 0x1D;
        public const byte ORA_ABSOLUTEY = 0x19;
        public const byte ORA_INDIRECTX = 0x01;
        public const byte ORA_INDIRECTY = 0x11;
        
        public const byte PHA_IMPLIED = 0x48;
        
        public const byte PHP_IMPLIED = 0x08;
        
        public const byte PLA_IMPLIED = 0x68;
        
        public const byte PLP_IMPLIED = 0x28;
        
        public const byte ROL_ACCUMULATOR = 0x2A;
        public const byte ROL_ZEROPAGE = 0x26;
        public const byte ROL_ZEROPAGEX = 0x36;
        public const byte ROL_ABSOLUTE = 0x2E;
        public const byte ROL_ABSOLUTEX = 0x3E;
        
        public const byte ROR_ACCUMULATOR = 0x6A;
        public const byte R0R_ZEROPAGE = 0x66;
        public const byte ROR_ZEROPAGEX = 0x76;
        public const byte ROR_ABSOLUTE = 0x6E;
        public const byte ROR_ABSOLUTEX = 0x7E;
        
        public const byte RTI_IMPLIED = 0x40;
        
        public const byte RTS_IMPLIED = 0x60;
        
        public const byte SBC_IMMEDIATE = 0xE9;
        public const byte SBC_ZEROPAGE = 0xE5;
        public const byte SBC_ZEROPAGEX = 0xF5;
        public const byte SBC_ABSOLUTE = 0xED;
        public const byte SBC_ABSOLUTEX = 0xFD;
        public const byte SBC_ABSOLUTEY = 0xF9;
        public const byte SBC_INDIRECTX = 0xE1;
        public const byte SBC_INDIRECTY = 0xF1;

        public const byte SEC_IMPLIED = 0x38;
        
        public const byte SED_IMPLIED = 0xF8;

        public const byte SEI_IMPLIED = 0x78;

        public const byte STA_ZEROPAGE = 0x85;
        public const byte STA_ZEROPAGEX = 0x95;
        public const byte STA_ABSOLUTE = 0x8D;
        public const byte STA_ABSOLUTEX = 0x9D;
        public const byte STA_ABSOLUTEY = 0x99;
        public const byte STA_INDIRECTX = 0x81;
        public const byte STA_INDIRECTY = 0x91;
        
        public const byte STX_ZEROPAGE = 0x86;
        public const byte STX_ZEROPAGEY = 0x96;
        public const byte STX_ABSOLUTE = 0x8E;
        
        public const byte STY_ZEROPAGE = 0x84;
        public const byte STY_ZEROPAGEX = 0x94;
        public const byte STY_ABSOLUTE = 0x8C;
        
        public const byte TAX_IMPLIED = 0xAA;
        
        public const byte TAY_IMPLIED = 0xA8;
        
        public const byte TSX_IMPLIED = 0xBA;
        
        public const byte TXA_IMPLIED = 0x8A;
        
        public const byte TXS_IMPLIED = 0x9A;
        
        public const byte TYA_ABSOLUTE = 0x98;
        
        //byte lengths for operations
        public static int getOperationByteLength(byte opcode)
        {
            switch (opcode)
            {
                case ADC_IMMEDIATE:
                    return 2;
                case ADC_ZEROPAGE:
                    return 2;
                case ADC_ZEROPAGEX:
                    return 2;
                case ADC_ABSOLUTE:
                    return 3;
                case ADC_ABSOLUTEX:
                    return 3;
                case ADC_ABSOLUTEY:
                    return 3;
                case ADC_INDIRECTX:
                    return 2;
                case ADC_INDIRECTY:
                    return 2;
                
                case AND_IMMEDIATE:
                    return 2;
                case AND_ZEROPAGE:
                    return 2;
                case AND_ZEROPAGEX:
                    return 2;
                case AND_ABSOLUTE:
                    return 3;
                case AND_ABSOLUTEX:
                    return 3;
                case AND_ABSOLUTEY:
                    return 3;
                case AND_INDIRECTX:
                    return 2;
                case AND_INDIRECTY:
                    return 2;
                
                case ASL_IMMEDIATE:
                    return 1;
                case ASL_ZEROPAGE:
                    return 2;
                case ASL_ZEROPAGEX:
                    return 2;
                case ASL_ABSOLUTE:
                    return 3;
                case ASL_ABSOLUTEX:
                    return 3;
                
                case BCC_RELATIVE:
                    return 2;

                case BCS_RELATIVE:
                    return 2;

                case BEQ_RELATiVE:
                    return 2;

                case BIT_ZEROPAGE:
                    return 2;
                case BIT_ABSOULTE:
                    return 3;
                
                case BMI_RELATIVE:
                    return 2;
                
                case BNE_RELATIVE:
                    return 2;
                
                case BPL_RELATIVE:
                    return 2;
                
                case BRK_IMPLIED:
                    return 1;
                
                case BVC_RELATIVE:
                    return 2;
                
                case BVS_RELATIVE:
                    return 2;
                
                case CLC_IMPLIED:
                    return 1;
                
                case CLD_IMPLIED:
                    return 1;
                
                case CLI_IMPLIED:
                    return 1;
                
                case CLV_IMPLIED:
                    return 1;
                
                case CMP_IMMEDIATE:
                    return 2;
                case CMP_ZEROPAGE:
                    return 3;
                case CMP_ZEROPAGEX:
                    return 3;
                case CMP_ABSOLUTE:
                    return 3;
                case CMP_ABSOLUTEX:
                    return 2;
                case CMP_ABSOLUTEY:
                    return 2;
                case CMP_INDIRECTX:
                    return 2;
                case CMP_INDIRECTY:
                    return 2;
                
                case CPX_IMMEDIATE:
                    return 2;
                case CPX_ZEROPAGE:
                    return 3;
                case CPX_ABSOLUTE:
                    return 2;
                
                case CPY_IMMEDIATE:
                    return 2;
                case CPY_ZEROPAGE:
                    return 3;
                case CPY_ABSOLUTE:
                    return 2;
                
                case DEC_ZEROPAGE:
                    return 3;
                case DEC_ZEROPAGEX:
                    return 3;
                case DEC_ABSOLUTE:
                    return 2;
                case DEC_ABSOLUTEX:
                    return 2;
                
                case DEX_IMPLIED:
                    return 1;
                
                case DEY_IMPLIED:
                    return 1;
                
                case EOR_IMMEDIATE:
                    return 2;
                case EOR_ZEROPAGE:
                    return 3;
                case EOR_ZEROPAGEX:
                    return 3;
                case EOR_ABSOLUTE:
                    return 3;
                case EOR_ABSOLUTEX:
                    return 2;
                case EOR_ABSOLUTEY:
                    return 2;
                case EOR_INDIRECTX:
                    return 2;
                case EOR_INDIRECTY:
                    return 2;
                
                case INC_ZEROPAGE:
                    return 3;
                case INC_ZEROPAGEX:
                    return 3;
                case INC_ABSOLUTE:
                    return 2;
                case INC_ABSOLUTEX:
                    return 2;
                
                case INX_IMPLIED:
                    return 1;
                
                case INY_IMPLIED:
                    return 1;
                
                case JMP_ABSOLUTE:
                    return 3;
                case JMP_INDIRECT:
                    return 3;
                
                case JSR_ABSOLUTE:
                    return 3;
                
                case LDA_IMMEDIATE:
                    return 2;
                case LDA_ZEROPAGE:
                    return 2;
                case LDA_ZEROPAGEX:
                    return 2;
                case LDA_ABSOLUTE:
                    return 3;
                case LDA_ABSOLUTEX:
                    return 3;
                case LDA_ABSOLUTEY:
                    return 3;
                case LDA_INDIRECTX:
                    return 2;
                case LDA_INDIRECTY:
                    return 2;
                
                case LDX_IMMEDIATE:
                    return 2;
                case LDX_ZEROPAGE:
                    return 3;
                case LDX_ZEROPAGEY:
                    return 3;
                case LDX_ABSOLUTE:
                    return 2;
                case LDX_ABSOLUTEY:
                    return 2;
                
                case LDY_IMMEDIATE:
                    return 2;
                case LDY_ZEROPAGE:
                    return 3;
                case LDY_ZEROPAGEX:
                    return 3;
                case LDY_ABSOLUTE:
                    return 2;
                case LDY_ABSOLUTEX:
                    return 2;
                
                case LSR_ACCUMULATOR:
                    return 1;
                case LSR_ZEROPAGE:
                    return 3;
                case LSR_ZEROPAGEX:
                    return 3;
                case LSR_ABSOLUTE:
                    return 2;
                case LSR_ABSOLUTEX:
                    return 2;
                
                case NOP_IMPLIED:
                    return 1;
                
                case ORA_IMMEDIATE:
                    return 2;
                case ORA_ZEROPAGE:
                    return 3;
                case ORA_ZEROPAGEX:
                    return 3;
                case ORA_ABSOLUTE:
                    return 3;
                case ORA_ABSOLUTEX:
                    return 2;
                case ORA_ABSOLUTEY:
                    return 2;
                case ORA_INDIRECTX:
                    return 2;
                case ORA_INDIRECTY:
                    return 2;
                
                case PHA_IMPLIED:
                    return 1;
                
                case PHP_IMPLIED:
                    return 1;
                
                case PLA_IMPLIED:
                    return 1;
                
                case PLP_IMPLIED:
                    return 1;
                
                case ROL_ACCUMULATOR:
                    return 1;
                case ROL_ZEROPAGE:
                    return 3;
                case ROL_ZEROPAGEX:
                    return 3;
                case ROL_ABSOLUTE:
                    return 2;
                case ROL_ABSOLUTEX:
                    return 2;
                
                case ROR_ACCUMULATOR:
                    return 1;
                case R0R_ZEROPAGE:
                    return 3;
                case ROR_ZEROPAGEX:
                    return 3;
                case ROR_ABSOLUTE:
                    return 2;
                case ROR_ABSOLUTEX:
                    return 2;
                
                case RTI_IMPLIED:
                    return 1;
                
                case RTS_IMPLIED:
                    return 1;
                
                case SBC_IMMEDIATE:
                    return 2;
                case SBC_ZEROPAGE:
                    return 3;
                case SBC_ZEROPAGEX:
                    return 3;
                case SBC_ABSOLUTE:
                    return 3;
                case SBC_ABSOLUTEX:
                    return 2;
                case SBC_ABSOLUTEY:
                    return 2;
                case SBC_INDIRECTX:
                    return 2;
                case SBC_INDIRECTY:
                    return 2;

                case SEC_IMPLIED:
                    return 1;
                
                case SED_IMPLIED:
                    return 1;

                case SEI_IMPLIED:
                    return 1;

                case STA_ZEROPAGE:
                    return 3;
                case STA_ZEROPAGEX:
                    return 3;
                case STA_ABSOLUTE:
                    return 3;
                case STA_ABSOLUTEX:
                    return 2;
                case STA_ABSOLUTEY:
                    return 2;
                case STA_INDIRECTX:
                    return 2;
                case STA_INDIRECTY:
                    return 2;
                
                case STX_ZEROPAGE:
                    return 3;
                case STX_ZEROPAGEY:
                    return 2;
                case STX_ABSOLUTE:
                    return 2;
                
                case STY_ZEROPAGE:
                    return 3;
                case STY_ZEROPAGEX:
                    return 2;
                case STY_ABSOLUTE:
                    return 2;
                
                case TAX_IMPLIED:
                    return 1;
                
                case TAY_IMPLIED:
                    return 1;
                
                case TSX_IMPLIED:
                    return 1;
                
                case TXA_IMPLIED:
                    return 1;
                
                case TXS_IMPLIED:
                    return 1;
                
                case TYA_ABSOLUTE:
                    return 1;
                
            }

            return 0;
        }
    }
}