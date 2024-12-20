using Spire.Doc.Documents;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Data.SqlClient;
using Spire.Doc.Fields;

namespace HRD
{
    public partial class ReportOverdue : Form
    {
        private SqlConnection connect;
        String connectionString = "Data Source=DESKTOP-FPP7TIE;Initial Catalog=HRD_DB;Trusted_Connection=True";

        public ReportOverdue()
        {
            InitializeComponent();
        }

        private void ReportOverdue_Load(object sender, EventArgs e)
        {
            // Устанавливаем начальные значения дат
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker2.Value = DateTime.Now;
            
            // Инициализируем комбобокс
            UpdateEmployeeCombo();
            
            // Устанавливаем значение "Не выбрано" по умолчанию
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void UpdateEmployeeCombo()
        {
            try
            {
                object selectedValue = comboBox1.SelectedValue;

                // Добавляем получение должности
                string sql = @"SELECT 
                    e.ID_Emp, 
                    CONCAT(e.LName, ' ', e.Name, ' ', ISNULL(e.Pat, '')) as FullName,
                    p.Name as Position
                FROM Employee e
                LEFT JOIN Post p ON e.Po_ID = p.ID_Po";

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
                newRow["Position"] = DBNull.Value;
                dt.Rows.InsertAt(newRow, 0);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "FullName";
                comboBox1.ValueMember = "ID_Emp";

                // Восстанавливаем выбранное значение
                if (selectedValue != null)
                {
                    var exists = dt.AsEnumerable().Any(row => 
                        row["ID_Emp"] != DBNull.Value && 
                        row["ID_Emp"].ToString() == selectedValue.ToString());
                    comboBox1.SelectedValue = exists ? selectedValue : DBNull.Value;
                }
                else
                {
                    comboBox1.SelectedValue = DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка сотрудников: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkEmployeeB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkEmployee";
                
                // Обработчик выбора сотрудника
                showAllEmployeeForm.OnEmployeeSelected += (employee) =>
                {
                    if (employee != null)
                    {
                        comboBox1.SelectedValue = employee.ID_Emp;
                        showAllEmployeeForm.Close();
                    }
                };
                
                // Обработчик изменения списка сотрудников
                showAllEmployeeForm.OnEmployeeListChanged += () => UpdateEmployeeCombo();
                
                // Обработчик удаления сотрудника
                showAllEmployeeForm.OnEmployeeDeleted += (deletedId) =>
                {
                    if (comboBox1.SelectedValue?.ToString() == deletedId)
                    {
                        comboBox1.SelectedValue = DBNull.Value;
                    }
                    UpdateEmployeeCombo();
                };
                
                showAllEmployeeForm.Show();
            }
        }

        private void createB_Click(object sender, EventArgs e)
        {
            string errorMessage;
            if (!ValidationHelper.ValidateReportOverdueParams(
                dateTimePicker1.Value, 
                dateTimePicker2.Value,
                comboBox1.SelectedValue?.ToString(),
                out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Загружаем шаблон
            Document doc = new Document();
            doc.LoadFromFile(@"Report3.docx");

            // Получаем должность выбранного сотрудника
            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;
            string position = selectedRow?["Position"]?.ToString() ?? "Не указана";

            // Заменяем метки в документе
            doc.Replace("{ DateStart }", dateTimePicker1.Value.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("{ DateEnd }", dateTimePicker2.Value.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("{ DateToday }", DateTime.Today.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("{ Post }", position, true, true);
            doc.Replace("{Name}", comboBox1.Text, true, true);

            // Получаем данные
            DataTable projectData = GetCompletedProjects();

            // Находим таблицу в шаблоне
            Section section = doc.Sections[0];
            Table table = section.Tables[0] as Table;

            // Заполняем таблицу данными
            for (int r = 0; r < projectData.Rows.Count; r++)
            {
                table.AddRow();
                TableRow dataRow = table.Rows[r + 1];

                for (int c = 0; c < projectData.Columns.Count; c++)
                {
                    Paragraph p = dataRow.Cells[c].AddParagraph();
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                    TextRange text = p.AppendText(projectData.Rows[r][c]?.ToString() ?? "—");
                    text.CharacterFormat.FontName = "Times New Roman";
                    text.CharacterFormat.FontSize = 11;
                }
            }

            // Сохраняем и открываем документ
            string fileName = $"Отчет_просроченным_проектам_{DateTime.Now:dd_MM_yyyy}.docx";
            doc.SaveToFile(fileName);
            Process.Start(fileName);
        }

        private DataTable GetCompletedProjects()
        {
            string sql = @"
                DECLARE @CurrentDate DATE = GETDATE();
                WITH ProjectsWithDelay AS (
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY p.DC) AS [№],
                        p.Name AS [Название проекта],
                        CONCAT(e.LName, ' ', e.Name, ' ', ISNULL(e.LName, '—')) AS [ФИО ответственного],
                        FORMAT(p.DC, 'dd.MM.yyyy') AS [Дата создания],
                        FORMAT(p.PDS, 'dd.MM.yyyy') AS [План. дата начала],
                        FORMAT(p.PDE, 'dd.MM.yyyy') AS [План. дата окончания],
                        ISNULL(FORMAT(p.FDS, 'dd.MM.yyyy'), '—') AS [Факт. дата начала],
                        ISNULL(FORMAT(p.FDE, 'dd.MM.yyyy'), '—') AS [Факт. дата окончания],
                        CASE 
                            WHEN p.FDE IS NOT NULL THEN 
                                CASE 
                                    WHEN p.FDE > p.PDE THEN DATEDIFF(DAY, p.PDE, p.FDE)
                                    ELSE 0 
                                END
                            WHEN @CurrentDate > p.PDE THEN DATEDIFF(DAY, p.PDE, @CurrentDate)
                            ELSE 0
                        END AS [Просрочка (дней)]
                    FROM Project p
                    LEFT JOIN Project_Employee pe ON p.ID_Pr = pe.Pr_ID AND pe.Emp_resp = 1
                    LEFT JOIN Employee e ON pe.Emp_ID = e.ID_Emp
                    WHERE 
                        p.DC BETWEEN @StartDate AND @EndDate
                )
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY [Дата создания]) AS [№],
                    [Название проекта],
                    [ФИО ответственного],
                    [Дата создания],
                    [План. дата начала],
                    [План. дата окончания],
                    [Факт. дата начала],
                    [Факт. дата окончания],
                    [Просрочка (дней)]
                FROM ProjectsWithDelay
                WHERE [Просрочка (дней)] > 0
                ORDER BY [Дата создания]";

            return ExecuteQuery(sql);
        }

        private DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpId", comboBox1.SelectedValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);
                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

            return dt;
        }
    }
}
