using System;
using System.Globalization;

namespace ExeFixacaoSecao5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb; /*CUIDADO: É necessario criar uma nome para a variavel ContaBancaria aqui,
            pois caso contrario ela não será lida pela MAIN dentro do if else abaixo*/

            Console.Write("Entre com o número da conta: ");
            int nc = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nt = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char c = char.Parse(Console.ReadLine());

            if (c == 'S' || c == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double vp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(nc, nt, vp);
            }
            else
            {
                cb = new ContaBancaria(nc, nt);
            }

            //Mostrando os dados da conta

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cb);
            Console.WriteLine();

            //Realizando deposito e atualizando os dados

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(deposito);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(cb);
            Console.WriteLine();

            //Realizando saque e atualizando os dados

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(saque);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(cb);
        }
    }
}
