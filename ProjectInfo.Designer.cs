namespace HRD
{
    public partial class ProjectInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RespCombo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DFStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DFEnd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DCreate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DPStart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DPEnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(17, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 702);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RespCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
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
            // RespCombo
            // 
            this.RespCombo.AutoSize = true;
            this.RespCombo.Location = new System.Drawing.Point(8, 44);
            this.RespCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RespCombo.Name = "RespCombo";
            this.RespCombo.Size = new System.Drawing.Size(0, 17);
            this.RespCombo.TabIndex = 12;
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
            this.dataGridView2.Location = new System.Drawing.Point(8, 105);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(956, 276);
            this.dataGridView2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DFStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DFEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DCreate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DPStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DPEnd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(972, 296);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AutoSize = true;
            this.DescriptionTextBox.Location = new System.Drawing.Point(8, 102);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionTextBox.MaximumSize = new System.Drawing.Size(950, 122);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(0, 17);
            this.DescriptionTextBox.TabIndex = 31;
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
            // DFStart
            // 
            this.DFStart.AutoSize = true;
            this.DFStart.Location = new System.Drawing.Point(580, 268);
            this.DFStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DFStart.Name = "DFStart";
            this.DFStart.Size = new System.Drawing.Size(0, 17);
            this.DFStart.TabIndex = 33;
            this.DFStart.Visible = false;
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
            // DFEnd
            // 
            this.DFEnd.AutoSize = true;
            this.DFEnd.Location = new System.Drawing.Point(772, 268);
            this.DFEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DFEnd.Name = "DFEnd";
            this.DFEnd.Size = new System.Drawing.Size(0, 17);
            this.DFEnd.TabIndex = 35;
            this.DFEnd.Visible = false;
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
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(8, 46);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(0, 17);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // DCreate
            // 
            this.DCreate.AutoSize = true;
            this.DCreate.Location = new System.Drawing.Point(377, 46);
            this.DCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCreate.Name = "DCreate";
            this.DCreate.Size = new System.Drawing.Size(0, 17);
            this.DCreate.TabIndex = 10;
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
            // DPStart
            // 
            this.DPStart.AutoSize = true;
            this.DPStart.Location = new System.Drawing.Point(8, 268);
            this.DPStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DPStart.Name = "DPStart";
            this.DPStart.Size = new System.Drawing.Size(0, 17);
            this.DPStart.TabIndex = 6;
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
            // DPEnd
            // 
            this.DPEnd.AutoSize = true;
            this.DPEnd.Location = new System.Drawing.Point(201, 268);
            this.DPEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DPEnd.Name = "DPEnd";
            this.DPEnd.Size = new System.Drawing.Size(0, 17);
            this.DPEnd.TabIndex = 8;
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
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(14, 12);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(56, 17);
            this.mainLable.TabIndex = 34;
            this.mainLable.Text = "Проект";
            // 
            // ProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 769);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectInfo";
            this.Text = "Информация о проекте";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label RespCombo;
        public System.Windows.Forms.Label DescriptionTextBox;
        public System.Windows.Forms.Label DFStart;
        public System.Windows.Forms.Label DFEnd;
        public System.Windows.Forms.Label NameTextBox;
        public System.Windows.Forms.Label DCreate;
        public System.Windows.Forms.Label DPStart;
        public System.Windows.Forms.Label DPEnd;
        public System.Windows.Forms.Label mainLable;
    }
}