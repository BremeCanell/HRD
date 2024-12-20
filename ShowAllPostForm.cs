using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRD
{
    public partial class ShowAllPostForm : Form
    {
        public ShowAllPostForm()
        {
            InitializeComponent();
        }
        public string selectedPost = "";
        private bool addMode = true;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=DESKTOP-FPP7TIE;Initial Catalog=HRD_DB;Trusted_Connection=True";
        private void ShowAllPostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet1.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter1.Fill(this.hRD_DBDataSet1.Post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.hRD_DBDataSet.Post);
            //TODO

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
                string id_po = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Post WHERE ID_Po=" + id_po;
                Sq(sql);
                OnPostChanged?.Invoke();
            }
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Делать возврат если у формы стоит тег checkPost
            if (this.Tag!=null && this.Tag.ToString() == "checkPost")
            {
                if (e.RowIndex >= 0)
                {
                    selectedPost = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        

        private void confirmB_Click(object sender, EventArgs e)
        {
            // Проверяем, что введено число
            if (!decimal.TryParse(textBox1.Text.Replace(',', '.'), 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.CultureInfo.InvariantCulture, 
                out decimal pay))
            {
                MessageBox.Show("Оклад должен быть числом!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем название и оклад через ValidationHelper
            string errorMessage;
            if (!ValidationHelper.ValidatePost(textBox10.Text, pay, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Если валидация пройдена, продолжаем сохранение
            string payStr = textBox1.Text;
            if (-1 != textBox1.Text.IndexOf(','))
            {
                payStr = textBox1.Text.Replace(',', '.');
            }

            if (addMode)
            {
                string sql = "INSERT INTO Post VALUES('" + textBox10.Text + "','" + payStr + "');";
                Sq(sql);
                if (dataGridView1.RowCount != 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    SelectRow(dataGridView1.Rows.Count-1);
                }
                OnPostChanged?.Invoke();
            }
            else
            {
                int n_po = dataGridView1.CurrentRow.Index;
                string id_po = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Post SET Name ='" + textBox10.Text + "',Pay='"+ payStr + "' WHERE ID_Po=" + id_po + ";";
                Sq(sql);
                dataGridView1.CurrentCell = dataGridView1.Rows[n_po].Cells[1];
                SelectRow(n_po);
                OnPostChanged?.Invoke();
            }
            TurnDefaultMode();
        }

        public void UpdatePostTable()
        {

                // Загружаем данные из базы данных напрямую
                string sql = "SELECT ID_Po, Name, Pay FROM Post";
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
            UpdatePostTable();
        }
        public void SelectRow(int rowIndex)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
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

        public delegate void PostChangedHandler();
        public event PostChangedHandler OnPostChanged;
    }
}
