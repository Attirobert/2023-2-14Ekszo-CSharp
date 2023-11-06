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
    public partial class CimzettSzuresForm : Form
    {
        public CimzettSzuresForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cimzettSzuresDS);

        }

        private void CimzettSzuresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cimzettSzuresDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.cimzettSzuresDS.Temak);
            // TODO: This line of code loads data into the 'cimzettSzuresDS.iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.cimzettSzuresDS.iktat);
            // TODO: This line of code loads data into the 'cimzettSzuresDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.cimzettSzuresDS.Users);

        }
    }
}
