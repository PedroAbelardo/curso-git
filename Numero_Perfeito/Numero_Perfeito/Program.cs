using System;

namespace Numero_Perfeito
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); //Numero inteiro T, indicando a quantidade de cenários a serem testados

            int[] v = new int[t]; //Criação do vetor

            for(int i = 0;i < t; i++) //Estrutura de repetição para ler os numeros 
            {
                v[i] = int.Parse(Console.ReadLine()); //Saida dos Numeros Inteiros

                int x = v[i]; //armazenei o valor da saida numa variavel X, para facilitar o entendimento

                if(x >= 1 && x <= 108)
                    {                       /*Ficou meio confuso no problema o trecho:  "X(1 <= x <= 108)",acredito que
                            seja para colocar um if e verificar se ele é maior ou igual que 1 e menor ou igual a 108*/
                    
                    int soma = 0;   /*Criei uma variável soma, para somar os valores divisíveis por x*/

                    for (int k = 1; k < x; k++) /* Criei um for que vai do número 1 até a variavel x(saida dos numeros inteiros)*/
                        if (x % k == 0) // criei um if que vai verificar se o numero é divisível por x
                            soma += k; 

                    if(soma == x)
                        Console.WriteLine("{0} eh perfeito",x);
                    else
                        Console.WriteLine("{0} não é perfeito",x);
                }

            }
        }
    }
}
