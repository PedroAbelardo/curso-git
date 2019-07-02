using System;

namespace BigBangTheoryBazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sheldon, Raj;
            Game g = new Game(); // criei um objeto sem construtores

            int t = int.Parse(Console.ReadLine()); //numero inteiro indicando a quantidade de cenários a serem testados //

            if (t <= 100) // numero tem que ser menor ou igual a 100 pelo que eu entendi no problema 
            {

                int[] v = new int[t]; // criei um vetor para para armazenar as respostas 

                for (int i = 1; i <= t; i++) // criei uma estrutura de repetição que vai depender do numero inteiro que você indicou
                {
                    string[] list = Console.ReadLine().Split(' '); 
                    Sheldon = (list[0]); //entrada 1
                    Raj = (list[1]);    //entrada 2

                    Console.WriteLine("Caso #{0}: {1}",i,g.Vencedor(Sheldon,Raj)); //criei um metodo Vencedor para ver retornar apenas a resposta
                }
            }
        }
    }
}
