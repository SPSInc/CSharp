﻿using System;
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
    public partial class SetChForm : Form
    {
        private RCPinterface frm = null;
        public SetChForm(RCPinterface frm)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.frm = frm;
        }

        private void SetChForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            this.frm.setRCP(makeSetChannelRCP());
        }
        private string makeSetChannelRCP()
        {
            if (tbCh.Text.Equals("") | tbOffset.Text.Equals(""))
            {
                return  "There is not enough information";
            }
            int i = 0;
            byte[] RCP = new byte[10];
            RCP[i++] = 0xBB; // Preamble
            RCP[i++] = 0x00; // Msg Type
            RCP[i++] = 0x12; // Code
            RCP[i++] = 0x00; // Length(MSB)
            RCP[i++] = 0x02; // Length(LSB)
            RCP[i++] = (byte)Convert.ToInt32(tbCh.Text);
            RCP[i++] = (byte)Convert.ToInt32(tbOffset.Text);
            RCP[i++] = 0x7E; // End Mark
            // CRC
            CalculatorCRC calculatorCRC = new CalculatorCRC();
            ushort crc = calculatorCRC.crcAppend(RCP, (ushort)i);
            RCP[i++] = (byte)(crc >> 8);
            RCP[i++] = (byte)crc;
            return calculatorCRC.ByteArrayToString(RCP);
        }
    }
}
