using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T: ");
            int T = int.Parse(Console.ReadLine());

            string[] v = new string[T];

            for (int i = 0; i < T; i++)
            {
                v[i] = Console.ReadLine();
                string S = v[i];

                S.Trim();

                if(String.Valida(v[i]) == true)
                {
                    S.ToCharArray();

                    string sequencia = " ";
                    for (int j = 0; j < v[i].Length; j++)
                        sequencia += S;
                    1
                        Console.WriteLine(sequencia);
                }
            }
        }
    }
}
