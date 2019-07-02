using System;
using System.Globalization;

namespace Exe1EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2

            /*Console.WriteLine("Raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double areaCirculo = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A = " + areaCirculo.ToString("F4",CultureInfo.InvariantCulture));
            ------------------------------------------------------------------------------------
             

            //Exercício 3

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));

            Console.WriteLine($"Diferença = {diferenca}");
            -------------------------------------------------------------------------------------

            //Exercício 4

            int numFuncionario = int.Parse(Console.ReadLine());
            int numHorasTrab = int.Parse(Console.ReadLine());
            float valPorHora = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            float calcSalario = (float) numHorasTrab * valPorHora;

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine("SALARY = U$ " + calcSalario.ToString("F2",CultureInfo.InvariantCulture));
            --------------------------------------------------------------------------------------
 
            //Exercício 5 

            string[] vet1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(vet1[0]);
            int numPeca1 = int.Parse(vet1[1]);
            float valPeca1 = float.Parse(vet1[2],CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vet2[0]);
            int numPeca2 = int.Parse(vet2[1]);
            float valPeca2 = float.Parse(vet2[2],CultureInfo.InvariantCulture);

            float valorPago = (numPeca1 * valPeca1) + (numPeca2 * valPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPago.ToString("F2",CultureInfo.InvariantCulture));
            ---------------------------------------------------------------------------------------
            */

            //Exercício 6

            string[] vet = Console.ReadLine().Split(' ');
            float a = float.Parse(vet[0],CultureInfo.InvariantCulture);
            float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float c = float.Parse(vet[2], CultureInfo.InvariantCulture);

            float areaTrianguloRetangulo = (a * c) / 2;
            float areaCirculo = (float) (3.14159 * Math.Pow(c, 2));
            float areaTrapezio = ((a + b) * c) / 2;
            float areaQuadrado = (float) Math.Pow(b,2);
            float areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
