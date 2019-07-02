using System;
using System.Globalization;

namespace ExercícioDeIPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            Pessoa p1, p2; 
             
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            -------------------------------------------------------------
            */
            //Exercício 2
            Pessoa p1, p2;
            float salarioM;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salarioM = (p1.Salario + p2.Salario) / 2;

            Console.Write("Salario Médio = " + salarioM.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
