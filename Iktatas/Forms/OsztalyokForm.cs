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
    public partial class OsztalyokForm : Form
    {
        public OsztalyokForm()
        {
            InitializeComponent();
        }

        private void osztalyokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osztalyokBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.osztalyokDS);

        }

        private void OsztalyokForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'osztalyokDS.Osztalyok' table. You can move, or remove it, as needed.
            this.osztalyokTableAdapter.Fill(this.osztalyokDS.Osztalyok);

        }

        private void osztalyokBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osztalyokBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.osztalyokDS1);

        }

        private void OsztalyokForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'osztalyokDS1.Osztalyok' table. You can move, or remove it, as needed.
            this.osztalyokTableAdapter1.Fill(this.osztalyokDS1.Osztalyok);

        }
    }
}
