namespace HRD
{
    partial class ShowAllSkillForm
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
            this.confirmB = new System.Windows.Forms.Button();
            this.canselB = new System.Windows.Forms.Button();
            this.showPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSkillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRD_DBDataSet = new HRD.HRD_DBDataSet();
            this.mainLable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skillTableAdapter = new HRD.HRD_DBDataSetTableAdapters.SkillTableAdapter();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(165, 177);
            this.confirmB.Margin = new System.Windows.Forms.Padding(4);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(133, 28);
            this.confirmB.TabIndex = 34;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(306, 177);
            this.canselB.Margin = new System.Windows.Forms.Padding(4);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(133, 28);
            this.canselB.TabIndex = 33;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Location = new System.Drawing.Point(19, 34);
            this.showPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(420, 481);
            this.showPanel.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSkillDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skillBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDSkillDataGridViewTextBoxColumn
            // 
            this.iDSkillDataGridViewTextBoxColumn.DataPropertyName = "ID_Skill";
            this.iDSkillDataGridViewTextBoxColumn.HeaderText = "ID_Skill";
            this.iDSkillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSkillDataGridViewTextBoxColumn.Name = "iDSkillDataGridViewTextBoxColumn";
            this.iDSkillDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSkillDataGridViewTextBoxColumn.Visible = false;
            this.iDSkillDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // skillBindingSource
            // 
            this.skillBindingSource.DataMember = "Skill";
            this.skillBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // hRD_DBDataSet
            // 
            this.hRD_DBDataSet.DataSetName = "HRD_DBDataSet";
            this.hRD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(15, 11);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(146, 17);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник навыков";
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
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(9, 43);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(400, 22);
            this.textBox10.TabIndex = 16;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(446, 141);
            this.deleteB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(133, 28);
            this.deleteB.TabIndex = 32;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(446, 69);
            this.changeB.Margin = new System.Windows.Forms.Padding(4);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(133, 28);
            this.changeB.TabIndex = 31;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(446, 33);
            this.addB.Margin = new System.Windows.Forms.Padding(4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 28);
            this.addB.TabIndex = 30;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Location = new System.Drawing.Point(19, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(419, 135);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            this.groupBox1.Visible = false;
            // 
            // skillTableAdapter
            // 
            this.skillTableAdapter.ClearBeforeFill = true;
            // 
            // ShowAllSkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ShowAllSkillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Навыки";
            this.Load += new System.EventHandler(this.ShowAllSkillForm_Load);
            this.showPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.GroupBox groupBox1;
        private HRD_DBDataSet hRD_DBDataSet;
        private System.Windows.Forms.BindingSource skillBindingSource;
        private HRD_DBDataSetTableAdapters.SkillTableAdapter skillTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSkillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}