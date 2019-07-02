using System;
using System.Collections.Generic;

namespace HashSetSecao6
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < a; i++)
            {
                int codA = int.Parse(Console.ReadLine());
                A.Add(codA);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < b; i++)
            {
                int codB = int.Parse(Console.ReadLine());
                B.Add(codB);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < c; i++)
            {
                int codC = int.Parse(Console.ReadLine());
                C.Add(codC);
            }
            A.UnionWith(B);
            A.UnionWith(C);
            int cont = 0;
            foreach(int x in A)
            {
                cont++;
            }
            Console.WriteLine("Total de alunos: {0}",cont);
        }
    }
}
