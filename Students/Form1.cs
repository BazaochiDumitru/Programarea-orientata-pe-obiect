using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Students
{
    public partial class Form1 : Form
    {
        System.Data.DataTable dataTable = new System.Data.DataTable();

        public Form1()
        {
            InitializeComponent();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nume", typeof(string));
            dataTable.Columns.Add("Prenume", typeof(string));
            dataTable.Columns.Add("Varsta", typeof(int));
            dataTable.Columns.Add("Grupa", typeof(string));
            dataTable.Columns.Add("Nota medie", typeof(double));
            dataGridView1.DataSource = dataTable;
        }

        private void Sterge()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void adaugare_Click(object sender, EventArgs e)
        {
            Studente student = new Studente();

            try
            {
                student.SalvareFisierului(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), textBox5.Text, double.Parse(textBox6.Text));
                Sterge();
            }
            catch (Exception)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Trebuie sa completati toate campurile!");
                }
            }
        }

        private void incarca_Click(object sender, EventArgs e)
        {
            Studente studente = new Studente();
            studente.IncarcaFisierul(dataTable);
        }

        private void stergeStudent_Click(object sender, EventArgs e)
        {
            Studente studente = new Studente();

            try
            {
                studente.StergeStudent(int.Parse(textBox7.Text), dataTable);
            }
            catch (Exception)
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Trebuie sa completati toate campurile!");
                }
            }

            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)      // sorteaza dupa nume
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)      // sorteaza dupa varsta
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)      // sorteaza dupa medie
        {
            dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            // obțineți referința primei foi. În mod implicit, numele său este Sheet1.  
            // stocați referința la foaia de lucru 
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // schimbarea numelui foii active
            worksheet.Name = "Exported from Datagridview";
            // stocarea piesei antet în Excel
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // stocarea valorii fiecărui rând și coloană în foaia Excel
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs(@"G:\Stick\University\Anul 2 Semestrul 1\Programarea orientata pe obiect\Toate versiunile de API (Excel)\API(Excel)\API-Excel\result.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Visible = true;
            //app.Quit();
        }
    }
}
