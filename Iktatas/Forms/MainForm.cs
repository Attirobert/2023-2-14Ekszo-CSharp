using Iktatas.Forms;
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

        private void címzettekLeveleiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CimzettSzuresForm frm = new CimzettSzuresForm();
            frm.Show();
        }

        private void levelekDátumSzerintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelekIktatasDatumForm frm = new LevelekIktatasDatumForm();
            frm.Show();
        }

        private void levelekSzűréseNaptárralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelekDatumForm frm = new LevelekDatumForm();
            frm.Show();
        }

        private void iktatóKönyvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatoTallozForm frm = new IktatoTallozForm();
            frm.Show();
        }
    }
}
