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
    public partial class IktatoTallozForm : Form
    {
        public IktatoTallozForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktatoTallozDS);

        }

        private void IktatoTallozForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatoTallozDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatoTallozDS.iktat);
            // TODO: This line of code loads data into the 'iktatoTallozDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktatoTallozDS.Users);

        }
    }
}
