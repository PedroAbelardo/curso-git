using System;
using System.Collections.Generic;
using System.Text;

namespace DigitsCount
{
    class ValidarInteiro
    {
        public static bool IsNumeric(string valor)
        {
            char[] verificar = valor.ToCharArray();

            foreach (var caracter in verificar)
            {
                if (!char.IsDigit(caracter))
                    return false;
            }

            return true;
        }
    }
}
