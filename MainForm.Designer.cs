namespace HRD
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.PostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportWorkloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportOverdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportExperienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainLable = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkQualificationB = new System.Windows.Forms.Button();
            this.checkPostB = new System.Windows.Forms.Button();
            this.deleteSkillB = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSkillB = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuideToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1345, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GuideToolStripMenuItem
            // 
            this.GuideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectToolStripMenuItem,
            this.EmployeeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.PostToolStripMenuItem,
            this.QualificationToolStripMenuItem,
            this.SkillToolStripMenuItem});
            this.GuideToolStripMenuItem.Name = "GuideToolStripMenuItem";
            this.GuideToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.GuideToolStripMenuItem.Text = "Справочники";
            // 
            // ProjectToolStripMenuItem
            // 
            this.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem";
            this.ProjectToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.ProjectToolStripMenuItem.Text = "Проекты";
            this.ProjectToolStripMenuItem.Click += new System.EventHandler(this.ProjectToolStripMenuItem_Click);
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.EmployeeToolStripMenuItem.Text = "Сотрудники";
            this.EmployeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(246, 6);
            // 
            // PostToolStripMenuItem
            // 
            this.PostToolStripMenuItem.Name = "PostToolStripMenuItem";
            this.PostToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.PostToolStripMenuItem.Text = "Должности";
            this.PostToolStripMenuItem.Click += new System.EventHandler(this.PostToolStripMenuItem_Click);
            // 
            // QualificationToolStripMenuItem
            // 
            this.QualificationToolStripMenuItem.Name = "QualificationToolStripMenuItem";
            this.QualificationToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.QualificationToolStripMenuItem.Text = "Уровни квалификации";
            this.QualificationToolStripMenuItem.Click += new System.EventHandler(this.QualificationToolStripMenuItem_Click);
            // 
            // SkillToolStripMenuItem
            // 
            this.SkillToolStripMenuItem.Name = "SkillToolStripMenuItem";
            this.SkillToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.SkillToolStripMenuItem.Text = "Навыки";
            this.SkillToolStripMenuItem.Click += new System.EventHandler(this.SkillToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportWorkloadToolStripMenuItem,
            this.ReportOverdueToolStripMenuItem,
            this.ReportExperienceToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.reportToolStripMenuItem.Text = "Отчет";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // ReportWorkloadToolStripMenuItem
            // 
            this.ReportWorkloadToolStripMenuItem.Name = "ReportWorkloadToolStripMenuItem";
            this.ReportWorkloadToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.ReportWorkloadToolStripMenuItem.Text = "Отчет \"Загруженность сотрудников\"";
            this.ReportWorkloadToolStripMenuItem.Click += new System.EventHandler(this.ReportWorkloadToolStripMenuItem_Click);
            // 
            // ReportOverdueToolStripMenuItem
            // 
            this.ReportOverdueToolStripMenuItem.Name = "ReportOverdueToolStripMenuItem";
            this.ReportOverdueToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.ReportOverdueToolStripMenuItem.Text = "Отчет \"Просроченные проекты\"";
            this.ReportOverdueToolStripMenuItem.Click += new System.EventHandler(this.ReportOverdueToolStripMenuItem_Click);
            // 
            // ReportExperienceToolStripMenuItem
            // 
            this.ReportExperienceToolStripMenuItem.Name = "ReportExperienceToolStripMenuItem";
            this.ReportExperienceToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.ReportExperienceToolStripMenuItem.Text = "Отчет \"Опытность сотрудников\"";
            this.ReportExperienceToolStripMenuItem.Click += new System.EventHandler(this.ReportExperienceToolStripMenuItem_Click);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Controls.Add(this.mainLable);
            this.showPanel.Controls.Add(this.panelAdd);
            this.showPanel.Location = new System.Drawing.Point(15, 32);
            this.showPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1319, 508);
            this.showPanel.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1312, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(3, 2);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(177, 17);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Незавершенные проекты";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.groupBox4);
            this.panelAdd.Controls.Add(this.groupBox6);
            this.panelAdd.Controls.Add(this.groupBox5);
            this.panelAdd.Location = new System.Drawing.Point(44, 55);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(957, 709);
            this.panelAdd.TabIndex = 14;
            this.panelAdd.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkQualificationB);
            this.groupBox4.Controls.Add(this.checkPostB);
            this.groupBox4.Controls.Add(this.deleteSkillB);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.addSkillB);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(3, 305);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(949, 297);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Положение в компании";
            // 
            // checkQualificationB
            // 
            this.checkQualificationB.Location = new System.Drawing.Point(905, 43);
            this.checkQualificationB.Margin = new System.Windows.Forms.Padding(4);
            this.checkQualificationB.Name = "checkQualificationB";
            this.checkQualificationB.Size = new System.Drawing.Size(33, 28);
            this.checkQualificationB.TabIndex = 24;
            this.checkQualificationB.Text = "...";
            this.checkQualificationB.UseVisualStyleBackColor = true;
            // 
            // checkPostB
            // 
            this.checkPostB.Location = new System.Drawing.Point(524, 43);
            this.checkPostB.Margin = new System.Windows.Forms.Padding(4);
            this.checkPostB.Name = "checkPostB";
            this.checkPostB.Size = new System.Drawing.Size(33, 28);
            this.checkPostB.TabIndex = 23;
            this.checkPostB.Text = "...";
            this.checkPostB.UseVisualStyleBackColor = true;
            // 
            // deleteSkillB
            // 
            this.deleteSkillB.Location = new System.Drawing.Point(775, 148);
            this.deleteSkillB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSkillB.Name = "deleteSkillB";
            this.deleteSkillB.Size = new System.Drawing.Size(133, 28);
            this.deleteSkillB.TabIndex = 22;
            this.deleteSkillB.Text = "-";
            this.deleteSkillB.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillName,
            this.SkillLevel});
            this.dataGridView2.Location = new System.Drawing.Point(12, 112);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(755, 178);
            this.dataGridView2.TabIndex = 16;
            // 
            // SkillName
            // 
            this.SkillName.HeaderText = "Наименование";
            this.SkillName.MinimumWidth = 6;
            this.SkillName.Name = "SkillName";
            this.SkillName.Width = 320;
            // 
            // SkillLevel
            // 
            this.SkillLevel.HeaderText = "Уровень владения";
            this.SkillLevel.MinimumWidth = 6;
            this.SkillLevel.Name = "SkillLevel";
            this.SkillLevel.Width = 200;
            // 
            // addSkillB
            // 
            this.addSkillB.Location = new System.Drawing.Point(775, 112);
            this.addSkillB.Margin = new System.Windows.Forms.Padding(4);
            this.addSkillB.Name = "addSkillB";
            this.addSkillB.Size = new System.Drawing.Size(133, 28);
            this.addSkillB.TabIndex = 21;
            this.addSkillB.Text = "+";
            this.addSkillB.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Навыки";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(564, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 46);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(504, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Уровень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Должность";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox10);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBox9);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Location = new System.Drawing.Point(5, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(947, 297);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Паспортные данные";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(141, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Номер паспорта";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(372, 49);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(215, 22);
            this.textBox11.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Кем выдан";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(279, 113);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(499, 22);
            this.textBox6.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Отчество";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(784, 113);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Фамилия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(780, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Когда выдан";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 49);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(215, 22);
            this.textBox10.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(593, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Серия паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата рождения";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(145, 113);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(127, 22);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 113);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(127, 22);
            this.textBox8.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 244);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(923, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Место  регистрации";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 180);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(923, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Место проживания";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Имя";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(233, 49);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 22);
            this.textBox7.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(3, 607);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(949, 98);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Контактные данные";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Телеграм";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 46);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 46);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер телефона";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 556);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillToolStripMenuItem;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button checkQualificationB;
        private System.Windows.Forms.Button checkPostB;
        private System.Windows.Forms.Button deleteSkillB;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillLevel;
        private System.Windows.Forms.Button addSkillB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ReportWorkloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportOverdueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportExperienceToolStripMenuItem;
    }
}