using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Microsoft.Office.Interop.Word;


namespace HRD
{
    public partial class ReportWorkLoad : Form
    {
        public ReportWorkLoad()
        {
            InitializeComponent();
        }
        String[][] testData = {
            new String[]{ "Иван Иванов Иванович","Управляющий","Хороший","0"},
            new String[]{ "Петр Петров Петрович","Работник","Средний","5000"},
            new String[]{ "Сидор Сидоров Сидорович","Наблюдающий","Плохой","10000"},
            };
        private void ReportWorkLoad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }

        private void createB_Click(object sender, EventArgs e)
        {
            Spire.Doc.Document doc = new Spire.Doc.Document();
            doc.LoadFromFile(@"ReportWorkloadExample.docx");
            doc.Replace("#DateStart#", dateTimePicker1.Value.ToShortDateString(), true, true);
            doc.Replace("#DateEnd#", dateTimePicker2.Value.ToShortDateString(), true, true);
            doc.Replace("#Post#", "Программист", true, true);
            doc.Replace("#DateToday#", DateTime.Today.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("#Name#",comboBox1.Text,true,true);
            Spire.Doc.Section section = doc.Sections[0];
            Spire.Doc.Table table = section.Tables[0] as Spire.Doc.Table;
            for (int r = 0; r < testData.Length; r++){
                table.AddRow();
                TableRow DataRow = table.Rows[r+1];
                for (int c = 0; c < testData[r].Length+1; c++){
                    Spire.Doc.Documents.Paragraph p2 = DataRow.Cells[c].AddParagraph();
                    if (c == 0)
                    {
                        p2.AppendText((Array.IndexOf(testData, testData[r])+1).ToString());
                    }
                    else p2.AppendText(testData[r][c-1]);
                }
            }
            doc.SaveToFile("ReportWorkload.docx");
            this.Close();
            Process.Start(@"ReportWorkload.docx");
        }
    }
}
