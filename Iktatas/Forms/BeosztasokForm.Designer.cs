
using Iktatas.DataSets;

namespace Iktatas
{
    partial class BeosztasokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeosztasokForm));
            this.beosztasokDS1 = new Iktatas.DataSets.BeosztasokDS();
            this.beosztasokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.beosztasokTableAdapter1 = new Iktatas.DataSets.BeosztasokDSTableAdapters.BeosztasokTableAdapter();
            this.tableAdapterManager1 = new Iktatas.DataSets.BeosztasokDSTableAdapters.TableAdapterManager();
            this.beosztasokBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.beosztasokBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.beosztasokDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokBindingSource1BindingNavigator)).BeginInit();
            this.beosztasokBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // beosztasokDS1
            // 
            this.beosztasokDS1.DataSetName = "BeosztasokDS";
            this.beosztasokDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beosztasokBindingSource1
            // 
            this.beosztasokBindingSource1.DataMember = "Beosztasok";
            this.beosztasokBindingSource1.DataSource = this.beosztasokDS1;
            // 
            // beosztasokTableAdapter1
            // 
            this.beosztasokTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BeosztasokTableAdapter = this.beosztasokTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Iktatas.DataSets.BeosztasokDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // beosztasokBindingSource1BindingNavigator
            // 
            this.beosztasokBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.beosztasokBindingSource1BindingNavigator.BindingSource = this.beosztasokBindingSource1;
            this.beosztasokBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.beosztasokBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.beosztasokBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.beosztasokBindingSource1BindingNavigatorSaveItem});
            this.beosztasokBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.beosztasokBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.beosztasokBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.beosztasokBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.beosztasokBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.beosztasokBindingSource1BindingNavigator.Name = "beosztasokBindingSource1BindingNavigator";
            this.beosztasokBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.beosztasokBindingSource1BindingNavigator.Size = new System.Drawing.Size(343, 25);
            this.beosztasokBindingSource1BindingNavigator.TabIndex = 0;
            this.beosztasokBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 15);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton6.Text = "Delete";
            // 
            // beosztasokBindingSource1BindingNavigatorSaveItem
            // 
            this.beosztasokBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.beosztasokBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("beosztasokBindingSource1BindingNavigatorSaveItem.Image")));
            this.beosztasokBindingSource1BindingNavigatorSaveItem.Name = "beosztasokBindingSource1BindingNavigatorSaveItem";
            this.beosztasokBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.beosztasokBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.beosztasokBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.beosztasokBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // beosztasokDataGridView1
            // 
            this.beosztasokDataGridView1.AutoGenerateColumns = false;
            this.beosztasokDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beosztasokDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.beosztasokDataGridView1.DataSource = this.beosztasokBindingSource1;
            this.beosztasokDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beosztasokDataGridView1.Location = new System.Drawing.Point(0, 25);
            this.beosztasokDataGridView1.Name = "beosztasokDataGridView1";
            this.beosztasokDataGridView1.Size = new System.Drawing.Size(343, 249);
            this.beosztasokDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Beosztas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Beosztas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Beosztas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Beosztas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // BeosztasokForm
            // 
            this.ClientSize = new System.Drawing.Size(343, 274);
            this.Controls.Add(this.beosztasokDataGridView1);
            this.Controls.Add(this.beosztasokBindingSource1BindingNavigator);
            this.Name = "BeosztasokForm";
            this.Text = "Beosztások";
            this.Load += new System.EventHandler(this.BeosztasokForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokBindingSource1BindingNavigator)).EndInit();
            this.beosztasokBindingSource1BindingNavigator.ResumeLayout(false);
            this.beosztasokBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeosztasokDS beosztasokDS;
        private System.Windows.Forms.BindingSource beosztasokBindingSource;
        private DataSets.BeosztasokDSTableAdapters.BeosztasokTableAdapter beosztasokTableAdapter;
        private DataSets.BeosztasokDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator beosztasokBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton beosztasokBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView beosztasokDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataSets.BeosztasokDS beosztasokDS1;
        private System.Windows.Forms.BindingSource beosztasokBindingSource1;
        private DataSets.BeosztasokDSTableAdapters.BeosztasokTableAdapter beosztasokTableAdapter1;
        private DataSets.BeosztasokDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator beosztasokBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton beosztasokBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView beosztasokDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}