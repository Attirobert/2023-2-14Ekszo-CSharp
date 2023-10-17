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
    public partial class IktatEgyes : Form
    {
        public IktatEgyes()
        {
            InitializeComponent();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktatEgyesDS);

        }

        private void IktatEgyes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatEgyesDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktatEgyesDS.Users);
            // TODO: This line of code loads data into the 'iktatEgyesDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatEgyesDS.iktat);
            // TODO: This line of code loads data into the 'iktatEgyesDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatEgyesDS.iktat);

        }

        private void iktatBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktatEgyesDS);

        }
    }
}
