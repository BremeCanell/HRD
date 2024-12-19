namespace HRD
{
    partial class ShowAllProjectForm
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
            this.deleteTeamB = new System.Windows.Forms.Button();
            this.addTeamB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RespCombo = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRD_DBDataSet = new HRD.HRD_DBDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.DCreate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DPEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canselB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.confirmB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hRD_DBDataSet1 = new HRD.HRD_DBDataSet1();
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainLable = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showResponsable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DFEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DFStart = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeTableAdapter = new HRD.HRD_DBDataSetTableAdapters.EmployeeTableAdapter();
            this.projectTableAdapter = new HRD.HRD_DBDataSetTableAdapters.ProjectTableAdapter();
            this.project_EmployeeTableAdapter = new HRD.HRD_DBDataSetTableAdapters.Project_EmployeeTableAdapter();
            this.tableAdapterManager = new HRD.HRD_DBDataSetTableAdapters.TableAdapterManager();
            this.projectEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter1 = new HRD.HRD_DBDataSet1TableAdapters.ProjectTableAdapter();
            this.infoB = new System.Windows.Forms.Button();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.showPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteTeamB
            // 
            this.deleteTeamB.Location = new System.Drawing.Point(926, 140);
            this.deleteTeamB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTeamB.Name = "deleteTeamB";
            this.deleteTeamB.Size = new System.Drawing.Size(33, 28);
            this.deleteTeamB.TabIndex = 29;
            this.deleteTeamB.Text = "-";
            this.deleteTeamB.UseVisualStyleBackColor = true;
            this.deleteTeamB.Click += new System.EventHandler(this.deleteTeamB_Click);
            // 
            // addTeamB
            // 
            this.addTeamB.Location = new System.Drawing.Point(926, 105);
            this.addTeamB.Margin = new System.Windows.Forms.Padding(4);
            this.addTeamB.Name = "addTeamB";
            this.addTeamB.Size = new System.Drawing.Size(33, 28);
            this.addTeamB.TabIndex = 28;
            this.addTeamB.Text = "+";
            this.addTeamB.UseVisualStyleBackColor = true;
            this.addTeamB.Click += new System.EventHandler(this.addTeamB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Команда";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.Post,
            this.Qualification});
            this.dataGridView2.Location = new System.Drawing.Point(8, 105);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(910, 276);
            this.dataGridView2.TabIndex = 14;
            // 
            // RespCombo
            // 
            this.RespCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RespCombo.FormattingEnabled = true;
            this.RespCombo.Location = new System.Drawing.Point(9, 43);
            this.RespCombo.Margin = new System.Windows.Forms.Padding(4);
            this.RespCombo.Name = "RespCombo";
            this.RespCombo.Size = new System.Drawing.Size(339, 24);
            this.RespCombo.TabIndex = 13;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // hRD_DBDataSet
            // 
            this.hRD_DBDataSet.DataSetName = "HRD_DBDataSet";
            this.hRD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ответственный";
            // 
            // DCreate
            // 
            this.DCreate.Location = new System.Drawing.Point(381, 43);
            this.DCreate.Margin = new System.Windows.Forms.Padding(4);
            this.DCreate.Name = "DCreate";
            this.DCreate.Size = new System.Drawing.Size(184, 22);
            this.DCreate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата создания";
            // 
            // DPEnd
            // 
            this.DPEnd.Location = new System.Drawing.Point(205, 263);
            this.DPEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DPEnd.Name = "DPEnd";
            this.DPEnd.Size = new System.Drawing.Size(184, 22);
            this.DPEnd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "План.  дата завершения";
            // 
            // DPStart
            // 
            this.DPStart.Location = new System.Drawing.Point(12, 263);
            this.DPStart.Margin = new System.Windows.Forms.Padding(4);
            this.DPStart.Name = "DPStart";
            this.DPStart.Size = new System.Drawing.Size(184, 22);
            this.DPStart.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "План. дата начала";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(9, 43);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(363, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(862, 741);
            this.canselB.Margin = new System.Windows.Forms.Padding(4);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(133, 28);
            this.canselB.TabIndex = 26;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(1008, 180);
            this.deleteB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(133, 28);
            this.deleteB.TabIndex = 25;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(1008, 72);
            this.changeB.Margin = new System.Windows.Forms.Padding(4);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(133, 28);
            this.changeB.TabIndex = 24;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(1008, 36);
            this.addB.Margin = new System.Windows.Forms.Padding(4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 28);
            this.addB.TabIndex = 23;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(720, 741);
            this.confirmB.Margin = new System.Windows.Forms.Padding(4);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(133, 28);
            this.confirmB.TabIndex = 27;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pr,
            this.nameDataGridViewTextBoxColumn,
            this.desDataGridViewTextBoxColumn,
            this.dCDataGridViewTextBoxColumn,
            this.pDSDataGridViewTextBoxColumn,
            this.pDEDataGridViewTextBoxColumn,
            this.fDSDataGridViewTextBoxColumn,
            this.fDEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(975, 733);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_Pr
            // 
            this.ID_Pr.DataPropertyName = "ID_Pr";
            this.ID_Pr.HeaderText = "ID_Pr";
            this.ID_Pr.MinimumWidth = 6;
            this.ID_Pr.Name = "ID_Pr";
            this.ID_Pr.ReadOnly = true;
            this.ID_Pr.Visible = false;
            this.ID_Pr.Width = 120;
            // 
            // projectBindingSource2
            // 
            this.projectBindingSource2.DataMember = "Project";
            this.projectBindingSource2.DataSource = this.hRD_DBDataSet1;
            // 
            // hRD_DBDataSet1
            // 
            this.hRD_DBDataSet1.DataSetName = "HRD_DBDataSet1";
            this.hRD_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataMember = "Project";
            this.projectBindingSource1.DataSource = this.hRD_DBDataSet;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(15, 11);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(152, 17);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник проектов";
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Location = new System.Drawing.Point(19, 34);
            this.showPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(981, 742);
            this.showPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(18, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 702);
            this.panel1.TabIndex = 32;
            this.panel1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showResponsable);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.addTeamB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.RespCombo);
            this.groupBox2.Controls.Add(this.deleteTeamB);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(4, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(972, 390);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Формирование команды";
            // 
            // showResponsable
            // 
            this.showResponsable.Location = new System.Drawing.Point(356, 40);
            this.showResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.showResponsable.Name = "showResponsable";
            this.showResponsable.Size = new System.Drawing.Size(33, 28);
            this.showResponsable.TabIndex = 33;
            this.showResponsable.Text = "...";
            this.showResponsable.UseVisualStyleBackColor = true;
            this.showResponsable.Click += new System.EventHandler(this.showResponsable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DFEnd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DFStart);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DCreate);
            this.groupBox1.Controls.Add(this.DPEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DPStart);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(972, 296);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            // 
            // DFEnd
            // 
            this.DFEnd.Location = new System.Drawing.Point(775, 263);
            this.DFEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DFEnd.Name = "DFEnd";
            this.DFEnd.ShowCheckBox = true;
            this.DFEnd.Size = new System.Drawing.Size(184, 22);
            this.DFEnd.TabIndex = 36;
            this.DFEnd.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Факт. дата начала";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Факт.  дата завершения";
            this.label3.Visible = false;
            // 
            // DFStart
            // 
            this.DFStart.Location = new System.Drawing.Point(583, 263);
            this.DFStart.Margin = new System.Windows.Forms.Padding(4);
            this.DFStart.Name = "DFStart";
            this.DFStart.ShowCheckBox = true;
            this.DFStart.Size = new System.Drawing.Size(184, 22);
            this.DFStart.TabIndex = 34;
            this.DFStart.Visible = false;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(9, 102);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(950, 122);
            this.DescriptionTextBox.TabIndex = 30;
            this.DescriptionTextBox.Text = "";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // project_EmployeeTableAdapter
            // 
            this.project_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employee_SkillTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.Project_EmployeeTableAdapter = this.project_EmployeeTableAdapter;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.QualificationTableAdapter = null;
            this.tableAdapterManager.SkillTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HRD.HRD_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectEmployeeBindingSource
            // 
            this.projectEmployeeBindingSource.DataMember = "Project_Employee";
            this.projectEmployeeBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // hRDDBDataSetBindingSource
            // 
            this.hRDDBDataSetBindingSource.DataSource = this.hRD_DBDataSet;
            this.hRDDBDataSetBindingSource.Position = 0;
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // infoB
            // 
            this.infoB.Location = new System.Drawing.Point(1008, 108);
            this.infoB.Margin = new System.Windows.Forms.Padding(4);
            this.infoB.Name = "infoB";
            this.infoB.Size = new System.Drawing.Size(133, 28);
            this.infoB.TabIndex = 33;
            this.infoB.Text = "Подробнее";
            this.infoB.UseVisualStyleBackColor = true;
            this.infoB.Click += new System.EventHandler(this.InfoB_Click);
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Уровень";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 150;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.MinimumWidth = 6;
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 250;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 150;
            // 
            // fDEDataGridViewTextBoxColumn
            // 
            this.fDEDataGridViewTextBoxColumn.DataPropertyName = "FDE";
            this.fDEDataGridViewTextBoxColumn.HeaderText = "Дата окончания (Факт)";
            this.fDEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fDEDataGridViewTextBoxColumn.Name = "fDEDataGridViewTextBoxColumn";
            this.fDEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDEDataGridViewTextBoxColumn.Width = 120;
            // 
            // fDSDataGridViewTextBoxColumn
            // 
            this.fDSDataGridViewTextBoxColumn.DataPropertyName = "FDS";
            this.fDSDataGridViewTextBoxColumn.HeaderText = "Дата начала (Факт)";
            this.fDSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fDSDataGridViewTextBoxColumn.Name = "fDSDataGridViewTextBoxColumn";
            this.fDSDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDSDataGridViewTextBoxColumn.Width = 120;
            // 
            // pDEDataGridViewTextBoxColumn
            // 
            this.pDEDataGridViewTextBoxColumn.DataPropertyName = "PDE";
            this.pDEDataGridViewTextBoxColumn.HeaderText = "Дата окончания (План)";
            this.pDEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pDEDataGridViewTextBoxColumn.Name = "pDEDataGridViewTextBoxColumn";
            this.pDEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDEDataGridViewTextBoxColumn.Width = 120;
            // 
            // pDSDataGridViewTextBoxColumn
            // 
            this.pDSDataGridViewTextBoxColumn.DataPropertyName = "PDS";
            this.pDSDataGridViewTextBoxColumn.HeaderText = "Дата начала (План)";
            this.pDSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pDSDataGridViewTextBoxColumn.Name = "pDSDataGridViewTextBoxColumn";
            this.pDSDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDSDataGridViewTextBoxColumn.Width = 120;
            // 
            // dCDataGridViewTextBoxColumn
            // 
            this.dCDataGridViewTextBoxColumn.DataPropertyName = "DC";
            this.dCDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.dCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dCDataGridViewTextBoxColumn.Name = "dCDataGridViewTextBoxColumn";
            this.dCDataGridViewTextBoxColumn.ReadOnly = true;
            this.dCDataGridViewTextBoxColumn.Width = 120;
            // 
            // desDataGridViewTextBoxColumn
            // 
            this.desDataGridViewTextBoxColumn.DataPropertyName = "Des";
            this.desDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.desDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desDataGridViewTextBoxColumn.Name = "desDataGridViewTextBoxColumn";
            this.desDataGridViewTextBoxColumn.ReadOnly = true;
            this.desDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // ShowAllProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 787);
            this.Controls.Add(this.infoB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.showPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ShowAllProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.ShowAllProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.showPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DPEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DPStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RespCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button deleteTeamB;
        private System.Windows.Forms.Button addTeamB;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showResponsable;
        private System.Windows.Forms.DateTimePicker DFEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DFStart;
        private HRD_DBDataSet hRD_DBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HRD_DBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private HRD_DBDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private HRD_DBDataSetTableAdapters.Project_EmployeeTableAdapter project_EmployeeTableAdapter;
        private HRD_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource hRDDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource projectEmployeeBindingSource;
        private HRD_DBDataSet1 hRD_DBDataSet1;
        private System.Windows.Forms.BindingSource projectBindingSource2;
        private HRD_DBDataSet1TableAdapters.ProjectTableAdapter projectTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pr;
        private System.Windows.Forms.Button infoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDEDataGridViewTextBoxColumn;
    }
}