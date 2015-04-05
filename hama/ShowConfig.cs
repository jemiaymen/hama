using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hama
{
    public partial class ShowConfig : Form
    {
        public ShowConfig()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Serial s = new Serial();
            try
            {
                s.OpenPort(cboPortName.Text, Convert.ToInt32(cboBaudRate.Text), Convert.ToInt32(cboDataBits.Text), Convert.ToInt32(txtReadTimeOut.Text), Convert.ToInt32(txtWriteTimeOut.Text));
                if (s._port.IsOpen)
                {
                    textBox1.Text = "Port Is Open ";
                    textBox1.Text += s.ExecCommand(s._port, "AT&v", Convert.ToInt32(txtWriteTimeOut.Text), "Erro Run command");
                }
                else
                {
                    textBox1.Text = "Port Error !!";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
            

            

        }
    }
}
