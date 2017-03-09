using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRCP
{
    class CalculatorCRC
    {
        private ushort crcPolynomial(byte b, ushort acc)
        {
            acc = (ushort)((byte)(acc >> 8) | (ushort)(acc << 8));
            acc ^= b;
            acc ^= (ushort)((byte)(acc & 0xff) >> 4);
            acc ^= (ushort)((acc << 8) << 4);
            acc ^= (ushort)(((acc & 0xff) << 4) << 1);
            return acc;
        }
        private ushort crcSum(byte[] msg, ushort leghth, ushort crc)
        {
            ushort i;
            for (i = 1; i < leghth; i++)
            {
                crc = this.crcPolynomial(msg[i], crc);
            }
            return crc;
        }
        public ushort crcAppend(byte[] message, ushort length)
        {
            ushort crc;
            crc = this.crcSum(message, length, 0xFFFF);
            return crc;
        }
        public string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString().ToUpper();
        }
    }
}
