using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //clasă care implementează interfața InterfaceCalc
    public class Calc : InterfaceCalc
    {
        private double firstNum = 0;
        private double memory = 0;

        public void Put_A(double firstNum)
        {
            this.firstNum = firstNum;
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

        public double Subtraction(double secondNum)
        {
            return firstNum - secondNum;
        }

        public double SqrtX(double secondNum) // procent
        {
            return (firstNum / secondNum)*100;
        }

        public double Sqrt()
        {
            return Math.Sqrt(firstNum);
        }

        public double Square()
        {
            return Math.Pow(firstNum, 2.0);
        }

        //afișează conținutul registrului de memorie
        public double MemoryShow()
        {
            return memory;
        }

        //ștergeți conținutul registrului de memorie
        public void Memory_Clear()
        {
            memory = 0.0;
        }

        // + - la registrul de memorie

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
