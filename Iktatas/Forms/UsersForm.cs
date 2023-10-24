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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDS);

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDS.Users);

        }

        private void usersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.usersDS1);

        }

        private void UsersForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDS1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.usersDS1.Users);

        }
    }
}
