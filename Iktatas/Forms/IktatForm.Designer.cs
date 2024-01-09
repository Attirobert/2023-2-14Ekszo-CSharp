
using Iktatas.DataSets;

namespace Iktatas
{
    partial class IktatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IktatForm));
            this.iktatDS1 = new Iktatas.DataSets.IktatDS();
            this.iktatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iktatTableAdapter1 = new Iktatas.DataSets.IktatDSTableAdapters.iktatTableAdapter();
            this.tableAdapterManager1 = new Iktatas.DataSets.IktatDSTableAdapters.TableAdapterManager();
            this.temakTableAdapter1 = new Iktatas.DataSets.IktatDSTableAdapters.TemakTableAdapter();
            this.usersTableAdapter2 = new Iktatas.DataSets.IktatDSTableAdapters.UsersTableAdapter();
            this.iktatBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.iktatBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iktatDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnIktatszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnTargy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource1BindingNavigator)).BeginInit();
            this.iktatBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // iktatDS1
            // 
            this.iktatDS1.DataSetName = "IktatDS";
            this.iktatDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iktatBindingSource1
            // 
            this.iktatBindingSource1.DataMember = "iktat";
            this.iktatBindingSource1.DataSource = this.iktatDS1;
            // 
            // iktatTableAdapter1
            // 
            this.iktatTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.iktatTableAdapter = this.iktatTableAdapter1;
            this.tableAdapterManager1.TemakTableAdapter = this.temakTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Iktatas.DataSets.IktatDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter2;
            // 
            // temakTableAdapter1
            // 
            this.temakTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // iktatBindingSource1BindingNavigator
            // 
            this.iktatBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.iktatBindingSource1BindingNavigator.BindingSource = this.iktatBindingSource1;
            this.iktatBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.iktatBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.iktatBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.iktatBindingSource1BindingNavigatorSaveItem});
            this.iktatBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iktatBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.iktatBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.iktatBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.iktatBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.iktatBindingSource1BindingNavigator.Name = "iktatBindingSource1BindingNavigator";
            this.iktatBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.iktatBindingSource1BindingNavigator.Size = new System.Drawing.Size(668, 25);
            this.iktatBindingSource1BindingNavigator.TabIndex = 0;
            this.iktatBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // iktatBindingSource1BindingNavigatorSaveItem
            // 
            this.iktatBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iktatBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iktatBindingSource1BindingNavigatorSaveItem.Image")));
            this.iktatBindingSource1BindingNavigatorSaveItem.Name = "iktatBindingSource1BindingNavigatorSaveItem";
            this.iktatBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iktatBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.iktatBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.iktatBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // iktatDataGridView1
            // 
            this.iktatDataGridView1.AutoGenerateColumns = false;
            this.iktatDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iktatDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.cnIktatszam,
            this.dataGridViewTextBoxColumn7,
            this.cnDate,
            this.cnTargy,
            this.dataGridViewTextBoxColumn10});
            this.iktatDataGridView1.DataSource = this.iktatBindingSource1;
            this.iktatDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iktatDataGridView1.Location = new System.Drawing.Point(0, 25);
            this.iktatDataGridView1.Name = "iktatDataGridView1";
            this.iktatDataGridView1.Size = new System.Drawing.Size(668, 247);
            this.iktatDataGridView1.TabIndex = 1;
            this.iktatDataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.iktatDataGridView_CellValidating);
            this.iktatDataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.iktatDataGridView_DefaultValuesNeeded);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_iktat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Azonosító";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cnIktatszam
            // 
            this.cnIktatszam.DataPropertyName = "Iktatoszam";
            this.cnIktatszam.HeaderText = "Iktatószám";
            this.cnIktatszam.Name = "cnIktatszam";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdUser";
            this.dataGridViewTextBoxColumn7.DataSource = this.bindingSource1;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Nev";
            this.dataGridViewTextBoxColumn7.HeaderText = "Felhasználó";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Id_user";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Users";
            this.bindingSource1.DataSource = this.iktatDS1;
            // 
            // cnDate
            // 
            this.cnDate.DataPropertyName = "Datum";
            this.cnDate.HeaderText = "Dátum";
            this.cnDate.Name = "cnDate";
            // 
            // cnTargy
            // 
            this.cnTargy.DataPropertyName = "IdTema";
            this.cnTargy.DataSource = this.bindingSource2;
            this.cnTargy.DisplayMember = "Tema";
            this.cnTargy.HeaderText = "Téma";
            this.cnTargy.Name = "cnTargy";
            this.cnTargy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cnTargy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cnTargy.ValueMember = "Id_Tema";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Temak";
            this.bindingSource2.DataSource = this.iktatDS1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Leiras";
            this.dataGridViewTextBoxColumn10.HeaderText = "Leírás";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // IktatForm
            // 
            this.ClientSize = new System.Drawing.Size(668, 272);
            this.Controls.Add(this.iktatDataGridView1);
            this.Controls.Add(this.iktatBindingSource1BindingNavigator);
            this.Name = "IktatForm";
            this.Text = "Iktatás";
            this.Load += new System.EventHandler(this.IktatForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.iktatDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource1BindingNavigator)).EndInit();
            this.iktatBindingSource1BindingNavigator.ResumeLayout(false);
            this.iktatBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IktatDS iktatDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private DataSets.IktatDSTableAdapters.iktatTableAdapter iktatTableAdapter;
        private DataSets.IktatDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iktatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton iktatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iktatDataGridView;
        private UsersDS usersDS;
        private System.Windows.Forms.BindingSource usersDSBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSets.UsersDSTableAdapters.UsersTableAdapter usersTableAdapter;
        private DataSets.IktatDSTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private DataSets.IktatDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private System.Windows.Forms.BindingSource temakBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIktatoszam;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnDatum;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataSets.IktatDS iktatDS1;
        private System.Windows.Forms.BindingSource iktatBindingSource1;
        private DataSets.IktatDSTableAdapters.iktatTableAdapter iktatTableAdapter1;
        private DataSets.IktatDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator iktatBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton iktatBindingSource1BindingNavigatorSaveItem;
        private DataSets.IktatDSTableAdapters.UsersTableAdapter usersTableAdapter2;
        private System.Windows.Forms.DataGridView iktatDataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSets.IktatDSTableAdapters.TemakTableAdapter temakTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIktatszam;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn cnTargy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}