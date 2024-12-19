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

namespace HRD
{
    public partial class ReportOverdue : Form
    {
        public ReportOverdue()
        {
            InitializeComponent();
        }
        String[][] testData = {
            new String[]{ "Проект1", "10.10.2020", "10.10.2021"},
            new String[]{ "Проект2","10.12.2020","10.05.2021"},
            new String[]{ "Проект3", "10.03.2021", "10.05.2021" },
            };
        private void createB_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.LoadFromFile(@"ReportOverdueExample.docx");
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
                for (int c = 0; c < testData[r].Length + 2; c++)
                {
                    Paragraph p2 = DataRow.Cells[c].AddParagraph();
                    if (c == 0) p2.AppendText((Array.IndexOf(testData, testData[r]) + 1).ToString());
                    else if (c == testData.Length + 1) p2.AppendText((DateTime.ParseExact(testData[r][2], "dd.MM.yyyy", CultureInfo.InvariantCulture) - (DateTime.ParseExact(testData[r][1], "dd.MM.yyyy", CultureInfo.InvariantCulture))).Days.ToString());
                    else p2.AppendText(testData[r][c - 1]);
                }
            }
            doc.SaveToFile("ReportOverdue.docx");
            this.Close();
            Process.Start(@"ReportOverdue.docx");
        }

        private void ReportOverdue_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }
    }
}
