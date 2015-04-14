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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.MdiParent = this;
            a.Show();
        }

        private void testReseauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testModemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConfig n = new NewConfig();
            n.MdiParent = this;
            n.Show();
        }

        public void setStatu(string state)
        {
            statusStrip.Text = state;
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultConfig d = new DefaultConfig();

            d.MdiParent = this;
            d.Show();
        }

        private void defaultConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConfig sh = new ShowConfig();
            sh.MdiParent = this;
            sh.Show();
        }
    }
}
