using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    class Student
    {
        //Proprietati
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        //Constructii
        public Student()
        {
            Grades = new List<int>();
        }

        public Student( string name)
        {
            Name = name;
            Grades = new List<int>(); 
        }

        public double GetAverage()
        {
            return Grades.Average(); // folosim metoda LINQ pentru a calcula media tuturor notelor din lista 
        }
    }
}
