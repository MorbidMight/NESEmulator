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

        public (List<List<byte>>, int) Disassemble()
        {
            int hexIn;
            List<List<byte>> hexArray = new List<List<byte>>();
            int totalLength = 0;
            for (int i = 0; (hexIn = _fs.ReadByte()) != -1; i++)
            {
                int length = Opcodes.getOperationByteLength((byte) hexIn);
                totalLength += length;
                hexArray.Add(new List<byte>());
                hexArray[i].Add((byte) hexIn);
                for (int x = 1; x < length; x++)
                { 
                    hexArray[i].Add((byte)_fs.ReadByte());
                } 
            }
            
            return (hexArray, totalLength);
        }
    }
}