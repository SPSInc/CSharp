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
        PowerOnOffForm powerForm;
        GetInfoForm infoForm;
        SetChForm setChForm;
        SetTxPowerForm setTxPowForm;
        GetSessionForm getSesForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Device_Enter(object sender, EventArgs e)
        {

        }
        public void setRCP(string strRCP)
        {
            txResult.Text = strRCP;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            powerForm = new PowerOnOffForm();
            infoForm = new GetInfoForm();
            setChForm = new SetChForm();
            setTxPowForm = new SetTxPowerForm();
            getSesForm = new GetSessionForm();

            powerForm.FormSendEvent += new PowerOnOffForm.FormSendDataHandler(writeRcp);
            infoForm.FormSendEvent += new GetInfoForm.FormSendDataHandler(writeRcp);
            setChForm.FormSendEvent += new SetChForm.FormSendDataHandler(writeRcp);
            setTxPowForm.FormSendEvent += new SetTxPowerForm.FormSendDataHandler(writeRcp);
            getSesForm.FormSendEvent += new GetSessionForm.FormSendDataHandler(writeRcp);

            cbDevice.SelectedIndex = 0;
            cbCommand.SelectedIndex = 0;
            //setParametersPowerOnOff();
            
            powerForm.TopLevel = false;
            infoForm.TopLevel = false;
            setChForm.TopLevel = false;
            setTxPowForm.TopLevel = false;
            getSesForm.TopLevel = false;

            powerForm.Dock = DockStyle.Fill;
            infoForm.Dock = DockStyle.Fill;
            setChForm.Dock = DockStyle.Fill;
            setTxPowForm.Dock = DockStyle.Fill;
            getSesForm.Dock = DockStyle.Fill;

            panel1.Controls.Add(infoForm);
            panel1.Controls.Add(setChForm);
            panel1.Controls.Add(powerForm);
            panel1.Controls.Add(setTxPowForm);
            panel1.Controls.Add(getSesForm);
            
        }
        private void writeRcp(string strRcp)
        {
            txResult.Text = strRcp;
        }

        private void SelectChangeCommand(object sender, EventArgs e)
        {
            int nSel = cbCommand.SelectedIndex;

            powerForm.Hide();
            infoForm.Hide();
            setChForm.Hide();
            setTxPowForm.Hide();
            getSesForm.Hide();

            switch (nSel)
            {
                case 0:
                    powerForm.Show();
                    break;
                case 1:
                    infoForm.Show();
                    break;
                case 2:
                    setChForm.Show();
                    break;
                case 3:
                    setTxPowForm.Show();
                    break;
                case 4:
                    getSesForm.Show();
                    break;
            }
        }
    }
}
