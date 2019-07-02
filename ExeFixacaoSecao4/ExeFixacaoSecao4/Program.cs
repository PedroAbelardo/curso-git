using System;
using System.Globalization;

namespace ExeFixacaoSecao4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + r.Area());
            Console.WriteLine("Perímetro = " + r.Perimetro());
            Console.WriteLine("Diagonal = " + r.Diagonal());
            ------------------------------------------------------------------          
            //Exercício 2
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.AumentarSalario(pct);

            Console.WriteLine("Dados atualizados: " + f);
            -------------------------------------------------------------------------
            */
            //Exercício 3
            Aluno a = new Aluno();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if (a.ConceitoFinal() == true)
                Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + a.Recuperacao().ToString("F2",CultureInfo.InvariantCulture) 
                    + " PONTOS");
            }

        }
    }
}
