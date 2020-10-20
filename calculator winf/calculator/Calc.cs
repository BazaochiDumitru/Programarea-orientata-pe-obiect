using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //clasa care realizeaza interfata grafica a calculatorului
    public class Calc : InterfaceCalc
    {
        private double firstNum = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.firstNum = a;
        }

        public void Clear_A()
        {
            firstNum = 0;
        }

        public double Multiplication(double secondNum)
        {
            return firstNum * secondNum;
        }

        public double Division(double secondNum)
        {
            return firstNum / secondNum;
        }

        public double Sum(double secondNum)
        {
            return firstNum + secondNum;
        }

        public double Subtraction(double secondNum) // impartire
        {
            return firstNum - secondNum;
        }

        public double SqrtX(double secondNum)
        {
            return Math.Pow(firstNum, 1 / secondNum);
        }

        public double DegreeY(double secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }

        public double Sqrt()
        {
            return Math.Sqrt(firstNum);
        }

        public double Square()
        {
            return Math.Pow(firstNum, 2.0);
        }

        public double Factorial()
        {
            double f = 1;

            for (int i = 1; i <= firstNum; i++)
                f *= (double)i;

            return f;
        }

        // aratati continutul registrului de memorie
        public double MemoryShow()
        {
            return memory;
        }

        // a sterge continutul registrului de memorie 
        public void Memory_Clear()
        {
            memory = 0.0;
        }

        //* / + - la registrul de memorie
        public void M_Multiplication(double secondNum)
        {
            memory *= secondNum;
        }

        public void M_Division(double secondNum)
        {
            memory /= secondNum;
        }

        public void M_Sum(double secondNum)
        {
            memory += secondNum;
        }

        public void M_Subtraction(double secondNum)
        {
            memory -= secondNum;
        }

    }
}
