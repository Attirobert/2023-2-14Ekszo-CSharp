using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktatas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void beosztásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeosztasokForm frm = new BeosztasokForm();
            frm.Show();
        }

        private void osztályokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OsztalyokForm frm = new OsztalyokForm();
            frm.Show();
        }

        private void személyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
        }

        private void levelezésiTémákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemakForm frm = new TemakForm();
            frm.Show();
        }

        private void iktatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatForm frm = new IktatForm();
            frm.Show();
        }

        private void iktatóLapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatEgyes frm = new IktatEgyes();
            frm.Show();
        }
    }
}
