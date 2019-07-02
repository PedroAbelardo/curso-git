using System;

namespace Exe3EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                //CUIDADO: Não esquecer de colocar a linha seguinte, se não ficara um loop infinito
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
            -----------------------------------------------------------------------------

            //Exercício 2

            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            //Por que não colocamos o ||
            //Porque se pelo menos 1 expressão for correta, ele entra no laço e o resultado pode ser errado
            //Exemplo: entrada: 0 2 
            //0 2 não faz parte do quarto Quadrante
            while (x != 0 && y != 0) {

                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else
                    Console.WriteLine("Quarto");

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
            ----------------------------------------------------------------
            */
            //Execício 3

            int cont1 = 0, cont2 = 0, cont3 = 0;

            int cod = int.Parse(Console.ReadLine()); 

            while (cod != 4)
            {
                //codigo 1 - Alcool
                //codigo 2 - Gasolina
                //codigo 3 - Diesel
                //codigo 4 - FIM

                if (cod > 0 && cod < 4)
                {
                    if (cod == 1)
                        cont1++;
                    else if (cod == 2)
                        cont2++;
                    else
                        cont3++;
                }
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO !!!");
            Console.WriteLine("Alcool: " + cont1);
            Console.WriteLine("Gasolina: " + cont2);
            Console.WriteLine("Diesel: " + cont3);
        }
    }
}
