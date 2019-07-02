using System;
using System.Text.RegularExpressions;


namespace Palindrome
{
    class String
    {
        public static bool Valida(string str)
        {
            
            bool valido = true;
            string correta = "^[a-zA-Z]$";
            if (!Regex.IsMatch(str, correta))
            {
                valido = false;
            }

                return valido;
        }
    }
}
