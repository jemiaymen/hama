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
    public partial class ReadSMS : Form
    {

        Serial s = new Serial();
        public ReadSMS()
        {
            InitializeComponent();
        }

        private void btnReadSMS_Click(object sender, EventArgs e)
        {
           

            #region Command
            string strCommand = "AT+CMGL=\"ALL\"";

            if (this.rbReadAll.Checked)
            {
                strCommand = "AT+CMGL=\"ALL\"";
            }
            else if (this.rbReadUnRead.Checked)
            {
                strCommand = "AT+CMGL=\"REC UNREAD\"";
            }
            else if (this.rbReadStoreSent.Checked)
            {
                strCommand = "AT+CMGL=\"STO SENT\"";
            }
            else if (this.rbReadStoreUnSent.Checked)
            {
                strCommand = "AT+CMGL=\"STO UNSENT\"";
            }
            #endregion




            
            ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
            objShortMessageCollection = s.ReadSMS(s._port, strCommand);
            foreach (ShortMessage msg in objShortMessageCollection)
            {

                ListViewItem item = new ListViewItem(new string[] { msg.Index, msg.Sent, msg.Sender, msg.Message });
                item.Tag = msg;
                lvwMessages.Items.Add(item);

            }
          
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            s.OpenPort(cboPortName.Text, Convert.ToInt32(cboBaudRate.Text), Convert.ToInt32(cboDataBits.Text), Convert.ToInt32(txtReadTimeOut.Text), Convert.ToInt32(txtWriteTimeOut.Text));
            if (s._port.IsOpen)
            {
                this.Height = 746;
                btnOK.Text = "Deconexion";
            }
            else
            {
                textBox1.Text = "Port Error !!";
            }
        }
    }
}
