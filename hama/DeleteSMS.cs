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
    public partial class DeleteSMS : Form
    {
        Serial s = new Serial();
        public DeleteSMS()
        {
            InitializeComponent();
        }

        private void btnDeleteSMS_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are u sure u want to delete the SMS?", "Delete confirmation", MessageBoxButtons.YesNo);

            if (dr.ToString() == "Yes")
            {

                if (this.rbDeleteAllSMS.Checked)
                {

                    string strCommand = "AT+CMGD=1,4";
                    if (s.DeleteMsg(s._port, strCommand))
                    {
                        MessageBox.Show("Messages has deleted successfuly ");
    
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete messages ");
                    }

                }
                else if (this.rbDeleteReadSMS.Checked)
                {


                    string strCommand = "AT+CMGD=1,3";
                    if (s.DeleteMsg(s._port, strCommand))
                    {
                        MessageBox.Show("Messages has deleted successfuly");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete messages ");
                    }


                }


            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            s.OpenPort(cboPortName.Text, Convert.ToInt32(cboBaudRate.Text), Convert.ToInt32(cboDataBits.Text), Convert.ToInt32(txtReadTimeOut.Text), Convert.ToInt32(txtWriteTimeOut.Text));
            if (s._port.IsOpen)
            {
                this.Height = 516;
                btnOK.Text = "Deconexion";
            }
            else
            {
                textBox1.Text = "Port Error !!";
            }
        }
    }
}
