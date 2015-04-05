using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace hama
{
    public partial class NewConfig : Form
    {
        Serial s;

        public NewConfig()
        {
            InitializeComponent();
            s = new Serial();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (s._port != null && s._port.IsOpen)
                {
                    s._port.Close();
                    btnOK.Text = "Connect";
                    return;
                }
                s.OpenPort(cboPortName.Text,Convert.ToInt32(cboBaudRate.Text),Convert.ToInt32(cboDataBits.Text),Convert.ToInt32(txtReadTimeOut.Text),Convert.ToInt32(txtWriteTimeOut.Text));

                if (s._port.IsOpen)
                {
                    ((MDI)this.MdiParent).statusStrip.Text = "Modem is connected at PORT " + s._port.PortName;
                    this.MdiParent.Refresh();
                    txtlog.Text += "\nModem is connected at PORT " + s._port.PortName;
                    commandGroup.Enabled = true;
                    btnOK.Text = "Deconect";
                }else
                {
                    commandGroup.Enabled = false;
                }

            }catch(Exception ex)
            {
                commandGroup.Enabled = false;
                txtlog.Text += "\n" + ex.Message;
            }
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtcmd.Text == "")
            {
                btnRun.Enabled = false;
            }
            else
            {
                btnRun.Enabled = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                txtlog.Text += s.ExecCommand(s._port, txtcmd.Text, Convert.ToInt32(txtWriteTimeOut.Text), "Erro Run command");
            }
            catch (Exception ex)
            {
                txtlog.Text += "\n" + ex.Message;
            }

        }

        





    }
}
