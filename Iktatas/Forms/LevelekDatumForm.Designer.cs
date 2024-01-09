
namespace Iktatas.Forms
{
    partial class LevelekDatumForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.levelekDatumDS = new Iktatas.DataSets.LevelekDatumDS();
            this.iktatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iktatTableAdapter = new Iktatas.DataSets.LevelekDatumDSTableAdapters.iktatTableAdapter();
            this.tableAdapterManager = new Iktatas.DataSets.LevelekDatumDSTableAdapters.TableAdapterManager();
            this.iktatDataGridView = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Iktatas.DataSets.LevelekDatumDSTableAdapters.UsersTableAdapter();
            this.temakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temakTableAdapter = new Iktatas.DataSets.LevelekDatumDSTableAdapters.TemakTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelekDatumDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iktatDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 398);
            this.panel2.TabIndex = 1;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(286, 13);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 0;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // levelekDatumDS
            // 
            this.levelekDatumDS.DataSetName = "LevelekDatumDS";
            this.levelekDatumDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iktatBindingSource
            // 
            this.iktatBindingSource.DataMember = "iktat";
            this.iktatBindingSource.DataSource = this.levelekDatumDS;
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
            this.tableAdapterManager.UpdateOrder = Iktatas.DataSets.LevelekDatumDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // iktatDataGridView
            // 
            this.iktatDataGridView.AutoGenerateColumns = false;
            this.iktatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iktatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iktatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.iktatDataGridView.DataSource = this.iktatBindingSource;
            this.iktatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iktatDataGridView.Location = new System.Drawing.Point(0, 0);
            this.iktatDataGridView.Name = "iktatDataGridView";
            this.iktatDataGridView.Size = new System.Drawing.Size(800, 398);
            this.iktatDataGridView.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.levelekDatumDS;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // temakBindingSource
            // 
            this.temakBindingSource.DataMember = "Temak";
            this.temakBindingSource.DataSource = this.levelekDatumDS;
            // 
            // temakTableAdapter
            // 
            this.temakTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_iktat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Azonosító";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Iktatoszam";
            this.dataGridViewTextBoxColumn2.HeaderText = "Iktatószám";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdUser";
            this.dataGridViewTextBoxColumn3.DataSource = this.usersBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nev";
            this.dataGridViewTextBoxColumn3.HeaderText = "Címzett";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ToolTipText = "A címzett teljes neve";
            this.dataGridViewTextBoxColumn3.ValueMember = "Id_user";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dátum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdTema";
            this.dataGridViewTextBoxColumn5.DataSource = this.temakBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Tema";
            this.dataGridViewTextBoxColumn5.HeaderText = "Téma";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Id_Tema";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Leiras";
            this.dataGridViewTextBoxColumn6.HeaderText = "Leírás";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // LevelekDatumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LevelekDatumForm";
            this.Text = "Levelek szűrése naptárral";
            this.Load += new System.EventHandler(this.LevelekDatumForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelekDatumDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Panel panel2;
        private DataSets.LevelekDatumDS levelekDatumDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private DataSets.LevelekDatumDSTableAdapters.iktatTableAdapter iktatTableAdapter;
        private DataSets.LevelekDatumDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView iktatDataGridView;
        private DataSets.LevelekDatumDSTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSets.LevelekDatumDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}