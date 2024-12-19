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

namespace HRD
{
    public partial class ShowAllQualificationForm : Form
    {
        public ShowAllQualificationForm()
        {
            InitializeComponent();
        }
        public string selectedQual = "";
        private bool addMode = true;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=DESKTOP-FPP7TIE;Initial Catalog=HRD_DB;Trusted_Connection=True";
        private void ShowAllQualificationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet1.Qualification". При необходимости она может быть перемещена или удалена.
            this.qualificationTableAdapter1.Fill(this.hRD_DBDataSet1.Qualification);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Qualification". При необходимости она может быть перемещена или удалена.
            this.qualificationTableAdapter.Fill(this.hRD_DBDataSet.Qualification);
            //TODO
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Qualification". При необходимости она может быть перемещена или удалена.
            if (this.Tag != null)
            {
            }
        }
        private void addB_Click(object sender, EventArgs e)
        {
            TurnAddMode();
        }
        private void changeB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) TurnChangeMode();
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string id_qual = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Qualification WHERE ID_Qual=" + id_qual;
                Sq(sql);
                OnQualificationChanged?.Invoke();
            }
        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            // Проверяем, что введено число
            if (!decimal.TryParse(textBox1.Text.Replace(',', '.'), 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.CultureInfo.InvariantCulture, 
                out decimal coef))
            {
                MessageBox.Show("Коэффициент должен быть числом!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем название и коэффициент через ValidationHelper
            string errorMessage;
            if (!ValidationHelper.ValidateQualification(textBox10.Text, coef, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Если валидация пройдена, продолжаем сохранение
            string coefStr = textBox1.Text;
            if (-1 != textBox1.Text.IndexOf(','))
            {
                coefStr = textBox1.Text.Replace(',', '.');
            }

            if (addMode)
            {
                string sql = "INSERT INTO Qualification VALUES('" + textBox10.Text + "','" + coefStr + "');";
                Sq(sql);
                if (dataGridView1.RowCount != 0)
                {
                    SelectRow(dataGridView1.Rows.Count - 1);
                }
                OnQualificationChanged?.Invoke();
            }
            else
            {
                int n_qual = dataGridView1.CurrentRow.Index;
                string id_qual = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Qualification SET Name ='" + textBox10.Text + "',Coef='" + coefStr + "' WHERE ID_Qual=" + id_qual + ";";
                Sq(sql);
                dataGridView1.CurrentCell = dataGridView1.Rows[n_qual].Cells[1];
                SelectRow(n_qual);
                OnQualificationChanged?.Invoke();
            }
            TurnDefaultMode();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag != null && this.Tag.ToString() == "checkQual")
            {
                if (e.RowIndex >= 0)
                {
                    selectedQual = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }
        public void UpdateQualifiactionTable()
        {
                // Загружаем данные из базы данных напрямую
                string sql = "SELECT ID_Qual, Name, Coef FROM Qualification";
                connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connect.Close();

                // Привязываем данные к DataGridView
                dataGridView1.DataSource = dt;

        }
        public void Sq(string sql)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdateQualifiactionTable();
        }
        public void SelectRow(int rowIndex)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
            dataGridView1.ClearSelection();
            dataGridView1.Rows[rowIndex].Selected = true;
        }
        private void TurnDefaultMode()
        {
            showPanel.Visible = true;
            groupBox1.Visible = false;
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
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = true;
            TurnClearData();
        }
        private void TurnChangeMode()
        {
            showPanel.Visible = false;
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = false;
            if (dataGridView1.Rows.Count != 0)
            {
                textBox10.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void TurnClearData()
        {
            textBox1.Text = string.Empty;
            textBox10.Text = string.Empty;
        }

        public delegate void QualificationChangedHandler();
        public event QualificationChangedHandler OnQualificationChanged;
    }
}
