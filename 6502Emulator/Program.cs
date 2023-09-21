using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _6502Emulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Disassembler disassembler = new Disassembler("LDATestNEW");
            (List<List<byte>>, int) disassembledOperations, totalLength = disassembler.Disassemble();
            CPU cpu = new CPU(65536); //2^16 bytes of ram
            cpu.RunCPU(disassembledOperations);
            
            
            
        }
    }
}