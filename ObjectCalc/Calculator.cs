using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalc
{
    internal class Calculator
    {
        public double Secti(double cislo1, double cislo2)
        {
            return cislo1 + cislo2;
        }

        public double Odecti(double cislo1, double cislo2)
        {
            return cislo1 - cislo2;
        }
        public double Vynasob(double cislo1, double cislo2)
        {
            return cislo1 * cislo2;
        }
        public double Vydel(double cislo1, double cislo2)
        {
            return cislo1 / cislo2;
        }
    }
}
