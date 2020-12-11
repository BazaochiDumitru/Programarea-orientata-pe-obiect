using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Studente
    {
        private int id;
        private string nume;
        private string prenume;
        private int varsta;
        private string grupa;
        private double nota;

        public Studente() { }

        public Studente(int id, string nume, string prenume, int varsta, string grupa, double nota)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.grupa = grupa;
            this.nota = nota;
        }

        public void SalvareFisierului(int id, string nume, string prenume, int varsta, string grupa, double nota)
        {
            FileStream file = new FileStream(@"G:\Stick\University\Anul 2 Semestrul 1\Programarea orientata pe obiect\Personal\Students\studente.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(id.ToString() + "/");
            writer.Write(nume + "/");
            writer.Write(prenume + "/");
            writer.Write(varsta.ToString() + "/");
            writer.Write(grupa + "/");
            writer.WriteLine(nota.ToString());
            writer.Close();
        }

        public void IncarcaFisierul(DataTable dataTable)
        {
            string[] linie = File.ReadAllLines(@"G:\Stick\University\Anul 2 Semestrul 1\Programarea orientata pe obiect\Personal\Students\studente.txt");
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

        public void StergeStudent(int id, DataTable table)
        {
            string path = @"D:\Stick\University\Anul 2 Semestrul 1\Programarea orientata pe obiect\Personal\Students\studente.txt";

            var linie = File.ReadAllLines(path).ToList();
            string[] valoarea;

            for (int i = 0; i < linie.Count; i++)
            {
                valoarea = linie[i].ToString().Split('/');
                if (valoarea[0] == id.ToString())
                {
                    linie.RemoveAt(i);
                    File.WriteAllLines(path, linie);
                }
            }

            IncarcaFisierul(table);
        }

    }
}
