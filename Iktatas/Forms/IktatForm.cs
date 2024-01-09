using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iktatas.DataSets;

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
            this.usersTableAdapter.Fill(this.iktatDS.Users);
            // TODO: This line of code loads data into the 'iktatDS.Iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatDS.Iktat);

        }

<<<<<<< HEAD:Iktatas/IktatForm.cs
=======

        private void iktatDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            string ma = DateTime.Today.ToString();
            this.sorszam++;

            e.Row.Cells["cnIktatszam"].Value = ma.Substring(0, 4) + 
                ma.Substring(6, 2) + 
                ma.Substring(10,2) + "/" + 
                this.sorszam.ToString();

            e.Row.Cells["cnDate"].Value = ma;
        }

>>>>>>> a7198fee091e3d6c68057f364fdad86de9dd319f:Iktatas/Forms/IktatForm.cs
        private void iktatDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string ma = DateTime.Today.ToShortDateString();

<<<<<<< HEAD:Iktatas/IktatForm.cs
            if (e.FormattedValue.ToString() != ma)
            {
                MessageBox.Show("Hibás dátum!");
            }
            else
            {
                MessageBox.Show("Jó dátum!");
            }
        }

        private void iktatDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            string ma = DateTime.Today.ToShortDateString();
            this.sorszam++;

            e.Row.Cells["cnIktatoszam"].Value = ma.Substring(0, 4) +
                ma.Substring(6, 2) +
                ma.Substring(10, 2) + "/" +
                this.sorszam.ToString();

            e.Row.Cells["cnDatum"].Value = ma;
=======
            //if (e.ColumnIndex == 3 && e.FormattedValue.ToString() != ma)
            //{
            //    MessageBox.Show("Hibás dátum!");
            //}
        }

        private void iktatBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.iktatDS1);

        }

        private void IktatForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatDS1.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter1.Fill(this.iktatDS1.Temak);
            // TODO: This line of code loads data into the 'iktatDS1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.iktatDS1.Users);
            // TODO: This line of code loads data into the 'iktatDS1.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter1.Fill(this.iktatDS1.iktat);

>>>>>>> a7198fee091e3d6c68057f364fdad86de9dd319f:Iktatas/Forms/IktatForm.cs
        }
    }
}
