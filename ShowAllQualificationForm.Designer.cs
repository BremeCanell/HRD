namespace HRD
{
    partial class ShowAllQualificationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDQualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hRD_DBDataSet1 = new HRD.HRD_DBDataSet1();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRD_DBDataSet = new HRD.HRD_DBDataSet();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.showPanel = new System.Windows.Forms.Panel();
            this.mainLable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.canselB = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.confirmB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qualificationTableAdapter = new HRD.HRD_DBDataSetTableAdapters.QualificationTableAdapter();
            this.qualificationTableAdapter1 = new HRD.HRD_DBDataSet1TableAdapters.QualificationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).BeginInit();
            this.showPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDQualDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.coefDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qualificationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(418, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDQualDataGridViewTextBoxColumn
            // 
            this.iDQualDataGridViewTextBoxColumn.DataPropertyName = "ID_Qual";
            this.iDQualDataGridViewTextBoxColumn.HeaderText = "ID_Qual";
            this.iDQualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDQualDataGridViewTextBoxColumn.Name = "iDQualDataGridViewTextBoxColumn";
            this.iDQualDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDQualDataGridViewTextBoxColumn.Visible = false;
            this.iDQualDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // coefDataGridViewTextBoxColumn
            // 
            this.coefDataGridViewTextBoxColumn.DataPropertyName = "Coef";
            this.coefDataGridViewTextBoxColumn.HeaderText = "Коэффициент";
            this.coefDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coefDataGridViewTextBoxColumn.Name = "coefDataGridViewTextBoxColumn";
            this.coefDataGridViewTextBoxColumn.ReadOnly = true;
            this.coefDataGridViewTextBoxColumn.Width = 120;
            // 
            // qualificationBindingSource1
            // 
            this.qualificationBindingSource1.DataMember = "Qualification";
            this.qualificationBindingSource1.DataSource = this.hRD_DBDataSet1;
            // 
            // hRD_DBDataSet1
            // 
            this.hRD_DBDataSet1.DataSetName = "HRD_DBDataSet1";
            this.hRD_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataMember = "Qualification";
            this.qualificationBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // hRD_DBDataSet
            // 
            this.hRD_DBDataSet.DataSetName = "HRD_DBDataSet";
            this.hRD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(448, 138);
            this.deleteB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(133, 28);
            this.deleteB.TabIndex = 33;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(448, 66);
            this.changeB.Margin = new System.Windows.Forms.Padding(4);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(133, 28);
            this.changeB.TabIndex = 32;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(448, 31);
            this.addB.Margin = new System.Windows.Forms.Padding(4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 28);
            this.addB.TabIndex = 31;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Location = new System.Drawing.Point(19, 31);
            this.showPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(422, 476);
            this.showPanel.TabIndex = 29;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(15, 11);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(245, 17);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник уровней квалификации";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Наименование";
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(308, 174);
            this.canselB.Margin = new System.Windows.Forms.Padding(4);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(133, 28);
            this.canselB.TabIndex = 34;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(9, 43);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(400, 22);
            this.textBox10.TabIndex = 16;
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(167, 174);
            this.confirmB.Margin = new System.Windows.Forms.Padding(4);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(133, 28);
            this.confirmB.TabIndex = 35;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Коэффициент";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(421, 135);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            this.groupBox1.Visible = false;
            // 
            // qualificationTableAdapter
            // 
            this.qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationTableAdapter1
            // 
            this.qualificationTableAdapter1.ClearBeforeFill = true;
            // 
            // ShowAllQualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.confirmB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ShowAllQualificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровни квалификации";
            this.Load += new System.EventHandler(this.ShowAllQualificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).EndInit();
            this.showPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private HRD_DBDataSet hRD_DBDataSet;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private HRD_DBDataSetTableAdapters.QualificationTableAdapter qualificationTableAdapter;
        private HRD_DBDataSet1 hRD_DBDataSet1;
        private System.Windows.Forms.BindingSource qualificationBindingSource1;
        private HRD_DBDataSet1TableAdapters.QualificationTableAdapter qualificationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDQualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefDataGridViewTextBoxColumn;
    }
}