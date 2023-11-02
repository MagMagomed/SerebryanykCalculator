using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator
{
    public class Calculator
    {
        private decimal coefficient;
        public Calculator()
        {
            coefficient = 3m / 25000m;
        }

        public decimal SerebryanykToRuble(decimal value)
        {
            return value * 10;
        }

        public decimal RealRubleToSerebryanyk(decimal rubles )
        {
            return coefficient * rubles;
        }
        public decimal SerebryanykToRealRuble(decimal serebryanyks )
        {
            return serebryanyks / coefficient;
        }
    }
}
