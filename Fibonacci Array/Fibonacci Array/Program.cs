using System;

namespace Fibonacci_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int[] v = new int[t];

            for (int i = 0; i < t; i++)
             {
                v[i] = int.Parse(Console.ReadLine());

                int n = v[i];

                if (n >= 0 && n <= 60)
                {

                    if (v[i] == 0)
                        Console.WriteLine($"Fib({n}) = 0");

                    else if (v[i] == 1)
                        Console.WriteLine($"Fib({n}) = 1");

                    else
                    {
                        int x = 0;
                        int ultimo = 1;
                        int penultimo = 0;
                        for (int j = 1; j < n; j++)
                        {
                            x = ultimo + penultimo;
                            penultimo = ultimo;
                            ultimo = x;
                        }
                        Console.WriteLine($"Fib({n}) = {x}");
                    }
                }
            }
        }
    }
}
