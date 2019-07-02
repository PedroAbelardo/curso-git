using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFixacaoMetodoEstatico
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double ValorAPagar(double dolar, double quantia)
        {
            double total = quantia * dolar;
            return total * (1 + IOF);
        }
    }
}
