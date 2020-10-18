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

namespace Datagrigview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            // adaugam coloane
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            dataGridView1.DataSource = table;
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            // get lines from the text file
            string[] lines = File.ReadAllLines(@"C:\Users\user\Desktop\Proiect personal 2\tabel.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
    }
}
