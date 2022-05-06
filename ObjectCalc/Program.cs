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
            Console.Write("Zadej 1. číslo: ");
            double cislo1 = double.Parse(Console.ReadLine());
            
            Console.Write("Zadej 2. číslo: ");
            double cislo2 = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();

            Console.WriteLine("Součet: " + calculator.Secti(cislo1, cislo2));
            Console.WriteLine("Rozdíl: " + calculator.Odecti(cislo1, cislo2));
            Console.WriteLine("Součin: " + calculator.Vynasob(cislo1, cislo2));
            Console.WriteLine("Podíl : " + calculator.Vydel(cislo1, cislo2));
            Console.ReadKey();
        }
    }
}