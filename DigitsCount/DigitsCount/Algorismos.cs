using System;
using System.Collections.Generic;
using System.Text;

namespace DigitsCount
{
    class Algorismos
    {
        public int qtdCasas(int num)
        {
            int casas = 1;

            while ((num = num / 10) >= 1)
            {
                casas++;
            }
            return casas;
        }
        public int primeiroNum(int num)
        {
            if (num > 0 && num < 10)
            {
                return num % 10;
            }
            else if (num < 100)
            {
                return num / 10;
            }

            else if (num < 1000)
            {
                return num / 100;
            }

            else if (num < 10000)
            {
                return num / 1000;
            }

            else if (num < 100000)
            {
                return num / 10000;
            }

            else if (num < 1000000)
            {
                return num / 100000;
            }

            else if (num < 10000000)
            {
                return num / 1000000;
            }

            else
                return num / 10000000;
        }

        public int segundoNum(int num)
        {
            if (num < 100)
                return num % 10;

            else if (num < 1000)
            {
                num = num % 100 / 10;
                return num;
            }
            else if (num < 10000)
            {
                num = num % 1000 / 100;
                return num;
            }
            else if (num < 100000)
            {
                num = num % 10000 / 1000;
                return num;
            }
            else if (num < 1000000)
            {
                num = num % 100000 / 10000;
                return num;
            }
            else if (num < 10000000)
            {
                num = num % 1000000 / 100000;
                return num;
            }
            else
            {
                num = num % 10000000 / 1000000;
                return num;
            }            
        }
        public int terceiroNum(int num)
        {
            if (num < 1000)
            {
                num = num % 100 % 10;
                return num;
            }
            else if (num < 10000)
            {
                num = num % 1000 % 100 / 10;
                return num;
            }
            else if (num < 100000)
            {
                num = num % 10000 % 1000 % 100 / 10;
                return num;
            }
            else if (num < 1000000)
            {
                num = num % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else if (num < 10000000)
            {
                num = num % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else
            {
                num = num % 10000000 % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
        }
        public int quartoNum(int num)
        {
            if (num < 10000)
            {
                num = num % 1000 % 100 % 10;
                return num;
            }
            else if (num < 100000)
            {
                num = num % 10000 % 1000 % 100 / 10;
                return num;
            }
            else if (num < 1000000)
            {
                num = num % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else if (num < 10000000)
            {
                num = num % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else
            {
                num = num % 10000000 % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
        }
        public int quintoNum(int num)
        {
            if (num < 100000)
            {
                num = num % 10000 % 1000 % 100 % 10;
                return num;
            }
            else if (num < 1000000)
            {
                num = num % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else if (num < 10000000)
            {
                num = num % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else
            {
                num = num % 10000000 % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
        }

        public int sextoNum(int num)
        {
            if (num < 1000000)
            {
                num = num % 100000 % 10000 % 1000 % 100 % 10;
                return num;
            }
            else if (num < 10000000)
            {
                num = num % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
            else
            {
                num = num % 10000000 % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
        }

        public int setimoNum(int num)
        {
            if (num < 100000000)
            {
                num = num % 1000000 % 100000 % 10000 % 1000 % 100 % 10;
                return num;
            }
            else
            {
                num = num % 10000000 % 1000000 % 100000 % 10000 % 1000 % 100 / 10;
                return num;
            }
        }

        public int oitavoNum(int num)
        {
                num = num % 10000000 % 1000000 % 100000 % 10000 % 1000 % 100 % 10;
                return num;
        }
    }
}
