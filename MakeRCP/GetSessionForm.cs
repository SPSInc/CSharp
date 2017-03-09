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
    
    public partial class GetSessionForm : Form
    {
        public delegate void FormSendDataHandler(string strRcp);
        public event FormSendDataHandler FormSendEvent;
        
        public GetSessionForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            this.FormSendEvent(makeGetSessionRCP());
        }
        private string makeGetSessionRCP()
        {
            int i = 0;
            byte[] RCP = new byte[8];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x2E; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x00; // Length(LSB)
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = CalculatorCRC.crcAppend(RCP, (ushort)i);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            return CalculatorCRC.ByteArrayToString(RCP);
        }
    }
}
