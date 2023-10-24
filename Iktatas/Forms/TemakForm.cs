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
    public partial class TemakForm : Form
    {
        public TemakForm()
        {
            InitializeComponent();
        }

        private void temakBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.temakBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temakDS);

        }

        private void TemakForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'temakDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.temakDS.Temak);

        }

        private void temakBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.temakBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.temakDS1);

        }

        private void TemakForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'temakDS1.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter1.Fill(this.temakDS1.Temak);

        }
    }
}
