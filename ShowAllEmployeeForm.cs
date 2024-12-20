using Spire.Doc.Fields;
using Spire.Doc.Fields.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRD
{
    public partial class ShowAllEmployeeForm : Form
    {
        public delegate void EmployeeSelectedHandler(Employee employee);
        public event EmployeeSelectedHandler OnEmployeeSelected;
        public delegate void EmployeeUpdatedHandler(Employee employee);
        public event EmployeeUpdatedHandler OnEmployeeUpdated;
        public delegate void EmployeeDeletedHandler(string employeeId);
        public event EmployeeDeletedHandler OnEmployeeDeleted;
        public delegate void EmployeeListChangedHandler();
        public event EmployeeListChangedHandler OnEmployeeListChanged;
        public ShowAllEmployeeForm()
        {
            InitializeComponent();
            this.Size = new Size(861, 770);
        }
        private bool addMode = true;
        private List<Skill> employeeSkills = new List<Skill>();
        public Employee selectedEmployee = null;
        public string selectedResponsable = "";
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=DESKTOP-FPP7TIE;Initial Catalog=HRD_DB;Trusted_Connection=True";
        string id_e = "";
        private void ShowAllEmployeeForm_Load(object sender, EventArgs e)
        {
            // Загружаем данные напрямую из базы данных
            UpdateEmployeeTable();

            // Если форма открывается для выбора сотрудника (checkTeam или checkResponsable),
            // обновляем комбобоксы
            if (this.Tag != null && (this.Tag.ToString() == "checkTeam" || this.Tag.ToString() == "checkResponsable"))
            {
                UpdateComboBoxes();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private void addB_Click(object sender, EventArgs e)
        {
            TurnAddMode();
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            
            TurnChangeMode();
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Employee WHERE ID_Emp=" + id_e;
                Sq(sql);
                OnEmployeeDeleted?.Invoke(id_e);
            }
        }

        private void addSkillB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() == null)
            {
                ShowAllSkillForm showAllSkillForm = new ShowAllSkillForm();
                showAllSkillForm.Tag = "checkSkill";
                showAllSkillForm.OnSkillSelected += (skill) => {
                    var existingSkill = employeeSkills.FirstOrDefault(x => x.skillId == skill.skillId);
                    if (existingSkill != null)
                    {
                        var index = employeeSkills.IndexOf(existingSkill);
                        employeeSkills[index] = skill;
                    }
                    else
                    {
                        employeeSkills.Add(skill);
                    }
                };
                showAllSkillForm.OnSkillUpdated += (skill) =>
                {
                    var existingSkill = employeeSkills.FirstOrDefault(x => x.skillId == skill.skillId);
                    if (existingSkill != null)
                    {
                        existingSkill.skillName = skill.skillName;
                    }
                };
                showAllSkillForm.OnSkillDeleted += (skillId) =>
                {
                    employeeSkills.RemoveAll(x => x.skillId == skillId);
                };
                showAllSkillForm.ShowDialog();
                //employeeSkills = employeeSkills.Where(existingSkill => !showAllSkillForm.deletedSkills.Contains(existingSkill)).ToList();
                UpdateSkillTable();
            }
        }
        private void UpdateSkillTable()
        {

            dataGridView2.Rows.Clear();

            foreach (var skill in employeeSkills)
            {
                dataGridView2.Rows.Add(skill.skillId, skill.skillName, skill.skillLevel);
            }
        }
        private void deleteSkillB_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                employeeSkills.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
        

        private void checkPostB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllPostForm>().FirstOrDefault() == null)
            {
                ShowAllPostForm showAllPostForm = new ShowAllPostForm();
                showAllPostForm.Tag = "checkPost";
                showAllPostForm.OnPostChanged += () => UpdateComboBoxes();
                DialogResult result = showAllPostForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string post = showAllPostForm.selectedPost;
                    if(post!="") PostCombo.SelectedValue = post;
                }
            }
        }

        private void checkQualificationB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllQualificationForm>().FirstOrDefault() == null)
            {
                ShowAllQualificationForm showAllQualificationForm = new ShowAllQualificationForm();
                showAllQualificationForm.Tag = "checkQual";
                showAllQualificationForm.OnQualificationChanged += () => UpdateComboBoxes();
                DialogResult result = showAllQualificationForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string qual = showAllQualificationForm.selectedQual;
                    if (qual!="") QualCombo.SelectedValue = qual;
                }
            }
            //Полагаю стоит поставить содержимое поля на выбранный элемент в форме и обновить список в обобоксе.

        }
        
        private void confirmB_Click(object sender, EventArgs e)
        {
            string errorMessage;
            
            // Проверяем основные данные сотрудника
            bool isValid = ValidationHelper.ValidateEmployee(
                NameTextBox.Text,
                LNameTextBox.Text,
                PatTextBox.Text,
                PSeriesTextBox.Text,
                PNumberTextBox.Text,
                WhoTextBox.Text,
                RegTextBox.Text,
                ResTextBox.Text,
                PhoneTextBox.Text,
                TgTextBox.Text,
                EmailTextBox.Text,
                BirthDate.Value,
                WhenDate.Value,
                out errorMessage
            );

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем должность
            connect = new SqlConnection(connectionString);
            isValid = ValidationHelper.ValidateEmployeePosition(PostCombo.SelectedValue.ToString(), connect, out errorMessage);
            
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации должности", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем квалификацию
            isValid = ValidationHelper.ValidateEmployeeQualification(QualCombo.SelectedValue.ToString(), connect, out errorMessage);
            
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации квалификации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем навыки сотрудника
            isValid = ValidationHelper.ValidateEmployeeSkills(employeeSkills, connect, out errorMessage);
            
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации навыков", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Если все проверки пройдены, продолжаем сохранение
            if (addMode)
            {
                string sql = "INSERT INTO Employee (Qual_ID, Po_ID, Name, LName, Pat, " +
                   "DBirth, PSeries, PNumber, PWho, PWhen, " +
                   "Reg, Res, Email, Tg, Phone) VALUES('" +
                        QualCombo.SelectedValue + "','" +
                        PostCombo.SelectedValue + "','" +
                        NameTextBox.Text + "','" +
                        LNameTextBox.Text + "','" +
                        PatTextBox.Text + "','" +
                        BirthDate.Value.ToString() + "','" +
                        PSeriesTextBox.Text + "','" +
                        PNumberTextBox.Text + "','" +
                        WhoTextBox.Text + "','" +
                        WhenDate.Value.ToString() + "','" +
                        RegTextBox.Text + "','" +
                        ResTextBox.Text + "','" +
                        EmailTextBox.Text + "','" +
                        TgTextBox.Text + "','" +
                        PhoneTextBox.Text + "')";
                Sq(sql);
                string id_e = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString();
                foreach (var skill in employeeSkills)
                {
                    string checkSql = $"SELECT COUNT(*) FROM Employee_Skill WHERE Emp_ID = '{id_e}' AND Skill_ID = '{skill.skillId}'";
                    connect = new SqlConnection(connectionString);
                    connect.Open();
                    SqlCommand checkCommand = new SqlCommand(checkSql, connect);
                    int count = (int)checkCommand.ExecuteScalar();
                    connect.Close();

                    if (count == 0)
                    {
                        string insertSql = "INSERT INTO Employee_Skill (Emp_ID, Skill_ID, Prof) VALUES('" +
                            id_e + "','" +
                            skill.skillId + "','" +
                            skill.skillLevel + "')";
                        Sq(insertSql);
                    }
                    else
                    {
                        string updateSql = "UPDATE Employee_Skill SET Prof = '" + skill.skillLevel + 
                            "' WHERE Emp_ID = '" + id_e + "' AND Skill_ID = '" + skill.skillId + "'";
                        Sq(updateSql);
                    }
                }
                SelectRow(dataGridView1.Rows.Count - 1);
                OnEmployeeListChanged?.Invoke();
            }
            else
            {
                int n_e = dataGridView1.CurrentRow.Index;
                string id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Employee SET "
                +"Qual_ID ='" + QualCombo.SelectedValue
                + "', Po_ID ='" + PostCombo.SelectedValue
                + "', Name ='" + NameTextBox.Text
                + "', LName ='" + LNameTextBox.Text
                + "', Pat ='" + PatTextBox.Text
                + "', DBirth ='" + BirthDate.Value.ToString()
                + "', PSeries ='" + PSeriesTextBox.Text
                + "', PNumber ='" + PNumberTextBox.Text
                + "', PWho ='" + WhoTextBox.Text
                + "', PWhen ='" + WhenDate.Value.ToString()
                + "', Reg ='" + RegTextBox.Text
                + "', Res ='" + ResTextBox.Text
                + "', Email ='" + EmailTextBox.Text
                + "', Tg ='" + TgTextBox.Text
                + "', Phone ='" + PhoneTextBox.Text
                + "' WHERE ID_Emp=" + id_e + ";";
                if (OnEmployeeUpdated != null)
                {
                    OnEmployeeUpdated.Invoke(new Employee(
                    id_e,
                    QualCombo.SelectedValue.ToString(),
                    PostCombo.SelectedValue.ToString(),
                    NameTextBox.Text,
                    LNameTextBox.Text,
                    DateTime.Parse(BirthDate.Value.ToString()),
                    PSeriesTextBox.Text,
                    PNumberTextBox.Text,
                    WhoTextBox.Text,
                    DateTime.Parse(WhenDate.Value.ToString()),
                    RegTextBox.Text,
                    ResTextBox.Text,
                    PhoneTextBox.Text,
                    PostCombo.Text,
                    QualCombo.Text
                    ));
                }
                Sq(sql);
                sql = "DELETE FROM Employee_Skill WHERE Emp_ID = " + id_e + ";";
                Sq(sql);
                foreach (var skill in employeeSkills)
                {
                    sql = "INSERT INTO Employee_Skill (Emp_ID, Skill_ID, Prof) VALUES('" +
                        id_e + "','" +
                        skill.skillId + "','" +
                        skill.skillLevel + "')";
                    Sq(sql);
                }
                SelectRow(n_e);
                OnEmployeeListChanged?.Invoke();
            }
            TurnDefaultMode();
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }

        public void UpdateEmployeeTable()
        {
            // Загружаем данные из базы данных напрямую
            string sql = @"SELECT 
                e.ID_Emp,
                q.Name as QualName,
                p.Name as PosName,
                e.Name,
                e.LName,
                e.Pat,
                e.DBirth,
                e.PSeries,
                e.PNumber,
                e.PWho,
                e.PWhen,
                e.Reg,
                e.Res,
                e.Email,
                e.Tg,
                e.Phone
                FROM Employee e
                LEFT JOIN Post p ON e.Po_ID = p.ID_Po
                LEFT JOIN Qualification q ON e.Qual_ID = q.ID_Qual";

            connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            // Привязываем данные к DataGridView
            dataGridView1.DataSource = dt;

            // Настраиваем отображение колонок
            if (dataGridView1.Columns.Count > 0)
            {
                // Скрываем колонки ID
                dataGridView1.Columns[0].Visible = false;

                // Настраиваем заголовки остальных колонок
                dataGridView1.Columns[1].HeaderText = "Квалификация";
                dataGridView1.Columns[2].HeaderText = "Должность";
                dataGridView1.Columns[3].HeaderText = "Имя";
                dataGridView1.Columns[4].HeaderText = "Фамилия";
                dataGridView1.Columns[5].HeaderText = "Отчество";
                dataGridView1.Columns[6].HeaderText = "Дата рождения";
                dataGridView1.Columns[7].HeaderText = "Серия паспорта";
                dataGridView1.Columns[8].HeaderText = "Номер паспорта";
                dataGridView1.Columns[9].HeaderText = "Кем выдан";
                dataGridView1.Columns[10].HeaderText = "Когда выдан";
                dataGridView1.Columns[11].HeaderText = "Регистрация";
                dataGridView1.Columns[12].HeaderText = "Проживание";
                dataGridView1.Columns[13].HeaderText = "Email";
                dataGridView1.Columns[14].HeaderText = "Telegram";
                dataGridView1.Columns[15].HeaderText = "Телефон";

                // Настраиваем форматирование дат
                dataGridView1.Columns[6].DefaultCellStyle.Format = "dd.MM.yyyy";
                dataGridView1.Columns[10].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
        }
        public void Sq(string sql)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdateEmployeeTable();
        }
        public void SelectRow(int rowIndex)
        {
            if (dataGridView1.Rows.Count > 0 && rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.ClearSelection();
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                dataGridView1.Rows[rowIndex].Selected = true;

                // Ищем первую видимую ячейку в строке
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[i];
                        break;
                    }
                }
            }
        }
        private void TurnDefaultMode()
        {
            showPanel.Visible = true;
            panelAdd.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            addMode = true;
            TurnClearData();
        }
        private void TurnAddMode()
        {
            showPanel.Visible = false;
            panelAdd.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = true;
            TurnClearData();
            
            // Обновляем комбобоксы и устанавливаем значение "Не выбрано"
            UpdateComboBoxes();
            PostCombo.SelectedValue = DBNull.Value;
            QualCombo.SelectedValue = DBNull.Value;
        }
        private void TurnChangeMode()
        {
            showPanel.Visible = false;
            panelAdd.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = false;

            if (dataGridView1.Rows.Count != 0)
            {
                // Получаем ID должности и квалификации из базы данных
                string sql = @"SELECT e.Po_ID, e.Qual_ID 
                              FROM Employee e 
                              WHERE e.ID_Emp = @EmpId";

                connect = new SqlConnection(connectionString);
                connect.Open();
                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    command.Parameters.AddWithValue("@EmpId", dataGridView1.CurrentRow.Cells[0].Value);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Обновляем комбобоксы перед установкой значений
                            UpdateComboBoxes();

                            // Устанавливаем значения комбобоксов
                            PostCombo.SelectedValue = reader["Po_ID"] != DBNull.Value ? reader["Po_ID"] : DBNull.Value;
                            QualCombo.SelectedValue = reader["Qual_ID"] != DBNull.Value ? reader["Qual_ID"] : DBNull.Value;
                        }
                    }
                }
                connect.Close();

                // Заполняем остальные поля
                NameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                LNameTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                PatTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                BirthDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                PSeriesTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                PNumberTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                WhoTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                WhenDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
                RegTextBox.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                ResTextBox.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                EmailTextBox.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                TgTextBox.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                PhoneTextBox.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

                // Загрузка навыков
                LoadEmployeeSkills();
            }
        }
        private void TurnClearData()
        {
            NameTextBox.Text = string.Empty;
            LNameTextBox.Text = string.Empty;
            PatTextBox.Text = string.Empty;
            PSeriesTextBox.Text = string.Empty;
            PNumberTextBox.Text = string.Empty;
            WhoTextBox.Text = string.Empty;
            WhoTextBox.Text = string.Empty;
            RegTextBox.Text = string.Empty;
            ResTextBox.Text = string.Empty;
            //TODO
            //TODO
            dataGridView2.Rows.Clear();
            employeeSkills.Clear();
            EmailTextBox.Text = "";
            TgTextBox.Text = "";
            PhoneTextBox.Text = "";
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSkillForm addSkillForm = new AddSkillForm(employeeSkills[dataGridView2.CurrentRow.Index].skillLevel);
            if (addSkillForm.ShowDialog() == DialogResult.OK)
            {
                string id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int n_s = dataGridView2.CurrentRow.Index;
                string skillLevel = addSkillForm.SelectedLevel;
                employeeSkills[dataGridView2.CurrentRow.Index].skillLevel = skillLevel;
                string sql = "UPDATE Employee_Skill SET "
               + "Prof ='" + skillLevel
               + "' WHERE Emp_ID=" + id_e + ", "
               + "Skill_ID =" + employeeSkills[dataGridView2.CurrentRow.Index].skillId + ";";
                UpdateSkillTable();
                dataGridView2.CurrentCell = dataGridView2.Rows[n_s].Cells[1];
                dataGridView2.ClearSelection();
                dataGridView2.Rows[n_s].Selected = true;
                dataGridView2.Rows[n_s].Cells[0].Selected = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.Tag?.ToString() == "checkEmployee")
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string lname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string pat = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string pos = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string qual = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                Employee selectedEmployee = new Employee(id, name, lname, pat, pos, qual);
                OnEmployeeSelected?.Invoke(selectedEmployee);
            }
        }

        private void UpdateComboBoxes()
        {
            try
            {
                // Сохраняем текущие выбранные значения
                object selectedPostValue = PostCombo.SelectedValue;
                object selectedQualValue = QualCombo.SelectedValue;

                // Обновление PostCombo
                string postSql = "SELECT ID_Po, Name FROM Post";
                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand postCommand = new SqlCommand(postSql, connect);
                SqlDataAdapter postAdapter = new SqlDataAdapter(postCommand);
                DataTable postDt = new DataTable();
                postAdapter.Fill(postDt);
                connect.Close();

                // Добавляем "Не выбрано" в таблицу должностей
                DataRow postNewRow = postDt.NewRow();
                postNewRow["ID_Po"] = DBNull.Value;
                postNewRow["Name"] = "Не выбрано";
                postDt.Rows.InsertAt(postNewRow, 0);

                PostCombo.DataSource = postDt;
                PostCombo.DisplayMember = "Name";
                PostCombo.ValueMember = "ID_Po";

                // Обновление QualCombo
                string qualSql = "SELECT ID_Qual, Name FROM Qualification";
                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand qualCommand = new SqlCommand(qualSql, connect);
                SqlDataAdapter qualAdapter = new SqlDataAdapter(qualCommand);
                DataTable qualDt = new DataTable();
                qualAdapter.Fill(qualDt);
                connect.Close();

                // Добавляем "Не выбрано" в таблицу квалификаций
                DataRow qualNewRow = qualDt.NewRow();
                qualNewRow["ID_Qual"] = DBNull.Value;
                qualNewRow["Name"] = "Не выбрано";
                qualDt.Rows.InsertAt(qualNewRow, 0);

                QualCombo.DataSource = qualDt;
                QualCombo.DisplayMember = "Name";
                QualCombo.ValueMember = "ID_Qual";

                // Восстанавливаем выбранные значения, если они существуют в обновленных данных
                if (selectedPostValue != null)
                {
                    var exists = postDt.AsEnumerable().Any(row => 
                        row["ID_Po"] != DBNull.Value && 
                        row["ID_Po"].ToString() == selectedPostValue.ToString());
                    PostCombo.SelectedValue = exists ? selectedPostValue : DBNull.Value;
                }
                else
                {
                    PostCombo.SelectedValue = DBNull.Value;
                }

                if (selectedQualValue != null)
                {
                    var exists = qualDt.AsEnumerable().Any(row => 
                        row["ID_Qual"] != DBNull.Value && 
                        row["ID_Qual"].ToString() == selectedQualValue.ToString());
                    QualCombo.SelectedValue = exists ? selectedQualValue : DBNull.Value;
                }
                else
                {
                    QualCombo.SelectedValue = DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списков: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeSkills()
        {
            try
            {
                // Очищаем существующие навыки
                employeeSkills.Clear();
                dataGridView2.Rows.Clear();

                // Загружаем навыки сотрудника из базы данных
                string sql = "SELECT Skill_ID, Name, Prof FROM Skill " +
                            "INNER JOIN Employee_Skill ON ID_Skill = Skill_ID " +
                            "WHERE Emp_ID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();

                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Добавляем навык в список
                    var skill = new Skill(
                        reader["Skill_ID"].ToString(),
                        reader["Name"].ToString(),
                        reader["Prof"].ToString()
                    );
                    employeeSkills.Add(skill);

                    // Добавляем строку в таблицу
                    dataGridView2.Rows.Add(
                        reader["Skill_ID"].ToString(),
                        reader["Name"].ToString(),
                        reader["Prof"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке навыков: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void InfoB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите сотрудника для просмотра информации", 
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ищем открытую форму EmployeeInfo
            EmployeeInfo existingForm = Application.OpenForms.OfType<EmployeeInfo>().FirstOrDefault();
            
            if (existingForm != null)
            {
                // Если форма уже открыта, активируем её и обновляем данные
                if (existingForm.WindowState == FormWindowState.Minimized)
                    existingForm.WindowState = FormWindowState.Normal;
                existingForm.Activate();
                existingForm.BringToFront();
                UpdateEmployeeInfo(existingForm);
            }
            else
            {
                // Создаём новую форму
                EmployeeInfo employeeInfo = new EmployeeInfo();
                UpdateEmployeeInfo(employeeInfo);
                employeeInfo.Show();
            }
        }

        private void UpdateEmployeeInfo(EmployeeInfo form)
        {
            try
            {
                string employeeId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string sql = @"SELECT 
                    e.Name, e.LName, e.Pat, e.DBirth, 
                    e.PSeries, e.PNumber, e.PWho, e.PWhen,
                    e.Reg, e.Res, e.Email, e.Tg, e.Phone,
                    p.Name as Position, q.Name as Qualification
                    FROM Employee e
                    LEFT JOIN Post p ON e.Po_ID = p.ID_Po
                    LEFT JOIN Qualification q ON e.Qual_ID = q.ID_Qual
                    WHERE e.ID_Emp = @EmpId";

                connect = new SqlConnection(connectionString);
                connect.Open();
                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    command.Parameters.AddWithValue("@EmpId", employeeId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Функция для проверки и форматирования значений
                            string GetValueOrDash(object value) => 
                                value == DBNull.Value || string.IsNullOrWhiteSpace(value?.ToString()) ? "-" : value.ToString().Trim();

                            // Функция для форматирования даты
                            string FormatDateOrDash(object value) => 
                                value == DBNull.Value ? "-" : Convert.ToDateTime(value).ToString("dd.MM.yyyy");

                            // Заполняем основные данные сотрудника
                            form.NameTextBox.Text = GetValueOrDash(reader["Name"]);
                            form.LNameTextBox.Text = GetValueOrDash(reader["LName"]);
                            form.PatTextBox.Text = GetValueOrDash(reader["Pat"]);
                            form.BirthDate.Text = FormatDateOrDash(reader["DBirth"]);
                            
                            form.PSeriesTextBox.Text = GetValueOrDash(reader["PSeries"]);
                            form.PNumberTextBox.Text = GetValueOrDash(reader["PNumber"]);
                            form.WhoTextBox.Text = GetValueOrDash(reader["PWho"]);
                            form.WhenDate.Text = FormatDateOrDash(reader["PWhen"]);
                            
                            form.RegTextBox.Text = GetValueOrDash(reader["Reg"]);
                            form.ResTextBox.Text = GetValueOrDash(reader["Res"]);
                            form.EmailTextBox.Text = GetValueOrDash(reader["Email"]);
                            form.TgTextBox.Text = GetValueOrDash(reader["Tg"]);
                            form.PhoneTextBox.Text = GetValueOrDash(reader["Phone"]);
                            
                            form.PostCombo.Text = GetValueOrDash(reader["Position"]);
                            form.QualCombo.Text = GetValueOrDash(reader["Qualification"]);
                        }
                    }
                }

                // Загружаем навыки сотрудника
                sql = @"SELECT 
                    ISNULL(s.Name, '-') as SkillName,
                    ISNULL(CONVERT(varchar, es.Prof), '-') as Level
                    FROM Employee_Skill es
                    INNER JOIN Skill s ON es.Skill_ID = s.ID_Skill
                    WHERE es.Emp_ID = @EmpId";

                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    command.Parameters.AddWithValue("@EmpId", employeeId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    form.dataGridView2.DataSource = dt;

                    if (form.dataGridView2.Columns.Count > 0)
                    {
                        form.dataGridView2.Columns[0].HeaderText = "Навык";
                        form.dataGridView2.Columns[1].HeaderText = "Уровень";

                        form.dataGridView2.Columns[0].Width = 200;
                        form.dataGridView2.Columns[1].Width = 100;

                        form.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        form.dataGridView2.AllowUserToAddRows = false;
                        form.dataGridView2.AllowUserToDeleteRows = false;
                        form.dataGridView2.ReadOnly = true;
                        form.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        form.dataGridView2.MultiSelect = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке информации о сотруднике: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }
    }
}
