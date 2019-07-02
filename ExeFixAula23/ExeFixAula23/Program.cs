using System;
using System.Globalization;

namespace ExeFixAula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            String nomet = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com o preço de um produto:");
            double b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Entre com seu último nome, idade e altura(mesma linha):");
            String[] v = Console.ReadLine().Split(' ');
            String unome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomet);
            Console.WriteLine(a);
            Console.WriteLine(b.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(unome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
