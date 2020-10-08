using System;

namespace Caliculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                Console.WriteLine("\t Proiect Calculator elaborator de Bazaochi Dumitru");

                try
                {
                    Console.WriteLine("\n Dati cifra nr. 1");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Dati cifra nr. 2");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare va rog sa incercati din nou.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("\n Alegeti operatorul aritmetic: '+' '-' '*' '/'");
                action = Console.ReadLine();

                Console.WriteLine("\n Rezultatul operatiei este:");

                if (action == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else
                {
                    Console.WriteLine("Eroare!");
                }
                Console.ReadLine();
            }
            
        }

    }
}