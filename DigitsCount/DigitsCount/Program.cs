using FakeItEasy;
using System;

namespace DigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            Algorismos a = new Algorismos();
            Digits d = new Digits();

            for (int i = 0; i < t; i++)
            {
                    string[] line = Console.ReadLine().Split(' ');
                    int A = int.Parse(line[0]);
                    int B = int.Parse(line[1]);
                string ex1 = null;
                string ex2 = null;
                int cont0 = 0, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0, cont8 = 0, cont9 = 0;

                for (int x = A;x <= B;x++)
                {
                    if(a.qtdCasas(x) == 1)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }                  

                    if (a.qtdCasas(x) == 2)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }
                    else if(a.qtdCasas(x) == 3)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.terceiroNum(x) == 0)
                            cont0++;
                        else if (a.terceiroNum(x) == 1)
                            cont1++;
                        else if (a.terceiroNum(x) == 2)
                            cont2++;
                        else if (a.terceiroNum(x) == 3)
                            cont3++;
                        else if (a.terceiroNum(x) == 4)
                            cont4++;
                        else if (a.terceiroNum(x) == 5)
                            cont5++;
                        else if (a.terceiroNum(x) == 6)
                            cont6++;
                        else if (a.terceiroNum(x) == 7)
                            cont7++;
                        else if (a.terceiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }
                    else if(a.qtdCasas(x) == 4)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.terceiroNum(x) == 0)
                            cont0++;
                        else if (a.terceiroNum(x) == 1)
                            cont1++;
                        else if (a.terceiroNum(x) == 2)
                            cont2++;
                        else if (a.terceiroNum(x) == 3)
                            cont3++;
                        else if (a.terceiroNum(x) == 4)
                            cont4++;
                        else if (a.terceiroNum(x) == 5)
                            cont5++;
                        else if (a.terceiroNum(x) == 6)
                            cont6++;
                        else if (a.terceiroNum(x) == 7)
                            cont7++;
                        else if (a.terceiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quartoNum(x) == 0)
                            cont0++;
                        else if (a.quartoNum(x) == 1)
                            cont1++;
                        else if (a.quartoNum(x) == 2)
                            cont2++;
                        else if (a.quartoNum(x) == 3)
                            cont3++;
                        else if (a.quartoNum(x) == 4)
                            cont4++;
                        else if (a.quartoNum(x) == 5)
                            cont5++;
                        else if (a.quartoNum(x) == 6)
                            cont6++;
                        else if (a.quartoNum(x) == 7)
                            cont7++;
                        else if (a.quartoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }
                    else if (a.qtdCasas(x) == 5)

                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.terceiroNum(x) == 0)
                            cont0++;
                        else if (a.terceiroNum(x) == 1)
                            cont1++;
                        else if (a.terceiroNum(x) == 2)
                            cont2++;
                        else if (a.terceiroNum(x) == 3)
                            cont3++;
                        else if (a.terceiroNum(x) == 4)
                            cont4++;
                        else if (a.terceiroNum(x) == 5)
                            cont5++;
                        else if (a.terceiroNum(x) == 6)
                            cont6++;
                        else if (a.terceiroNum(x) == 7)
                            cont7++;
                        else if (a.terceiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quartoNum(x) == 0)
                            cont0++;
                        else if (a.quartoNum(x) == 1)
                            cont1++;
                        else if (a.quartoNum(x) == 2)
                            cont2++;
                        else if (a.quartoNum(x) == 3)
                            cont3++;
                        else if (a.quartoNum(x) == 4)
                            cont4++;
                        else if (a.quartoNum(x) == 5)
                            cont5++;
                        else if (a.quartoNum(x) == 6)
                            cont6++;
                        else if (a.quartoNum(x) == 7)
                            cont7++;
                        else if (a.quartoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quintoNum(x) == 0)
                            cont0++;
                        else if (a.quintoNum(x) == 1)
                            cont1++;
                        else if (a.quintoNum(x) == 2)
                            cont2++;
                        else if (a.quintoNum(x) == 3)
                            cont3++;
                        else if (a.quintoNum(x) == 4)
                            cont4++;
                        else if (a.quintoNum(x) == 5)
                            cont5++;
                        else if (a.quintoNum(x) == 6)
                            cont6++;
                        else if (a.quintoNum(x) == 7)
                            cont7++;
                        else if (a.quintoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }
                    else if (a.qtdCasas(x) == 6)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.terceiroNum(x) == 0)
                            cont0++;
                        else if (a.terceiroNum(x) == 1)
                            cont1++;
                        else if (a.terceiroNum(x) == 2)
                            cont2++;
                        else if (a.terceiroNum(x) == 3)
                            cont3++;
                        else if (a.terceiroNum(x) == 4)
                            cont4++;
                        else if (a.terceiroNum(x) == 5)
                            cont5++;
                        else if (a.terceiroNum(x) == 6)
                            cont6++;
                        else if (a.terceiroNum(x) == 7)
                            cont7++;
                        else if (a.terceiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quartoNum(x) == 0)
                            cont0++;
                        else if (a.quartoNum(x) == 1)
                            cont1++;
                        else if (a.quartoNum(x) == 2)
                            cont2++;
                        else if (a.quartoNum(x) == 3)
                            cont3++;
                        else if (a.quartoNum(x) == 4)
                            cont4++;
                        else if (a.quartoNum(x) == 5)
                            cont5++;
                        else if (a.quartoNum(x) == 6)
                            cont6++;
                        else if (a.quartoNum(x) == 7)
                            cont7++;
                        else if (a.quartoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quintoNum(x) == 0)
                            cont0++;
                        else if (a.quintoNum(x) == 1)
                            cont1++;
                        else if (a.quintoNum(x) == 2)
                            cont2++;
                        else if (a.quintoNum(x) == 3)
                            cont3++;
                        else if (a.quintoNum(x) == 4)
                            cont4++;
                        else if (a.quintoNum(x) == 5)
                            cont5++;
                        else if (a.quintoNum(x) == 6)
                            cont6++;
                        else if (a.quintoNum(x) == 7)
                            cont7++;
                        else if (a.quintoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.sextoNum(x) == 0)
                            cont0++;
                        else if (a.sextoNum(x) == 1)
                            cont1++;
                        else if (a.sextoNum(x) == 2)
                            cont2++;
                        else if (a.sextoNum(x) == 3)
                            cont3++;
                        else if (a.sextoNum(x) == 4)
                            cont4++;
                        else if (a.sextoNum(x) == 5)
                            cont5++;
                        else if (a.sextoNum(x) == 6)
                            cont6++;
                        else if (a.sextoNum(x) == 7)
                            cont7++;
                        else if (a.sextoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }
                    else if (a.qtdCasas(x) == 7)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.terceiroNum(x) == 0)
                            cont0++;
                        else if (a.terceiroNum(x) == 1)
                            cont1++;
                        else if (a.terceiroNum(x) == 2)
                            cont2++;
                        else if (a.terceiroNum(x) == 3)
                            cont3++;
                        else if (a.terceiroNum(x) == 4)
                            cont4++;
                        else if (a.terceiroNum(x) == 5)
                            cont5++;
                        else if (a.terceiroNum(x) == 6)
                            cont6++;
                        else if (a.terceiroNum(x) == 7)
                            cont7++;
                        else if (a.terceiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quartoNum(x) == 0)
                            cont0++;
                        else if (a.quartoNum(x) == 1)
                            cont1++;
                        else if (a.quartoNum(x) == 2)
                            cont2++;
                        else if (a.quartoNum(x) == 3)
                            cont3++;
                        else if (a.quartoNum(x) == 4)
                            cont4++;
                        else if (a.quartoNum(x) == 5)
                            cont5++;
                        else if (a.quartoNum(x) == 6)
                            cont6++;
                        else if (a.quartoNum(x) == 7)
                            cont7++;
                        else if (a.quartoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quintoNum(x) == 0)
                            cont0++;
                        else if (a.quintoNum(x) == 1)
                            cont1++;
                        else if (a.quintoNum(x) == 2)
                            cont2++;
                        else if (a.quintoNum(x) == 3)
                            cont3++;
                        else if (a.quintoNum(x) == 4)
                            cont4++;
                        else if (a.quintoNum(x) == 5)
                            cont5++;
                        else if (a.quintoNum(x) == 6)
                            cont6++;
                        else if (a.quintoNum(x) == 7)
                            cont7++;
                        else if (a.quintoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.sextoNum(x) == 0)
                            cont0++;
                        else if (a.sextoNum(x) == 1)
                            cont1++;
                        else if (a.sextoNum(x) == 2)
                            cont2++;
                        else if (a.sextoNum(x) == 3)
                            cont3++;
                        else if (a.sextoNum(x) == 4)
                            cont4++;
                        else if (a.sextoNum(x) == 5)
                            cont5++;
                        else if (a.sextoNum(x) == 6)
                            cont6++;
                        else if (a.sextoNum(x) == 7)
                            cont7++;
                        else if (a.sextoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.setimoNum(x) == 0)
                            cont0++;
                        else if (a.setimoNum(x) == 1)
                            cont1++;
                        else if (a.setimoNum(x) == 2)
                            cont2++;
                        else if (a.setimoNum(x) == 3)
                            cont3++;
                        else if (a.setimoNum(x) == 4)
                            cont4++;
                        else if (a.setimoNum(x) == 5)
                            cont5++;
                        else if (a.setimoNum(x) == 6)
                            cont6++;
                        else if (a.setimoNum(x) == 7)
                            cont7++;
                        else if (a.setimoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }
                    else if (a.qtdCasas(x) == 8)
                    {
                        if (a.primeiroNum(x) == 0)
                            cont0++;
                        else if (a.primeiroNum(x) == 1)
                            cont1++;
                        else if (a.primeiroNum(x) == 2)
                            cont2++;
                        else if (a.primeiroNum(x) == 3)
                            cont3++;
                        else if (a.primeiroNum(x) == 4)
                            cont4++;
                        else if (a.primeiroNum(x) == 5)
                            cont5++;
                        else if (a.primeiroNum(x) == 6)
                            cont6++;
                        else if (a.primeiroNum(x) == 7)
                            cont7++;
                        else if (a.primeiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.segundoNum(x) == 0)
                            cont0++;
                        else if (a.segundoNum(x) == 1)
                            cont1++;
                        else if (a.segundoNum(x) == 2)
                            cont2++;
                        else if (a.segundoNum(x) == 3)
                            cont3++;
                        else if (a.segundoNum(x) == 4)
                            cont4++;
                        else if (a.segundoNum(x) == 5)
                            cont5++;
                        else if (a.segundoNum(x) == 6)
                            cont6++;
                        else if (a.segundoNum(x) == 7)
                            cont7++;
                        else if (a.segundoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.terceiroNum(x) == 0)
                            cont0++;
                        else if (a.terceiroNum(x) == 1)
                            cont1++;
                        else if (a.terceiroNum(x) == 2)
                            cont2++;
                        else if (a.terceiroNum(x) == 3)
                            cont3++;
                        else if (a.terceiroNum(x) == 4)
                            cont4++;
                        else if (a.terceiroNum(x) == 5)
                            cont5++;
                        else if (a.terceiroNum(x) == 6)
                            cont6++;
                        else if (a.terceiroNum(x) == 7)
                            cont7++;
                        else if (a.terceiroNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quartoNum(x) == 0)
                            cont0++;
                        else if (a.quartoNum(x) == 1)
                            cont1++;
                        else if (a.quartoNum(x) == 2)
                            cont2++;
                        else if (a.quartoNum(x) == 3)
                            cont3++;
                        else if (a.quartoNum(x) == 4)
                            cont4++;
                        else if (a.quartoNum(x) == 5)
                            cont5++;
                        else if (a.quartoNum(x) == 6)
                            cont6++;
                        else if (a.quartoNum(x) == 7)
                            cont7++;
                        else if (a.quartoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.quintoNum(x) == 0)
                            cont0++;
                        else if (a.quintoNum(x) == 1)
                            cont1++;
                        else if (a.quintoNum(x) == 2)
                            cont2++;
                        else if (a.quintoNum(x) == 3)
                            cont3++;
                        else if (a.quintoNum(x) == 4)
                            cont4++;
                        else if (a.quintoNum(x) == 5)
                            cont5++;
                        else if (a.quintoNum(x) == 6)
                            cont6++;
                        else if (a.quintoNum(x) == 7)
                            cont7++;
                        else if (a.quintoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.sextoNum(x) == 0)
                            cont0++;
                        else if (a.sextoNum(x) == 1)
                            cont1++;
                        else if (a.sextoNum(x) == 2)
                            cont2++;
                        else if (a.sextoNum(x) == 3)
                            cont3++;
                        else if (a.sextoNum(x) == 4)
                            cont4++;
                        else if (a.sextoNum(x) == 5)
                            cont5++;
                        else if (a.sextoNum(x) == 6)
                            cont6++;
                        else if (a.sextoNum(x) == 7)
                            cont7++;
                        else if (a.sextoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.setimoNum(x) == 0)
                            cont0++;
                        else if (a.setimoNum(x) == 1)
                            cont1++;
                        else if (a.setimoNum(x) == 2)
                            cont2++;
                        else if (a.setimoNum(x) == 3)
                            cont3++;
                        else if (a.setimoNum(x) == 4)
                            cont4++;
                        else if (a.setimoNum(x) == 5)
                            cont5++;
                        else if (a.setimoNum(x) == 6)
                            cont6++;
                        else if (a.setimoNum(x) == 7)
                            cont7++;
                        else if (a.setimoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;

                        if (a.oitavoNum(x) == 0)
                            cont0++;
                        else if (a.oitavoNum(x) == 1)
                            cont1++;
                        else if (a.oitavoNum(x) == 2)
                            cont2++;
                        else if (a.oitavoNum(x) == 3)
                            cont3++;
                        else if (a.oitavoNum(x) == 4)
                            cont4++;
                        else if (a.oitavoNum(x) == 5)
                            cont5++;
                        else if (a.oitavoNum(x) == 6)
                            cont6++;
                        else if (a.oitavoNum(x) == 7)
                            cont7++;
                        else if (a.oitavoNum(x) == 8)
                            cont8++;
                        else
                            cont9++;
                    }

                }
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", cont0, cont1, cont2, cont3, cont4, cont5, cont6, cont7, cont8, cont9);
            }

        }
    }
}
