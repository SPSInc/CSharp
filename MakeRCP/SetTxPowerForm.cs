using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeRCP
{
    public partial class SetTxPowerForm : Form
    {
        public delegate void FormSendDataHandler(string strRcp);
        public event FormSendDataHandler FormSendEvent;
        
        public SetTxPowerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            this.FormSendEvent(makeSetTXPowerRCP());
        }
        private string makeSetTXPowerRCP()
        {
            if (cbPower.Text.Equals(""))
            {
                return "There is not enough information";
            }

            int i = 0;
            int pow;
            byte[] RCP = new byte[10];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x16; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x02; // Length(LSB)
            int point = cbPower.Text.IndexOf(".");
            if (point == -1)
                pow = Convert.ToInt32(cbPower.Text) * 10;
            else
            {
                pow = Convert.ToInt32(cbPower.Text.Substring(0, point));
                pow = pow * 10 + Convert.ToInt32(cbPower.Text.Substring(point + 1));
            }

            RCP[i++] = (byte)(pow >> 8);
            RCP[i++] = (byte)(pow);
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = CalculatorCRC.crcAppend(RCP, (ushort)i);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;

            return CalculatorCRC.ByteArrayToString(RCP);
        }
    }
}
