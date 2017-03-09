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
    public partial class PowerOnOffForm : Form
    {
        public delegate void FormSendDataHandler(string strRcp);
        public event FormSendDataHandler FormSendEvent;
        
        public PowerOnOffForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void PowerOnOffForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            this.FormSendEvent(makePowerOnOffRCP());
        }
        private string makePowerOnOffRCP()
        {
            int i = 0;
            byte[] RCP = new byte[14];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x01; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x06; // Length(LSB)

            if (cbOnOff.Checked)
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if (cbBeep.Checked)
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if (cbVibration.Checked)
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if (cbLED.Checked)
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if (cbIllumination.Checked)
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            RCP[i++] = 0xFF; // mode
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = CalculatorCRC.crcAppend(RCP, (ushort)i);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;

            return CalculatorCRC.ByteArrayToString(RCP);
            
            
            
        }
    }
}
