
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
            this.iktatDS = new Iktatas.IktatDS();
            this.iktatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iktatTableAdapter = new Iktatas.IktatDSTableAdapters.iktatTableAdapter();
            this.tableAdapterManager = new Iktatas.IktatDSTableAdapters.TableAdapterManager();
            this.temakTableAdapter = new Iktatas.IktatDSTableAdapters.TemakTableAdapter();
            this.usersTableAdapter1 = new Iktatas.IktatDSTableAdapters.UsersTableAdapter();
            this.iktatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iktatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iktatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnIktatoszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cnDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.temakBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDS = new Iktatas.UsersDS();
            this.usersDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Iktatas.UsersDSTableAdapters.UsersTableAdapter();
            this.temakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iktatDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingNavigator)).BeginInit();
            this.iktatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iktatDS
            // 
            this.iktatDS.DataSetName = "IktatDS";
            this.iktatDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iktatBindingSource
            // 
            this.iktatBindingSource.DataMember = "iktat";
            this.iktatBindingSource.DataSource = this.iktatDS;
            // 
            // iktatTableAdapter
            // 
            this.iktatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.iktatTableAdapter = this.iktatTableAdapter;
            this.tableAdapterManager.TemakTableAdapter = this.temakTableAdapter;
            this.tableAdapterManager.UpdateOrder = Iktatas.IktatDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter1;
            // 
            // temakTableAdapter
            // 
            this.temakTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // iktatBindingNavigator
            // 
            this.iktatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iktatBindingNavigator.BindingSource = this.iktatBindingSource;
            this.iktatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iktatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iktatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iktatBindingNavigatorSaveItem});
            this.iktatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iktatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iktatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iktatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iktatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iktatBindingNavigator.Name = "iktatBindingNavigator";
            this.iktatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iktatBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.iktatBindingNavigator.TabIndex = 0;
            this.iktatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iktatBindingNavigatorSaveItem
            // 
            this.iktatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iktatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iktatBindingNavigatorSaveItem.Image")));
            this.iktatBindingNavigatorSaveItem.Name = "iktatBindingNavigatorSaveItem";
            this.iktatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iktatBindingNavigatorSaveItem.Text = "Save Data";
            this.iktatBindingNavigatorSaveItem.Click += new System.EventHandler(this.iktatBindingNavigatorSaveItem_Click);
            // 
            // iktatDataGridView
            // 
            this.iktatDataGridView.AutoGenerateColumns = false;
            this.iktatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iktatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cnIktatoszam,
            this.dataGridViewTextBoxColumn3,
            this.cnDatum,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.iktatDataGridView.DataSource = this.iktatBindingSource;
            this.iktatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iktatDataGridView.Location = new System.Drawing.Point(0, 25);
            this.iktatDataGridView.Name = "iktatDataGridView";
            this.iktatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.iktatDataGridView.Size = new System.Drawing.Size(800, 425);
            this.iktatDataGridView.TabIndex = 1;
            this.iktatDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.iktatDataGridView_CellValidating);
            this.iktatDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.iktatDataGridView_DefaultValuesNeeded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_iktat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Azonosító";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cnIktatoszam
            // 
            this.cnIktatoszam.DataPropertyName = "Iktatoszam";
            this.cnIktatoszam.HeaderText = "Iktatószám";
            this.cnIktatoszam.Name = "cnIktatoszam";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdUser";
            this.dataGridViewTextBoxColumn3.DataSource = this.usersBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nev";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdUser";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id_user";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.iktatDS;
            // 
            // cnDatum
            // 
            this.cnDatum.DataPropertyName = "Datum";
            this.cnDatum.HeaderText = "Dátum";
            this.cnDatum.Name = "cnDatum";
            this.cnDatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cnDatum.ToolTipText = "A levél beérkezésének dátuma";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdTema";
            this.dataGridViewTextBoxColumn5.DataSource = this.temakBindingSource1;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Tema";
            this.dataGridViewTextBoxColumn5.HeaderText = "Levél témája";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Id_Tema";
            // 
            // temakBindingSource1
            // 
            this.temakBindingSource1.DataMember = "Temak";
            this.temakBindingSource1.DataSource = this.iktatDS;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Leiras";
            this.dataGridViewTextBoxColumn6.HeaderText = "Leirás";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "A levél tartalmának részletesebb leírása";
            // 
            // usersDS
            // 
            this.usersDS.DataSetName = "UsersDS";
            this.usersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersDSBindingSource
            // 
            this.usersDSBindingSource.DataSource = this.usersDS;
            this.usersDSBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDS;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // temakBindingSource
            // 
            this.temakBindingSource.DataMember = "Temak";
            this.temakBindingSource.DataSource = this.iktatDS;
            // 
            // IktatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iktatDataGridView);
            this.Controls.Add(this.iktatBindingNavigator);
            this.Name = "IktatForm";
            this.Text = "Iktatás";
            this.Load += new System.EventHandler(this.IktatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iktatDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingNavigator)).EndInit();
            this.iktatBindingNavigator.ResumeLayout(false);
            this.iktatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IktatDS iktatDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private IktatDSTableAdapters.iktatTableAdapter iktatTableAdapter;
        private IktatDSTableAdapters.TableAdapterManager tableAdapterManager;
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
        private UsersDSTableAdapters.UsersTableAdapter usersTableAdapter;
        private IktatDSTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private IktatDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private System.Windows.Forms.BindingSource temakBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIktatoszam;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnDatum;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}