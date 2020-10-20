using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    // Interfata 
    public interface InterfaceCalc
    {
        //а - primul argument, b - al doilea argument
        void Put_A(double firstNum); // a salva а

        void Clear_A();

        double Multiplication(double secondNum);

        double Division(double secondNum);

        double Sum(double secondNum);

        double Subtraction(double secondNum); 

        double SqrtX(double secondNum);

        double DegreeY(double secondNum);

        double Sqrt();

        double Square();

        double Factorial();

        double MemoryShow(); // aratati continutul registrului de memorie

        void Memory_Clear(); // stergeti continutul registrului de memorie

        //* / + - la registru
        void M_Multiplication(double secondNum);

        void M_Division(double secondNum);

        void M_Sum(double secondNum);

        void M_Subtraction(double secondNum); 
    }
}
