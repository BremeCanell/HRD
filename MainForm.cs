using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRD
{
    public partial class MainForm : Form
    {
        private Timer updateTimer;
        private SqlConnection connect;
        String connectionString = "Data Source=DESKTOP-FPP7TIE;Initial Catalog=HRD_DB;Trusted_Connection=True";

        public MainForm()
        {
            InitializeComponent();
            
            // Инициализация и настройка таймера
            updateTimer = new Timer();
            updateTimer.Interval = 1000; // Интервал обновления - 1 минута (60000 миллисекунд)
            updateTimer.Tick += UpdateTimer_Tick;
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllEmployeeForm>();

        private void PostToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllPostForm>();

        private void ProjectToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllProjectForm>();
        private void QualificationToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllQualificationForm>();

        private void SkillToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllSkillForm>();
        private void ReportWorkloadToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ReportWorkLoad>();
        private void ReportOverdueToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ReportOverdue>();
        private void ReportExperienceToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ReportExperience>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private void openFormMenu<T>() where T : Form, new()
        {
            // Ищем открытую форму указанного типа
            Form existingForm = Application.OpenForms.OfType<T>().FirstOrDefault();
            
            if (existingForm != null)
            {
                // Если форма уже открыта, активируем её
                if (existingForm.WindowState == FormWindowState.Minimized)
                {
                    existingForm.WindowState = FormWindowState.Normal;
                }
                existingForm.Activate();
                existingForm.BringToFront();
            }
            else
            {
                // Если формы нет, создаём новую
                T form = new T();
                form.FormClosed += Forms_FormClosed;
                form.Show();
            }
        }
        private void Forms_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateCurrentProjects();
            updateTimer.Start(); // Запускаем таймер при загрузке формы
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateCurrentProjects();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            updateTimer.Stop(); // Останавливаем таймер при закрытии формы
            base.OnFormClosing(e);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void UpdateCurrentProjects()
        {
            try
            {
                // Сохраняем текущую позицию
                int currentRowIndex = -1;
                string selectedProjectId = null;
                if (dataGridView1.CurrentRow != null)
                {
                    currentRowIndex = dataGridView1.CurrentRow.Index;
                    selectedProjectId = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                }

                string sql = @"SELECT 
                    p.ID_Pr,
                    p.Name as ProjectName,
                    p.Des as Description,
                    p.PDS as StartDate,
                    p.PDE as EndDate,
                    p.FDS as FactStartDate,
                    p.FDE as FactEndDate,
                    CONCAT(e.LName, ' ', e.Name, ' ', ISNULL(e.Pat, '')) as ResponsibleName
                    FROM Project p
                    LEFT JOIN Project_Employee pe ON p.ID_Pr = pe.Pr_ID AND pe.Emp_resp = 1
                    LEFT JOIN Employee e ON pe.Emp_ID = e.ID_Emp
                    WHERE 
                    (
                        p.FDE IS NULL OR GETDATE() <= p.FDE
                    )
                    OR
                    (
                        p.FDE IS NULL
                    )
                    ORDER BY p.PDE";

                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connect.Close();

                dataGridView1.DataSource = dt;

                // Настраиваем отображение колонок при первой загрузке
                if (dataGridView1.Columns.Count > 0 && dataGridView1.Columns[0].HeaderText != "Название проекта")
                {
                    ConfigureGridColumns();
                }

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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка проектов: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridColumns()
        {
            // Скрываем ID проекта
            dataGridView1.Columns[0].Visible = false;

            // Настраиваем заголовки
            dataGridView1.Columns[1].HeaderText = "Название проекта";
            dataGridView1.Columns[2].HeaderText = "Описание";
            dataGridView1.Columns[3].HeaderText = "Плановая дата начала";
            dataGridView1.Columns[4].HeaderText = "Плановая дата окончания";
            dataGridView1.Columns[5].HeaderText = "Фактическая дата начала";
            dataGridView1.Columns[6].HeaderText = "Фактическая дата окончания";
            dataGridView1.Columns[7].HeaderText = "Ответственный";

            // Форматирование дат
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd.MM.yyyy";

            // Настройка ширины колонок
            dataGridView1.Columns[1].Width = 150;  // Название проекта
            dataGridView1.Columns[2].Width = 150;  // Описание
            dataGridView1.Columns[3].Width = 100;  // Плановая дата начала
            dataGridView1.Columns[4].Width = 100;  // Плановая дата окончания
            dataGridView1.Columns[5].Width = 100;  // Фактическая дата начала
            dataGridView1.Columns[6].Width = 100;  // Фактическая дата окончания
            dataGridView1.Columns[7].Width = 200;  // Ответственный

            // Автоматическое расширение описания
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

    }
}
