using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();

            Console.Write("Zadej 1. číslo: ");
            calculator.cislo1 = double.Parse(Console.ReadLine());
            
            Console.Write("Zadej 2. číslo: ");
            calculator.cislo2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Součet: " + calculator.Secti());
            Console.WriteLine("Rozdíl: " + calculator.Odecti());
            Console.WriteLine("Součin: " + calculator.Vynasob());
            Console.WriteLine("Podíl: " + calculator.Vydel());
            Console.ReadKey();
        }
    }
}