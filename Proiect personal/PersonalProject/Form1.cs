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
 
namespace PersonalProject
{
    public partial class Form1 : Form
    {
        private string filepath;
        public Form1()
        {
            InitializeComponent();
            filepath = "";
            button2.Enabled = false; // stingem butonul de procesare
        }

        private void LoadFile(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if( dr == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                button2.Enabled = true;
            }
            else
            {
                filepath = "";
                button2.Enabled = false;
            }
        }

        private void ProcessFile(object sender, EventArgs e)
        {
            List<Student> classlist = new List<Student>();

            StreamReader sr = new StreamReader(filepath);

            while( !sr.EndOfStream) // pana cand nu e sfarsitul fisierului
            {
                // citim linia
                string line = sr.ReadLine();

                // ignoram linia de titlu
                if( line.StartsWith("#") || line.StartsWith("Students"))
                {
                    continue;
                }

                string[] data = line.Split(',');

                string name = data[0];
                Student s = new Student(name);

                for( int i = 1; i < data.Length; i++)
                {
                    s.Grades.Add(int.Parse(data[i])); // pentru fiecare nota din lista facem parse din string in int

                }

                // Adaugam acest student la lista classList
                classlist.Add(s);
            }

            sr.Close();

            // folosim LINQ query pentru a gasi nota medie pentru fiecare student
            var query = from student in classlist
                        orderby student.GetAverage() descending
                        select student;

            richTextBox1.Clear();
            foreach( var item in query )
            {
                richTextBox1.AppendText(String.Format("{0} => {1:F}\n", item.Name, item.GetAverage()));
            }
        }
    }
}
