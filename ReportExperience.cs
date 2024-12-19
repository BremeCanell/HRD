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
using System.Diagnostics;

namespace HRD
{
    public partial class ReportExperience : Form
    {
        public ReportExperience()
        {
            InitializeComponent();
        }
        String[][] testData = {
            new String[]{ "Иван Иванов Иванович","Управляющий","Хороший","5"},
            new String[]{ "Петр Петров Петрович","Работник","Средний","3"},
            new String[]{ "Сидор Сидоров Сидорович","Наблюдающий","Плохой","0"},
            };
        private void createB_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.LoadFromFile(@"ReportExperienceExample.docx");
            doc.Replace("#DateStart#", dateTimePicker1.Value.ToShortDateString(), true, true);
            doc.Replace("#DateEnd#", dateTimePicker2.Value.ToShortDateString(), true, true);
            doc.Replace("#Post#", "Программист", true, true);
            doc.Replace("#DateToday#", DateTime.Today.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("#Name#", comboBox1.Text, true, true);
            Section section = doc.Sections[0];
            Table table = section.Tables[0] as Table;
            for (int r = 0; r < testData.Length; r++)
            {
                table.AddRow();
                TableRow DataRow = table.Rows[r + 1];
                for (int c = 0; c < testData[r].Length + 1; c++)
                {
                    Paragraph p2 = DataRow.Cells[c].AddParagraph();
                    if (c == 0)
                    {
                        p2.AppendText((Array.IndexOf(testData, testData[r]) + 1).ToString());
                    }
                    else p2.AppendText(testData[r][c - 1]);
                }
            }
            doc.SaveToFile("ReportExperience.docx");
            this.Close();
            Process.Start(@"ReportExperience.docx");
        }

        private void ReportExperience_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }
    }
}
