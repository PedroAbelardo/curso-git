using System;
using System.Globalization;

namespace Exe2EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            int numInteiro = int.Parse(Console.ReadLine());

            if(numInteiro < 0)
                Console.WriteLine("NEGATIVO !!!");
            else
                Console.WriteLine("NÃO NEGATIVO !!!");
            ------------------------------------------------------
            //Exercício 2

            int numInteiro = int.Parse(Console.ReadLine());

            if (numInteiro % 2 == 0)
                Console.WriteLine("PAR !!!");
            else
                Console.WriteLine("IMPAR !!!");
            -------------------------------------------------------           
            //Exercício 3

            string[] numInteiro = Console.ReadLine().Split(' ');
            int a = int.Parse(numInteiro[0]);
            int b = int.Parse(numInteiro[1]);

            if(a % b == 0 || b % a == 0)
                Console.WriteLine("São Multiplos !!!");
            else
                Console.WriteLine("Não são Multiplos !!!");
            --------------------------------------------------------
            //Exercício 4
            int duracao;

            string[] vet = Console.ReadLine().Split(' ');
            int horaI = int.Parse(vet[0]);
            int horaF = int.Parse(vet[1]);

            if (horaI < horaF)
                duracao = horaF - horaI;
            else
                duracao = 24 - horaI + horaF;

            if (duracao > 1 && duracao <= 24)
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            else
                Console.WriteLine("IMPOSSIVEL !!!");
            ----------------------------------------------------------------
            //Exercício 5

            string[] vet = Console.ReadLine().Split(' ');
            int codItem = int.Parse(vet[0]);
            int qtdItem = int.Parse(vet[1]);

            float total = 0;

            if (codItem == 1)
                total = qtdItem * 4.0f;
            else if (codItem == 2)
                total = qtdItem * 4.5f;
            else if (codItem == 3)
                total = qtdItem * 5.0f;
            else if (codItem == 4)
                total = qtdItem * 2.0f;
            else if (codItem == 5)
                total = qtdItem * 1.5f;

            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            -------------------------------------------------------------------------------------           
            //Exercício 6

            float x = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (x >= 0 && x <= 25)
                Console.WriteLine("INTERVALO: [0,25]");
            else if (x > 25 && x <= 50)
                Console.WriteLine("INTERVALO: (25,50]");
            else if (x > 50 && x <= 75)
                Console.WriteLine("INTERVALO: (50,75]");
            else if (x > 75 && x <= 100)
                Console.WriteLine("INTERVALO: (75,100]");
            else
                Console.WriteLine("FORA DO INTERVALO !!!");
            -----------------------------------------------------------                
            //Exercício 7

            string[] vet = Console.ReadLine().Split(' ');
            float x = float.Parse(vet[0],CultureInfo.InvariantCulture);
            float y = float.Parse(vet[1],CultureInfo.InvariantCulture);

            if(x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            else if(x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if(x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if(x > 0 && y < 0)
                Console.WriteLine("Q4");
            else 
                Console.WriteLine("Origem");
            ------------------------------------------------------------
            */
            //Exercício 8

            float IR;

            float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 2000)
                IR = 0;
            else if (salario <= 3000)
                IR = (salario - 2000) * 0.08f;
            else if (salario <= 4500)
                IR = (salario - 3000) * 0.18f + 1000 * 0.08f;
            else
                IR = (salario - 4500) * 0.28f + 1500 * 0.18f + 1000 * 0.08f;

            if (IR == 0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + IR.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
