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
    public partial class GetInfoForm : Form
    {
        public delegate void FormSendDataHandler(string strRcp);
        public event FormSendDataHandler FormSendEvent;

        private System.Windows.Forms.RadioButton[] rbInformation;

        public GetInfoForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void GetInfoForm_Load(object sender, EventArgs e)
        {
            string[] strArray = new string[5];
            strArray[0] = "Model";
            strArray[1] = "S/N";
            strArray[2] = "Manufacturer";
            strArray[3] = "Frequency";
            strArray[4] = "Tag Type";

            rbInformation = new RadioButton[5];
            for (int i = 0; i < 5; i++)
            {
                rbInformation[i] = new RadioButton();
                rbInformation[i].Text = strArray[i];
                rbInformation[i].Location = new Point(180, 25 + i * 30);
                this.Controls.Add(rbInformation[i]);
                
            }
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            this.FormSendEvent(makeGetInformationRCP());
        }
        private string makeGetInformationRCP()
        {
            int i = 0;
            byte[] RCP = new byte[9];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x03; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x01; // Length(LSB)
            for (int j = 0; j < 5; j++)
            {
                if (rbInformation[j].Checked)
                {
                    RCP[i++] = (byte)j;
                    break;
                }
            }
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = CalculatorCRC.crcAppend(RCP, (ushort)i);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            return CalculatorCRC.ByteArrayToString(RCP);
        }
    }
}
