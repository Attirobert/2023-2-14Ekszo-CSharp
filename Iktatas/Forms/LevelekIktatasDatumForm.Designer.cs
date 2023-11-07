
namespace Iktatas.Forms
{
    partial class LevelekIktatasDatumForm
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
            System.Windows.Forms.Label datumLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.datumComboBox = new System.Windows.Forms.ComboBox();
            this.iktatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelekIktatasDatumDS = new Iktatas.DataSets.LevelekIktatasDatumDS();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iktatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.temakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iktatTableAdapter = new Iktatas.DataSets.LevelekIktatasDatumDSTableAdapters.iktatTableAdapter();
            this.tableAdapterManager = new Iktatas.DataSets.LevelekIktatasDatumDSTableAdapters.TableAdapterManager();
            this.temakTableAdapter = new Iktatas.DataSets.LevelekIktatasDatumDSTableAdapters.TemakTableAdapter();
            this.usersTableAdapter = new Iktatas.DataSets.LevelekIktatasDatumDSTableAdapters.UsersTableAdapter();
            this.iktatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            datumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelekIktatasDatumDS)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(297, 25);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 0;
            datumLabel.Text = "Datum:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(datumLabel);
            this.panel1.Controls.Add(this.datumComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 0;
            // 
            // datumComboBox
            // 
            this.datumComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Datum", true));
            this.datumComboBox.DataSource = this.iktatBindingSource1;
            this.datumComboBox.DisplayMember = "Datum";
            this.datumComboBox.FormattingEnabled = true;
            this.datumComboBox.Location = new System.Drawing.Point(344, 22);
            this.datumComboBox.Name = "datumComboBox";
            this.datumComboBox.Size = new System.Drawing.Size(180, 21);
            this.datumComboBox.TabIndex = 1;
            this.datumComboBox.ValueMember = "Id_iktat";
            this.datumComboBox.SelectedIndexChanged += new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
            // 
            // iktatBindingSource
            // 
            this.iktatBindingSource.DataMember = "iktat";
            this.iktatBindingSource.DataSource = this.levelekIktatasDatumDS;
            // 
            // levelekIktatasDatumDS
            // 
            this.levelekIktatasDatumDS.DataSetName = "LevelekIktatasDatumDS";
            this.levelekIktatasDatumDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iktatDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 385);
            this.panel2.TabIndex = 1;
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
            this.iktatDataGridView.Size = new System.Drawing.Size(800, 385);
            this.iktatDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn3.ValueMember = "Id_user";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.levelekIktatasDatumDS;
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
            // temakBindingSource
            // 
            this.temakBindingSource.DataMember = "Temak";
            this.temakBindingSource.DataSource = this.levelekIktatasDatumDS;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Leiras";
            this.dataGridViewTextBoxColumn6.HeaderText = "Leírás";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            this.tableAdapterManager.UpdateOrder = Iktatas.DataSets.LevelekIktatasDatumDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // temakTableAdapter
            // 
            this.temakTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // iktatBindingSource1
            // 
            this.iktatBindingSource1.DataMember = "iktat";
            this.iktatBindingSource1.DataSource = this.levelekIktatasDatumDS;
            // 
            // LevelekIktatasDatumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LevelekIktatasDatumForm";
            this.Text = "Levelek szűrése Iktatási dátum szerint";
            this.Load += new System.EventHandler(this.LevelekIktatasDatumForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelekIktatasDatumDS)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DataSets.LevelekIktatasDatumDS levelekIktatasDatumDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private DataSets.LevelekIktatasDatumDSTableAdapters.iktatTableAdapter iktatTableAdapter;
        private DataSets.LevelekIktatasDatumDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView iktatDataGridView;
        private DataSets.LevelekIktatasDatumDSTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSets.LevelekIktatasDatumDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox datumComboBox;
        private System.Windows.Forms.BindingSource iktatBindingSource1;
    }
}