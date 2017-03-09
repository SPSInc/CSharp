using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRCP
{
    public class CalculatorCRC
    {
        private static ushort crcPolynomial(byte b, ushort acc)
        {
            acc = (ushort)((byte)(acc >> 8) | (ushort)(acc << 8));
            acc ^= b;
            acc ^= (ushort)((byte)(acc & 0xff) >> 4);
            acc ^= (ushort)((acc << 8) << 4);
            acc ^= (ushort)(((acc & 0xff) << 4) << 1);
            return acc;
        }
        private static ushort crcSum(byte[] msg, ushort leghth, ushort crc)
        {
            ushort i;
            for (i = 1; i < leghth; i++)
            {
                crc = crcPolynomial(msg[i], crc);
            }
            return crc;
        }
        public static ushort crcAppend(byte[] message, ushort length)
        {
            ushort crc;
            crc = crcSum(message, length, 0xFFFF);
            return crc;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString().ToUpper();
        }
    }
}
