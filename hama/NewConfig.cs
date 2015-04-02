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
        public AutoResetEvent receiveNow;
        public SerialPort _port;

        public NewConfig()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_port != null && _port.IsOpen)
                {
                    _port.Close();
                    btnOK.Text = "Connect";
                    return;
                }
                _port = OpenPort(cboPortName.Text,Convert.ToInt32(cboBaudRate.Text),Convert.ToInt32(cboDataBits.Text),Convert.ToInt32(txtReadTimeOut.Text),Convert.ToInt32(txtWriteTimeOut.Text));

                if (_port.IsOpen)
                {
                    ((MDI)this.MdiParent).statusStrip.Text = "Modem is connected at PORT " + _port.PortName;
                    this.MdiParent.Refresh();
                    txtlog.Text += "\nModem is connected at PORT " + _port.PortName;
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
                txtlog.Text += ExecCommand(_port, txtcmd.Text, Convert.ToInt32(txtWriteTimeOut.Text), "Erro Run command");
            }
            catch (Exception ex)
            {
                txtlog.Text += "\n" + ex.Message;
            }

        }

        #region serialport helper
        public SerialPort OpenPort(string p_strPortName, int p_uBaudRate, int p_uDataBits, int p_uReadTimeout, int p_uWriteTimeout)
        {
            receiveNow = new AutoResetEvent(false);
            SerialPort port = new SerialPort();

            try
            {
                port.PortName = p_strPortName;                 
                port.BaudRate = p_uBaudRate;                   
                port.DataBits = p_uDataBits;                   
                port.StopBits = StopBits.One;                  
                port.Parity = Parity.None;                     
                port.ReadTimeout = p_uReadTimeout;             
                port.WriteTimeout = p_uWriteTimeout;           
                port.Encoding = Encoding.GetEncoding("iso-8859-1");
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return port;
        }

        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    receiveNow.Set();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string ReadResponse(SerialPort port, int timeout)
        {
            string buffer = string.Empty;
            try
            {
                do
                {
                    if (receiveNow.WaitOne(timeout, false))
                    {
                        string t = port.ReadExisting();
                        buffer += t;
                    }
                    else
                    {
                        if (buffer.Length > 0)
                            throw new ApplicationException("Response received is incomplete.");
                        else
                            throw new ApplicationException("No data received from phone.");
                    }
                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return buffer;
        }


        public string ExecCommand(SerialPort port, string command, int responseTimeout, string errorMessage)
        {
            try
            {

                port.DiscardOutBuffer();
                port.DiscardInBuffer();
                receiveNow.Reset();
                port.Write(command + "\r");

                string input = ReadResponse(port, responseTimeout);
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException("No success message was received.");
                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }
}
