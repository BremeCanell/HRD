using Spire.Doc.Fields.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD
{
    public partial class ShowAllProjectForm : Form
    {
        public ShowAllProjectForm()
        {
            InitializeComponent();
        }
        private bool addMode = true;
        private List<Employee> employeeTeam = new List<Employee>();
        private SqlConnection connect;
        String connectionString = "Data Source=DESKTOP-FPP7TIE;Initial Catalog=HRD_DB;Trusted_Connection=True";
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
                string id_pr = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Project Where ID_Pr = " + id_pr;
                Sq(sql);
            }
        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            string errorMessage;
            bool isValid = ValidationHelper.ValidateProject(
                NameTextBox.Text,
                DescriptionTextBox.Text,
                DPStart.Value,
                DPEnd.Value,
                DFStart.Checked ? DFStart.Value : (DateTime?)null,
                DFEnd.Checked ? DFEnd.Value : (DateTime?)null,
                out errorMessage
            );

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (employeeTeam.Any(emp => emp.ID_Emp == RespCombo.SelectedValue.ToString()))
            {
                MessageBox.Show("Ответственный за проект не может быть членом команды!", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (addMode)
            {
                string sql = "INSERT INTO Project (Name, Des, DC, PDS, PDE";
                string values = "VALUES('" + 
                    NameTextBox.Text + "','" +
                    DescriptionTextBox.Text + "','" +
                    DCreate.Value.ToString("yyyy-MM-dd") + "','" +
                    DPStart.Value.ToString("yyyy-MM-dd") + "','" +
                    DPEnd.Value.ToString("yyyy-MM-dd") + "'";

                if (DFStart.Checked)
                {
                    sql += ", FDS";
                    values += ",'" + DFStart.Value.ToString("yyyy-MM-dd") + "'";
                }
                if (DFEnd.Checked)
                {
                    sql += ", FDE";
                    values += ",'" + DFEnd.Value.ToString("yyyy-MM-dd") + "'";
                }

                sql += ") " + values + ");";
                Sq(sql);
                
                sql = "SELECT SCOPE_IDENTITY()";
                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                int newProjectId = Convert.ToInt32(command.ExecuteScalar());
                connect.Close();

                UpdateProjectTeamAndResponsible(newProjectId);
            }
            else
            {
                int n_pr = dataGridView1.CurrentRow.Index;
                string id_pr = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
                string sql = "UPDATE Project SET " +
                    "Name ='" + NameTextBox.Text + "'," +
                    "Des ='" + DescriptionTextBox.Text + "'," +
                    "PDS ='" + DPStart.Value.ToString("yyyy-MM-dd") + "'," +
                    "PDE ='" + DPEnd.Value.ToString("yyyy-MM-dd") + "'";

                if (DFStart.Checked)
                    sql += ",FDS ='" + DFStart.Value.ToString("yyyy-MM-dd") + "'";
                else
                    sql += ",FDS = NULL";

                if (DFEnd.Checked)
                    sql += ",FDE ='" + DFEnd.Value.ToString("yyyy-MM-dd") + "'";
                else
                    sql += ",FDE = NULL";

                sql += " WHERE ID_Pr=" + id_pr;
                
                Sq(sql);
                UpdateProjectTeamAndResponsible(int.Parse(id_pr));
            }
            TurnDefaultMode();
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }
        private void showResponsable_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkResponsable";
                
                showAllEmployeeForm.OnEmployeeListChanged += () => UpdateRespCombo();
                
                showAllEmployeeForm.OnEmployeeSelected += (employeeSelected) =>
                {
                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == employeeSelected.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = employeeSelected;

                    }
                    else
                    {
                        employeeTeam.Add(employeeSelected);
                    }
                };
                showAllEmployeeForm.OnEmployeeUpdated += (updatedEmployee) =>
                {
                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == updatedEmployee.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = updatedEmployee;
                    }
                };
                showAllEmployeeForm.OnEmployeeDeleted += (employeeId) =>
                {
                    employeeTeam.RemoveAll(x => x.ID_Emp == employeeId);
                };
                DialogResult result = showAllEmployeeForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string responasle = showAllEmployeeForm.selectedResponsable;
                    //TODO
                    if (responasle != "") RespCombo.SelectedValue = responasle;
                }
                UpdateTeamTable();
            }
        }

        private void ShowAllProjectForm_Load(object sender, EventArgs e)
        {
            UpdateProjectTable();
            UpdateRespCombo();
            // Вызываем обновление данных
            UpdateProjectTable();

            // Устанавливаем начальные значения дат
            DPStart.Value = DateTime.Now.AddDays(7);
            DPEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            DFStart.Value = DateTime.Now.AddDays(7);
            DFEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
        }
        private void addTeamB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkTeam";
                
                showAllEmployeeForm.OnEmployeeListChanged += () => UpdateRespCombo();
                
                showAllEmployeeForm.OnEmployeeSelected += (employeeSelected) =>
                {
                    // Проверяем, не является ли сотрудник ответственным
                    if (RespCombo.SelectedValue != null && 
                        RespCombo.SelectedValue != DBNull.Value && 
                        employeeSelected.ID_Emp == RespCombo.SelectedValue.ToString())
                    {
                        MessageBox.Show("Этот сотрудник является ответственным за проект и не может быть добавлен в команду!", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == employeeSelected.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = new Employee(
                            employeeSelected.ID_Emp,
                            employeeSelected.Name,
                            employeeSelected.LName,
                            employeeSelected.Pat,
                            employeeSelected.PosName,
                            employeeSelected.QualName
                        );
                    }
                    else
                    {
                        employeeTeam.Add(new Employee(
                            employeeSelected.ID_Emp,
                            employeeSelected.Name,
                            employeeSelected.LName,
                            employeeSelected.Pat,
                            employeeSelected.PosName,
                            employeeSelected.QualName
                        ));
                    }
                };

                showAllEmployeeForm.OnEmployeeUpdated += (updatedEmployee) =>
                {
                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == updatedEmployee.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = new Employee(
                            updatedEmployee.ID_Emp,
                            updatedEmployee.Name,
                            updatedEmployee.LName,
                            updatedEmployee.Pat,
                            updatedEmployee.PosName,
                            updatedEmployee.QualName
                        );
                    }
                };

                showAllEmployeeForm.OnEmployeeDeleted += (employeeId) =>
                {
                    employeeTeam.RemoveAll(x => x.ID_Emp == employeeId);
                };

                showAllEmployeeForm.ShowDialog();
                UpdateTeamTable();
            }
        }
        private void deleteTeamB_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                employeeTeam.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
        public void UpdateEmployeeTable()
        {
            //TODO
        }
        public void DeleteTeamTable() { 

        }
        public void Sq(string sql)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdateProjectTable();
        }
        public void SelectRow(int rowIndex)
        {
            if (dataGridView1.Rows.Count > 0 && rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {

                    dataGridView1.ClearSelection();
                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    dataGridView1.Rows[rowIndex].Selected = true;
                    if (dataGridView1.Columns.Count > 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[dataGridView1.FirstDisplayedCell.ColumnIndex];
                    }

            }
        }
        private void TurnDefaultMode()
        {
            showPanel.Visible = true;
            panel1.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            infoB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            DFEnd.Visible = false;
            DFStart.Visible = false;
            addMode = true;
            TurnClearData();
        }
        private void TurnAddMode()
        {
            showPanel.Visible = false;
            panel1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            infoB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = true;
            TurnClearData();
        }
        private void TurnChangeMode()
        {
            showPanel.Visible = false;
            panel1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            infoB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            DFEnd.Visible = true;
            DFStart.Visible = true;
            addMode = false;
            if (dataGridView1.Rows.Count != 0)
            {
                NameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DescriptionTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DCreate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                DPStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                DPEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());

                if (dataGridView1.CurrentRow.Cells[6].Value != DBNull.Value)
                {
                    DFStart.Checked = true;
                    DFStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                }
                else
                {
                    DFStart.Checked = false;
                }

                if (dataGridView1.CurrentRow.Cells[7].Value != DBNull.Value)
                {
                    DFEnd.Checked = true;
                    DFEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                }
                else
                {
                    DFEnd.Checked = false;
                }

                LoadProjectResponsible();
                LoadProjectTeam();
            }
        }
        private void TurnClearData()
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            DPStart.Value = DateTime.Now.AddDays(7);
            DPEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            DFStart.Value = DateTime.Now.AddDays(7);
            DFEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            dataGridView2.Rows.Clear();
        }
        private void UpdateTeamTable()
        {
            dataGridView2.Rows.Clear();
            foreach (var employee in employeeTeam)
            {
                dataGridView2.Rows.Add(employee.LName, employee.Name, employee.Pat, employee.PosName, employee.QualName);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.project_EmployeeTableAdapter.FillBy(this.hRD_DBDataSet.Project_Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void UpdateProjectTable()
        {
            // Сохраняем текущую позицию
            int currentRowIndex = -1;
            string selectedProjectId = null;
            if (dataGridView1.CurrentRow != null)
            {
                currentRowIndex = dataGridView1.CurrentRow.Index;
                selectedProjectId = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            }

            // Загружаем данные из базы данных
            string sql = "SELECT ID_Pr, Name, Des, DC, PDS, PDE, FDS, FDE FROM Project";
            connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            // Привязываем данные к DataGridView
            dataGridView1.DataSource = dt;

            // Восстанавливаем позицию
            if (selectedProjectId != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == selectedProjectId)
                    {
                        dataGridView1.CurrentCell = row.Cells[dataGridView1.CurrentCell.ColumnIndex];
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = Math.Max(0, 
                            Math.Min(row.Index, dataGridView1.RowCount - 1));
                        break;
                    }
                }
            }
        }
        private void LoadProjectTeam()
        {
            try
            {
                employeeTeam.Clear();
                string projectId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string sql = @"SELECT e.ID_Emp, e.Name, e.LName, e.Pat, 
                              ISNULL(p.Name, 'Не указано') as PosName, 
                              ISNULL(q.Name, 'Не указано') as QualName 
                              FROM Employee e
                              INNER JOIN Project_Employee pe ON e.ID_Emp = pe.Emp_ID
                              LEFT JOIN Post p ON e.Po_ID = p.ID_Po
                              LEFT JOIN Qualification q ON e.Qual_ID = q.ID_Qual
                              WHERE pe.Pr_ID = @ProjectId AND pe.Emp_resp = 0";

                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employeeTeam.Add(new Employee(
                        reader["ID_Emp"].ToString(),
                        reader["Name"].ToString(),
                        reader["LName"].ToString(),
                        reader["Pat"].ToString(),
                        reader["PosName"].ToString(),
                        reader["QualName"].ToString()
                    ));
                }

                UpdateTeamTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке команды проекта: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void UpdateRespCombo()
        {
            try
            {
                // Сохраняем текущее выбранное значение
                object selectedValue = RespCombo.SelectedValue;

                // Получаем список всех сотрудников
                string sql = @"SELECT ID_Emp, 
                              CONCAT(LName, ' ', Name, ' ', ISNULL(Pat, '')) as FullName 
                              FROM Employee";

                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connect.Close();

                // Добавляем "Не выбрано" в таблицу
                DataRow newRow = dt.NewRow();
                newRow["ID_Emp"] = DBNull.Value;
                newRow["FullName"] = "Не выбрано";
                dt.Rows.InsertAt(newRow, 0);

                RespCombo.DataSource = dt;
                RespCombo.DisplayMember = "FullName";
                RespCombo.ValueMember = "ID_Emp";

                // Проверяем существование выбранного значения в обновленном списке
                if (selectedValue != null && selectedValue != DBNull.Value)
                {
                    var exists = dt.AsEnumerable().Any(row => 
                        row["ID_Emp"] != DBNull.Value && 
                        row["ID_Emp"].ToString() == selectedValue.ToString());
                    
                    RespCombo.SelectedValue = exists ? selectedValue : DBNull.Value;
                }
                else
                {
                    RespCombo.SelectedValue = DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка ответственных: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RespCombo.SelectedValue = DBNull.Value;
            }
        }

        private void LoadProjectResponsible()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string projectId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    
                    string sql = @"SELECT e.ID_Emp 
                                  FROM Employee e
                                  INNER JOIN Project_Employee pe ON e.ID_Emp = pe.Emp_ID
                                  WHERE pe.Pr_ID = @ProjectId AND pe.Emp_resp = 1";

                    connect = new SqlConnection(connectionString);
                    connect.Open();
                    SqlCommand command = new SqlCommand(sql, connect);
                    command.Parameters.AddWithValue("@ProjectId", projectId);
                    
                    object result = command.ExecuteScalar();
                    connect.Close();

                    RespCombo.SelectedValue = result ?? DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ответственного: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProjectTeamAndResponsible(int projectId)
        {
            string errorMessage;
            connect = new SqlConnection(connectionString);

            // Валидация ответственного
            if (!ValidationHelper.ValidateProjectResponsible(RespCombo.SelectedValue?.ToString(), connect, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateRespCombo(); // Обновляем список после ошибки
                return;
            }

            // Валидация команды проекта
            if (!ValidationHelper.ValidateProjectTeam(employeeTeam, connect, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateTeamTable(); // Обновляем таблицу после ошибки
                return;
            }

            try
            {
                connect.Open();
                using (SqlTransaction transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Удаляем все существующие записи для проекта
                        string deleteSql = "DELETE FROM Project_Employee WHERE Pr_ID = @ProjectId";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteSql, connect, transaction))
                        {
                            deleteCommand.Parameters.AddWithValue("@ProjectId", projectId);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // Добавляем ответственного
                        if (RespCombo.SelectedValue != null && RespCombo.SelectedValue != DBNull.Value)
                        {
                            string insertRespSql = @"INSERT INTO Project_Employee (Pr_ID, Emp_ID, Emp_resp) 
                                                   VALUES (@ProjectId, @EmpId, 1)";
                            using (SqlCommand insertCommand = new SqlCommand(insertRespSql, connect, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@ProjectId", projectId);
                                insertCommand.Parameters.AddWithValue("@EmpId", RespCombo.SelectedValue);
                                insertCommand.ExecuteNonQuery();
                            }
                        }

                        // Добавляем членов команды
                        foreach (var employee in employeeTeam)
                        {
                            string insertTeamSql = @"INSERT INTO Project_Employee (Pr_ID, Emp_ID, Emp_resp) 
                                                   VALUES (@ProjectId, @EmpId, 0)";
                            using (SqlCommand insertCommand = new SqlCommand(insertTeamSql, connect, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@ProjectId", projectId);
                                insertCommand.Parameters.AddWithValue("@EmpId", employee.ID_Emp);
                                insertCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        TurnDefaultMode(); // Закрываем форму только при усп��шном сохранении
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении команды проекта: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateProjectTable(); // Обновляем основную таблицу после ошибки
            }
            finally
            {
                if (connect.State == System.Data.ConnectionState.Open)
                    connect.Close();
            }
        }

        private void InfoB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите проект для просмотра информации", 
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ищем открытую форму ProjectInfo
            ProjectInfo existingForm = Application.OpenForms.OfType<ProjectInfo>().FirstOrDefault();
            
            if (existingForm != null)
            {
                // Если форма уже открыта, активируем её и обновляем данные
                if (existingForm.WindowState == FormWindowState.Minimized)
                    existingForm.WindowState = FormWindowState.Normal;
                existingForm.Activate();
                existingForm.BringToFront();
                UpdateProjectInfo(existingForm);
            }
            else
            {
                // Создаём новую форму
                ProjectInfo projectInfo = new ProjectInfo();
                UpdateProjectInfo(projectInfo);
                projectInfo.Show();
            }
        }

        private void UpdateProjectInfo(ProjectInfo form)
        {
            try
            {
                // Получаем ID текущего проекта
                string projectId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                // Загружаем данные проекта
                string sql = @"SELECT 
                    p.Name, p.Des, p.DC, p.PDS, p.PDE, p.FDS, p.FDE,
                    CONCAT(e.LName, ' ', e.Name, ' ', ISNULL(e.Pat, '')) as ResponsibleName
                    FROM Project p
                    LEFT JOIN Project_Employee pe ON p.ID_Pr = pe.Pr_ID AND pe.Emp_resp = 1
                    LEFT JOIN Employee e ON pe.Emp_ID = e.ID_Emp
                    WHERE p.ID_Pr = @ProjectId";

                connect = new SqlConnection(connectionString);
                connect.Open();
                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    command.Parameters.AddWithValue("@ProjectId", projectId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Заполняем основные данные проекта
                            form.NameTextBox.Text = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : "-";
                            form.DescriptionTextBox.Text = reader["Des"] != DBNull.Value ? reader["Des"].ToString() : "-";
                            form.DCreate.Text = reader["DC"] != DBNull.Value ? Convert.ToDateTime(reader["DC"]).ToString("dd.MM.yyyy") : "-";
                            form.DPStart.Text = reader["PDS"] != DBNull.Value ? Convert.ToDateTime(reader["PDS"]).ToString("dd.MM.yyyy") : "-";
                            form.DPEnd.Text = reader["PDE"] != DBNull.Value ? Convert.ToDateTime(reader["PDE"]).ToString("dd.MM.yyyy") : "-";
                            form.DFStart.Text = reader["FDS"] != DBNull.Value ? Convert.ToDateTime(reader["FDS"]).ToString("dd.MM.yyyy") : "-";
                            form.DFEnd.Text = reader["FDE"] != DBNull.Value ? Convert.ToDateTime(reader["FDE"]).ToString("dd.MM.yyyy") : "-";
                            form.RespCombo.Text = !string.IsNullOrWhiteSpace(reader["ResponsibleName"].ToString()) ? 
                                reader["ResponsibleName"].ToString().Trim() : "-";
                        }
                    }
                }

                // Загружаем команду проекта
                sql = @"SELECT 
                    e.ID_Emp,
                    ISNULL(e.LName, '-') as LastName,
                    ISNULL(e.Name, '-') as FirstName,
                    ISNULL(e.Pat, '-') as Patronymic,
                    ISNULL(p.Name, '-') as Position,
                    ISNULL(q.Name, '-') as Qualification
                    FROM Project_Employee pe
                    INNER JOIN Employee e ON pe.Emp_ID = e.ID_Emp
                    LEFT JOIN Post p ON e.Po_ID = p.ID_Po
                    LEFT JOIN Qualification q ON e.Qual_ID = q.ID_Qual
                    WHERE pe.Pr_ID = @ProjectId AND pe.Emp_resp = 0";

                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    command.Parameters.AddWithValue("@ProjectId", projectId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    form.dataGridView2.DataSource = dt;

                    // Настраиваем отображение колонок команды
                    if (form.dataGridView2.Columns.Count > 0)
                    {
                        form.dataGridView2.Columns[0].Visible = false; // Скрываем ID
                        form.dataGridView2.Columns[1].HeaderText = "Фамилия";
                        form.dataGridView2.Columns[2].HeaderText = "Имя";
                        form.dataGridView2.Columns[3].HeaderText = "Отчество";
                        form.dataGridView2.Columns[4].HeaderText = "Должность";
                        form.dataGridView2.Columns[5].HeaderText = "Квалификация";

                        // Настраиваем ширину колонок
                        form.dataGridView2.Columns[1].Width = 150; // Фамилия
                        form.dataGridView2.Columns[2].Width = 150; // Имя
                        form.dataGridView2.Columns[3].Width = 150; // Отчество
                        form.dataGridView2.Columns[4].Width = 150; // Должность
                        form.dataGridView2.Columns[5].Width = 150; // Квалификация

                        // Дополнительные настройки
                        form.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        form.dataGridView2.AllowUserToAddRows = false;
                        form.dataGridView2.AllowUserToDeleteRows = false;
                        form.dataGridView2.ReadOnly = true;
                        form.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        form.dataGridView2.MultiSelect = false;
                    }
                }

                // Делаем видимыми метки для фактических дат
                form.label2.Visible = true;
                form.label3.Visible = true;
                form.DFStart.Visible = true;
                form.DFEnd.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке информации о проекте: {ex.Message}", 
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
