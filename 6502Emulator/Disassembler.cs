using System.Collections.Generic;
using System.IO;

namespace _6502Emulator
{
    public class Disassembler
    { 
        FileStream _fs;
        public Disassembler(string fileDirectory)
        {
            _fs = new FileStream(fileDirectory, FileMode.Open);
        }

        public (List<byte>, int) Disassemble()
        {
            int hexIn;
            List<byte> hexArray = new List<byte>();
            int totalLength = 0;
            for (int i = 0; (hexIn = _fs.ReadByte()) != -1; i++)
            {
                hexArray.Add((byte) hexIn);
                totalLength += 1;
            }
            
            return (hexArray, totalLength);
        }
    }
}