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
    public partial class BeosztasokForm : Form
    {
        public BeosztasokForm()
        {
            InitializeComponent();
        }

        private void beosztasokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.beosztasokBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beosztasokDS);

        }

        private void BeosztasokForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beosztasokDS.Beosztasok' table. You can move, or remove it, as needed.
            this.beosztasokTableAdapter.Fill(this.beosztasokDS.Beosztasok);

        }

        private void beosztasokBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.beosztasokBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.beosztasokDS1);

        }

        private void BeosztasokForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beosztasokDS1.Beosztasok' table. You can move, or remove it, as needed.
            this.beosztasokTableAdapter1.Fill(this.beosztasokDS1.Beosztasok);

        }
    }
}
