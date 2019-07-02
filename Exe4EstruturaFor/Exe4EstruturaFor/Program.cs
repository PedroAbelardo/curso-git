using System;
using System.Globalization;

namespace Exe4EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            int n = int.Parse(Console.ReadLine());

            if(n <= 1000)
            for(int i = 1;i <= n;i++)
            {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
            }
            --------------------------------------------------------
            //Exercício 2

            int x = int.Parse(Console.ReadLine());

            int cont = 0, cont2 = 0;
            for (int i = 0; i < x; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20)
                    cont++;
                else
                    cont2++;
            }
            Console.WriteLine($"{cont } in");
            Console.WriteLine($"{cont2} out");
            -----------------------------------------------------
            //Exercício 3

            int x = int.Parse(Console.ReadLine());

            for(int i = 0;i < x; i++)
            {
                string[] v = Console.ReadLine().Split();
                double n1 = double.Parse(v[0],CultureInfo.InvariantCulture);
                double n2 = double.Parse(v[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(v[2], CultureInfo.InvariantCulture);

                double mediaP = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(mediaP.ToString("F1", CultureInfo.InstalledUICulture));
                ---------------------------------------------------------------------------
          //Exercício 4

            int n = int.Parse(Console.ReadLine());
            double resultado = 0.0;
            for (int i = 0; i < n; i++)
            {
                string[] p = Console.ReadLine().Split(' ');
                double n1 = double.Parse(p[0]);
                double n2 = double.Parse(p[1]);

                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));
                }
                else
                    Console.WriteLine("Divisão impossivel");
            }
            --------------------------------------------------------------
            //Exercício 5

            int n = int.Parse(Console.ReadLine());
            int fatorial = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
            ---------------------------------------------------------------
            //Exercício 6

            int n = int.Parse(Console.ReadLine());

            for(int i = 1;i <= n; i++)
            {
                if(n % i == 0)
                    Console.WriteLine(i);
            }
            ----------------------------------------------------------------
            */
            //Exercício 7

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i +" "+ Math.Pow(i,2)+" "+Math.Pow(i,3));
            }
        }
    }
}
