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
    public partial class LevelekIktatasDatumForm : Form
    {
        public LevelekIktatasDatumForm()
        {
            InitializeComponent();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.levelekIktatasDatumDS);

        }

        private void LevelekIktatasDatumForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'levelekIktatasDatumDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.levelekIktatasDatumDS.Temak);
            // TODO: This line of code loads data into the 'levelekIktatasDatumDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.levelekIktatasDatumDS.Users);
            // TODO: This line of code loads data into the 'levelekIktatasDatumDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.levelekIktatasDatumDS.iktat);

        }

        private void datumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            iktatBindingSource.Filter = $"(Datum='{datumComboBox.Text}')";
        }
    }
}
