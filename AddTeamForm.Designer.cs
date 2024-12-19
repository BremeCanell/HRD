namespace HRD
{
    partial class AddTeamForm
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
            this.confirmB = new System.Windows.Forms.Button();
            this.canselB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasspotSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.When = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telergam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(1231, 432);
            this.confirmB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(133, 28);
            this.confirmB.TabIndex = 35;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(1372, 432);
            this.canselB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(133, 28);
            this.canselB.TabIndex = 34;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Справочник сотрудников";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.PasspotSeries,
            this.PassportNumber,
            this.BirthDate,
            this.Who,
            this.When,
            this.Residence,
            this.Registration,
            this.Email,
            this.Telergam,
            this.PhoneNumber,
            this.Post,
            this.Salary,
            this.Qualification,
            this.Wages});
            this.dataGridView1.Location = new System.Drawing.Point(20, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1487, 396);
            this.dataGridView1.TabIndex = 36;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 75;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 50;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 75;
            // 
            // PasspotSeries
            // 
            this.PasspotSeries.HeaderText = "Серия паспорта";
            this.PasspotSeries.MinimumWidth = 6;
            this.PasspotSeries.Name = "PasspotSeries";
            this.PasspotSeries.ReadOnly = true;
            this.PasspotSeries.Width = 75;
            // 
            // PassportNumber
            // 
            this.PassportNumber.HeaderText = "Номер паспорта";
            this.PassportNumber.MinimumWidth = 6;
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.ReadOnly = true;
            this.PassportNumber.Width = 75;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 75;
            // 
            // Who
            // 
            this.Who.HeaderText = "Кем выдан";
            this.Who.MinimumWidth = 6;
            this.Who.Name = "Who";
            this.Who.ReadOnly = true;
            this.Who.Width = 125;
            // 
            // When
            // 
            this.When.HeaderText = "Когда выдан";
            this.When.MinimumWidth = 6;
            this.When.Name = "When";
            this.When.ReadOnly = true;
            this.When.Width = 125;
            // 
            // Residence
            // 
            this.Residence.HeaderText = "Место проживания";
            this.Residence.MinimumWidth = 6;
            this.Residence.Name = "Residence";
            this.Residence.ReadOnly = true;
            this.Residence.Width = 125;
            // 
            // Registration
            // 
            this.Registration.HeaderText = "Место регистрации";
            this.Registration.MinimumWidth = 6;
            this.Registration.Name = "Registration";
            this.Registration.ReadOnly = true;
            this.Registration.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 75;
            // 
            // Telergam
            // 
            this.Telergam.HeaderText = "Телеграм";
            this.Telergam.MinimumWidth = 6;
            this.Telergam.Name = "Telergam";
            this.Telergam.ReadOnly = true;
            this.Telergam.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Телефон";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 75;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.MinimumWidth = 6;
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 75;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Оклад";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 75;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Уровень";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 125;
            // 
            // Wages
            // 
            this.Wages.HeaderText = "Заработная плата";
            this.Wages.MinimumWidth = 6;
            this.Wages.Name = "Wages";
            this.Wages.ReadOnly = true;
            this.Wages.Width = 75;
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление члена команды";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasspotSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Who;
        private System.Windows.Forms.DataGridViewTextBoxColumn When;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telergam;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wages;
    }
}