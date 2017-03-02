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
    public partial class MainForm : Form
    {
        StoreRCP storeRCP;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Device_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            storeRCP = new StoreRCP();

            cbDevice.SelectedIndex = 0;
            cbCommand.SelectedIndex = 0;
            setParametersPowerOnOff();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            storeRCP.setDeviceIndex(cbDevice.SelectedIndex);
            storeRCP.setCommandIndex(cbCommand.SelectedIndex);
            setParamtersUI(cbDevice.SelectedIndex, cbCommand.SelectedIndex);
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            switch (storeRCP.getCommandIndex())
            {
                case 0: // power on off
                    makePowerOnOffRCP();
                    break;
                case 1: // get information
                    makeGetInformationRCP();
                    break;
                case 2: // set channe
                    makeSetChannelRCP();
                    break;
                case 3: // set TX power
                    makeSetTXPowerRCP();
                    break;
                case 4: //  get session
                    makeGetSessionRCP();
                    break;
            }
        }
        
        
        private void setParamtersUI(int nDevice, int nCommand)
        {
            
            gbParameters.Controls.Clear();
            gbParameters.Controls.Add(btnMake);
            if (nDevice == 0)
            {
                switch (nCommand)
                {
                    case 0:// = "Power On/Off";
                        setParametersPowerOnOff();
                        break;
                    case 1:// = "Get Information";
                        setParametersGetInformation();
                        break;
                    case 2:// = "Set Channel";
                        setParametersSetChannel();
                        break;
                    case 3:// = "Set TX Power";
                        setParametersSetTXPower();
                        break;
                    case 4:// = "Get Session";
                        setParametersGetSession();
                        break;
                    default:
                        break;
                }
            }
        }
        
        private void setParametersPowerOnOff()
        {
            
            // power on off
            cbOnOff = new CheckBox();
            cbOnOff.Text = "On / Off";
            cbOnOff.Location = new Point(25,25);
            gbParameters.Controls.Add(cbOnOff);
            cbOnOff.CheckedChanged += new System.EventHandler(this.PowerOnOff_cbEvent);

            // set beep
            cbBeep = new CheckBox();
            cbBeep.Text = "Beep";
            cbBeep.Location = new Point(238, 25);
            gbParameters.Controls.Add(cbBeep);
            cbBeep.CheckedChanged += new System.EventHandler(this.PowerOnOff_cbEvent);

            //set vibration
            cbVibration = new CheckBox();
            cbVibration.Text = "Vibration";
            cbVibration.Location = new Point(25, 125);
            gbParameters.Controls.Add(cbVibration);
            cbVibration.CheckedChanged += new System.EventHandler(this.PowerOnOff_cbEvent);

            //set LED
            cbLED = new CheckBox();
            cbLED.Text = "LED";
            cbLED.Location = new Point(238, 125);
            gbParameters.Controls.Add(cbLED);
            cbLED.CheckedChanged += new System.EventHandler(this.PowerOnOff_cbEvent);

            //set Illumination
            cbIllumination = new CheckBox();
            cbIllumination.Text = "Illumination";
            cbIllumination.Location = new Point(25, 225);
            gbParameters.Controls.Add(cbIllumination);
            cbIllumination.CheckedChanged += new System.EventHandler(this.PowerOnOff_cbEvent);
        }

        private void setParametersGetInformation()
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
                rbInformation[i].Location = new Point(25, 25 + i * 30);
                gbParameters.Controls.Add(rbInformation[i]);
                rbInformation[i].CheckedChanged += new System.EventHandler(this.GetInformationEvent);
            }
            
            //model, S/N, Manufacurer, Frequency, Tag Type
        }
        private void setParametersSetChannel()
        {
            Label lbChannel = new Label();
            lbChannel.Text = "Channel Number :";
            lbChannel.Size = new Size(170, 25);
            lbChannel.Location = new Point(25, 30);
            gbParameters.Controls.Add(lbChannel);

            tbChannel = new TextBox();
            tbChannel.Size = new Size(150, 25);
            tbChannel.Location = new Point(195, 25);
            tbChannel.Text = "0";
            gbParameters.Controls.Add(tbChannel);

            Label lbOffset = new Label();
            lbOffset.Text = "Offset :";
            lbOffset.Size = new Size(170, 25);
            lbOffset.Location = new Point(25, 65);
            gbParameters.Controls.Add(lbOffset);

            tbOffset = new TextBox();
            tbOffset.Size = new Size(150, 25);
            tbOffset.Location = new Point(195, 60);
            tbOffset.Text = "0";
            gbParameters.Controls.Add(tbOffset);

        }
        private void setParametersSetTXPower()
        {
            Label lbPower = new Label();
            lbPower.Text = "TX Power (dBm ; 18.0~25.0) :";
            lbPower.Size = new Size(210, 25);
            lbPower.Location = new Point(25, 30);
            gbParameters.Controls.Add(lbPower);

            cbPower = new ComboBox();
            cbPower.Text = "18";
            for (float i = 180; i < 251 ;i+=5)
            {
                cbPower.Items.Add(i / 10);
            }
            cbPower.Location = new Point(235, 25);
            gbParameters.Controls.Add(cbPower);
        }

        private void setParametersGetSession() 
        {
            Label lbNoParam = new Label();
            lbNoParam.Text = "No Parameter";
            lbNoParam.Location = new Point(25, 25);
            gbParameters.Controls.Add(lbNoParam);
        }

        private void PowerOnOff_cbEvent(Object sender, EventArgs e)
        {
            if (cbOnOff.Checked)
                storeRCP.setOnOff(true);
            else
                storeRCP.setOnOff(false);

            if (cbBeep.Checked)
                storeRCP.setBeep(true);
            else
                storeRCP.setBeep(false);

            if (cbVibration.Checked)
                storeRCP.setVibration(true);
            else
                storeRCP.setVibration(false);

            if (cbLED.Checked)
                storeRCP.setLED(true);
            else
                storeRCP.setLED(false);

            if (cbIllumination.Checked)
                storeRCP.setIllumination(true);
            else
                storeRCP.setIllumination(false);
        }
        private void GetInformationEvent(Object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (rbInformation[i].Checked)
                {
                    storeRCP.setInformationMode(i);
                    break;
                }
            }
        }
        private void makePowerOnOffRCP()
        {
            int i = 0;
            byte[] RCP = new byte[14];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x01; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x06; // Length(LSB)

            if (storeRCP.getOnOff())
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if(storeRCP.getBeep())
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if(storeRCP.getVibration())
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if (storeRCP.getLED())
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            if (storeRCP.getIllumination())
                RCP[i++] = 0xFF;
            else
                RCP[i++] = 0x00;

            RCP[i++] = 0xFF; // mode
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = crcAppend(RCP, 12);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            txResult.Text = ByteArrayToString(RCP);
        }
        
        private void makeGetInformationRCP()
        {
            int i = 0;
            byte[] RCP = new byte[9];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x03; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x01; // Length(LSB)
            RCP[i++] = (byte)storeRCP.getInformationMode();
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = crcAppend(RCP, 7);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            txResult.Text = ByteArrayToString(RCP);
        }
        private void makeSetChannelRCP()
        {
            if (tbChannel.Text.Equals("") | tbOffset.Text.Equals(""))
            {
                txResult.Text = "There is not enough information";
                return;
            }
            int i = 0;
            byte[] RCP = new byte[10];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x12; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x02; // Length(LSB)
            RCP[i++] = (byte)Convert.ToInt32(tbChannel.Text);
            RCP[i++] = (byte)Convert.ToInt32(tbOffset.Text);
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = crcAppend(RCP, 8);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            txResult.Text = ByteArrayToString(RCP);
        }
        private void makeSetTXPowerRCP()
        {
            int i = 0;
            int pow;
            byte[] RCP = new byte[10];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x16; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x02; // Length(LSB)
            int point = cbPower.Text.IndexOf(".");
            if(point == -1)
                pow = Convert.ToInt32(cbPower.Text) * 10;
            else
            {
                pow = Convert.ToInt32(cbPower.Text.Substring(0, point));
                pow = pow *10 + Convert.ToInt32(cbPower.Text.Substring(point+1));
            }

            RCP[i++] = (byte)(pow >> 8);
            RCP[i++] = (byte)(pow);
            RCP[i++] = 0x7E; // End Mark
            // CRC
            ushort crc = crcAppend(RCP, 8);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;

            txResult.Text = ByteArrayToString(RCP);
        }
        private void makeGetSessionRCP()
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
            ushort crc= crcAppend(RCP, 6);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            txResult.Text = ByteArrayToString(RCP);
        }
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
                crc = crcPolynomial(msg[i],crc);
            }
            return crc;
        }
        private ushort crcAppend(byte[] message, ushort length)
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
