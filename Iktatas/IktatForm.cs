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
    public partial class IktatForm : Form
    {
        private int sorszam;

        public IktatForm()
        {
            InitializeComponent();
            sorszam = 0;
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktatDS);

        }

        private void IktatForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.iktatDS.Temak);
            // TODO: This line of code loads data into the 'iktatDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.iktatDS.Users);
            // TODO: This line of code loads data into the 'usersDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDS.Users);
            // TODO: This line of code loads data into the 'iktatDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatDS.iktat);

        }


        private void iktatDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            string ma = DateTime.Today.ToString();
            this.sorszam++;

            e.Row.Cells["cnIktatoszam"].Value = ma.Substring(0, 4) + 
                ma.Substring(6, 2) + 
                ma.Substring(10,2) + "/" + 
                this.sorszam.ToString();

            e.Row.Cells["cnDatum"].Value = ma;
        }

        private void iktatDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string ma = DateTime.Today.ToShortDateString();

            if (e.FormattedValue.ToString() != ma)
            {
            MessageBox.Show("Hibás dátum!");
            }
            else
            {
                MessageBox.Show("Jó dátum!");
            }
        }

    }
}
