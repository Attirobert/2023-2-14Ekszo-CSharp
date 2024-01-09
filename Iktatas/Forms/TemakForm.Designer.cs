
using Iktatas.DataSets;

namespace Iktatas
{
    partial class TemakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemakForm));
            this.temakDS1 = new Iktatas.DataSets.TemakDS();
            this.temakBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.temakTableAdapter1 = new Iktatas.DataSets.TemakDSTableAdapters.TemakTableAdapter();
            this.tableAdapterManager1 = new Iktatas.DataSets.TemakDSTableAdapters.TableAdapterManager();
            this.temakBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.temakBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.temakDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.temakDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource1BindingNavigator)).BeginInit();
            this.temakBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temakDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // temakDS1
            // 
            this.temakDS1.DataSetName = "TemakDS";
            this.temakDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temakBindingSource1
            // 
            this.temakBindingSource1.DataMember = "Temak";
            this.temakBindingSource1.DataSource = this.temakDS1;
            // 
            // temakTableAdapter1
            // 
            this.temakTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TemakTableAdapter = this.temakTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Iktatas.DataSets.TemakDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // temakBindingSource1BindingNavigator
            // 
            this.temakBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.temakBindingSource1BindingNavigator.BindingSource = this.temakBindingSource1;
            this.temakBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.temakBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.temakBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.temakBindingSource1BindingNavigatorSaveItem});
            this.temakBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.temakBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.temakBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.temakBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.temakBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.temakBindingSource1BindingNavigator.Name = "temakBindingSource1BindingNavigator";
            this.temakBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.temakBindingSource1BindingNavigator.Size = new System.Drawing.Size(356, 25);
            this.temakBindingSource1BindingNavigator.TabIndex = 0;
            this.temakBindingSource1BindingNavigator.Text = "bindingNavigator1";
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
            // temakBindingSource1BindingNavigatorSaveItem
            // 
            this.temakBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.temakBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("temakBindingSource1BindingNavigatorSaveItem.Image")));
            this.temakBindingSource1BindingNavigatorSaveItem.Name = "temakBindingSource1BindingNavigatorSaveItem";
            this.temakBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.temakBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.temakBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.temakBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // temakDataGridView1
            // 
            this.temakDataGridView1.AutoGenerateColumns = false;
            this.temakDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temakDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.temakDataGridView1.DataSource = this.temakBindingSource1;
            this.temakDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temakDataGridView1.Location = new System.Drawing.Point(0, 25);
            this.temakDataGridView1.Name = "temakDataGridView1";
            this.temakDataGridView1.Size = new System.Drawing.Size(356, 248);
            this.temakDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Tema";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Tema";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tema";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tema";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // TemakForm
            // 
            this.ClientSize = new System.Drawing.Size(356, 273);
            this.Controls.Add(this.temakDataGridView1);
            this.Controls.Add(this.temakBindingSource1BindingNavigator);
            this.Name = "TemakForm";
            this.Text = "Témák";
            this.Load += new System.EventHandler(this.TemakForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.temakDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource1BindingNavigator)).EndInit();
            this.temakBindingSource1BindingNavigator.ResumeLayout(false);
            this.temakBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temakDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TemakDS temakDS;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private DataSets.TemakDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private DataSets.TemakDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator temakBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton temakBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView temakDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataSets.TemakDS temakDS1;
        private System.Windows.Forms.BindingSource temakBindingSource1;
        private DataSets.TemakDSTableAdapters.TemakTableAdapter temakTableAdapter1;
        private DataSets.TemakDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator temakBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton temakBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView temakDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}