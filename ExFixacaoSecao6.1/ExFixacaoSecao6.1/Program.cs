using System;
using System.Globalization;

namespace ExFixacaoSecao6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] e = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            if(n >= 1 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Aluguel #{0}:",i + 1);
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("E-mail: ");
                    string email = Console.ReadLine();

                    Console.Write("Quarto: ");
                    int quartos = int.Parse(Console.ReadLine());

                    e[quartos] = new Estudante(nome, email);
                    Console.WriteLine();
                }
                Console.WriteLine("Quartos Ocupados: ");
                for (int i = 0; i < 10; i++)
                {
                    if(e[i] != null)
                        Console.WriteLine(i + ": " + e[i]);
                }
            }
        }
    }
}
