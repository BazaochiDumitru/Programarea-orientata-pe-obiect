using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciAndPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CheckFibonacci(textBox1.Text);
            CheckPrim(textBox1.Text);
        }

        private void CheckFibonacci(string text)
        {
            if (isFibonacci(Convert.ToInt32(text)))
            {
                FibTrue.Checked = true;
                FibFalse.Checked = false;
            }
            else
            {
                FibTrue.Checked = false;
                FibFalse.Checked = true;
            }
        }

        private void CheckPrim(string text)
        {
            if (isPrim(Convert.ToInt32(text)))
            {
                PrimTrue.Checked = true;
                PrimFalse.Checked = false;
            }
            else
            {
                PrimTrue.Checked = false;
                PrimFalse.Checked = true;
            }
        }

        private bool isFibonacci(int number)
        {
            var fibonacciNumbers = new int[50];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;
            for (var i = 2; i < 50; i++) {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }
            
            var index = 0;
            var find = false;
            while (index < fibonacciNumbers.Length && !find) {
                if (number == fibonacciNumbers[index]) {
                    find = true;
                }
                index++;
            }
            
            return find;
        }

        private static bool isPrim(int number)
        {
            var prim = false;
            var index = 1;
            var dividedNumbers = new int[] {1};
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    dividedNumbers[++index] = i;
                }
            }

            return dividedNumbers.Length == 1;
        }
        /*private static Array getFibonacci(int n)
        {
            var fibonacciNumbers = new int[100];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;
            for (var i = 2; i < n; i++) {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            return fibonacciNumbers;
        }*/
    }
}