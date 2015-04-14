using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hama
{
    public partial class DefaultConfig : Form
    {
        public DefaultConfig()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Default("default.data");
        }


        public void Default(string path)
        {

            try
            {


                if (!File.Exists(path))
                {

                    StreamWriter w = File.CreateText(path);

                    w.WriteLine("AT+IPR=");
                    w.WriteLine("AT+ICF= 2,1");
                    w.WriteLine("AT+WSRT=1;\"00:20\"");
                    w.WriteLine("AT&W");

                    w.Close();

                }
                else if (File.OpenRead(path).Length < 4)
                {
                    File.Delete(path);

                    StreamWriter w = File.CreateText(path);

                    w.WriteLine("AT+IPR=");
                    w.WriteLine("AT+ICF= 2,1");
                    w.WriteLine("AT+WSRT=1;\"00:20\"");
                    w.WriteLine("AT&W");

                    w.Close();
                }

                StreamReader r = File.OpenText(path);
                string data = "";

                Serial s = new Serial();

                s.OpenPort(cboPortName.Text, Convert.ToInt32(cboBaudRate.Text), Convert.ToInt32(cboDataBits.Text), Convert.ToInt32(txtReadTimeOut.Text), Convert.ToInt32(txtWriteTimeOut.Text));
                if (s._port.IsOpen)
                {
                    textBox1.Text = "Port Is Open ";
                    while ((data = r.ReadLine()) != null)
                    {
                        textBox1.Text += s.ExecCommand(s._port, data, Convert.ToInt32(txtWriteTimeOut.Text), "Erro Run command");
                    }
                }
                else
                {
                    textBox1.Text = "Port Error !!";
                }
                r.Close();
            }
            catch (Exception ex)
            {

                textBox1.Text = ex.Message;
            }



        }
    }
}
