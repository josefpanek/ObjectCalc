using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalc
{
    /// <summary>
    /// Třída reprezentuje kalkulačku, které se zadají 2 čísla a ona
    /// s nimi provádí základní aritmetické operace.
    /// </summary>
    internal class Calculator
    {
        /// <summary>
        /// 1. číslo
        /// </summary>
        public double cislo1;
        /// <summary>
        /// 2. číslo
        /// </summary>
        public double cislo2;
        /// <summary>
        /// Vrací součet atributů
        /// </summary>
        /// <returns>Součet</returns>
        public double Secti()
        {
            return cislo1 + cislo2;
        }
        /// <summary>
        /// Vrací rozdíl atributů
        /// </summary>
        /// <returns>Rozdíl</returns>
        public double Odecti()
        {
            return cislo1 - cislo2;
        }
        /// <summary>
        /// Vrací součin atributů
        /// </summary>
        /// <returns>Součin</returns>
        public double Vynasob()
        {
            return cislo1 * cislo2;
        }
        /// <summary>
        /// Vrací podíl atributů
        /// </summary>
        /// <returns>Podíl</returns>
        public double Vydel()
        {
            return cislo1 / cislo2;
        }
    }
}
