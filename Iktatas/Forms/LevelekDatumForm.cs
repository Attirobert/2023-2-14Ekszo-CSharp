using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktatas.Forms
{
    public partial class LevelekDatumForm : Form
    {
        public LevelekDatumForm()
        {
            InitializeComponent();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.levelekDatumDS);

        }

        private void LevelekDatumForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'levelekDatumDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.levelekDatumDS.Temak);
            // TODO: This line of code loads data into the 'levelekDatumDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.levelekDatumDS.Users);
            // TODO: This line of code loads data into the 'levelekDatumDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.levelekDatumDS.iktat);

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            iktatBindingSource.Filter = $"(Datum='{dtp1.Value.ToShortDateString()}')";
        }
    }
}
