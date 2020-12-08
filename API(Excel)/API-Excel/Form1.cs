using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace API_Excel
{
    public partial class Form1 : Form
    {
        System.Data.DataTable dataTable = new System.Data.DataTable();
        public Form1()
        {
            InitializeComponent();
            dataTable.Columns.Add("PC ID", typeof(string));
            dataTable.Columns.Add("Procesor", typeof(string));
            dataTable.Columns.Add("Placa de baza", typeof(string));
            dataTable.Columns.Add("RAM", typeof(string));
            dataTable.Columns.Add("HDD/SSD", typeof(string));
            dataTable.Columns.Add("Placa video", typeof(string));
            dataTable.Columns.Add("Bloc de alimentare", typeof(string));
            dataTable.Columns.Add("Case", typeof(string));
            dataTable.Columns.Add("Price", typeof(int));
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e) // importare
        {
            string[] linie = File.ReadAllLines(@"D:\Stick\University\Anul 2 Semestrul 1\Programarea orientata pe obiect\Toate versiunile de API (Excel)\API(Excel)\API-Excel\dateExcel.txt");
            string[] valoarea;

            dataTable.Clear();

            for (int i = 0; i < linie.Length; i++)
            {
                valoarea = linie[i].ToString().Split('/');
                string[] rand = new string[valoarea.Length];

                for (int j = 0; j < valoarea.Length; j++)
                {
                    rand[j] = valoarea[j].Trim();
                }
                dataTable.Rows.Add(rand);
            }
        }

        private void button2_Click(object sender, EventArgs e)  // exportare
        {  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null; 
            app.Visible = true;
            // obțineți referința primei foi. În mod implicit, numele său este Sheet1.  
            // stocați referința la foaia de lucru 
            worksheet = workbook.Sheets["Foaie1"];
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
            workbook.SaveAs("E:\\result.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Visible = true;
            //app.Quit();
        }
        private void button3_Click(object sender, EventArgs e) // calculare
        {
            //lucrul cu Excel
            _Excel.Range Rng;
            _Excel.Workbook xlWB;
            _Excel.Worksheet xlSht;

            _Excel.Application xlApp = new _Excel.Application(); //formam Excel
            xlWB = xlApp.Workbooks.Open("E:\\result.xls"); //deschidem fisierul           
            xlSht = xlWB.Worksheets["Exported from Datagridview"];

            Rng = xlSht.get_Range("I:I"); //Luam valorile de la I2 pana la I4
            double sum = xlApp.WorksheetFunction.Sum(Rng); //calculam suma

            xlWB.Close(true); //salvam si inchidem fisierul
            xlApp.Quit();
            releaseObject(xlSht);
            releaseObject(xlWB);
            releaseObject(xlApp);

            MessageBox.Show("Pretul tuturor calculatoarelor este egala cu: " + sum, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Imposibil de lansat obiectul " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
