using System;

namespace ExFixacaoSecao6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n]; //criação da matriz

            for(int i = 0;i < m; i++) //for para varrer o numero de linhas
            {
                string[] values = Console.ReadLine().Split(' '); //entrada dos numeros da matriz

                for(int j = 0;j < n; j++)//for para varrer o numero de colunas
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            
            for(int i = 0;i < m; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if(x == mat[i, j])
                    {
                        Console.WriteLine("Position {0},{1}:",i,j);
                        if(j > 0) //se a coluna j for maior que 0
                        Console.WriteLine("Left: {0}",mat[i , j-1]);
                        if(i > 0) //se a linha i for maior que 0
                        Console.WriteLine("Up: {0}",mat[i-1 , j]);
                        if((i + j) < n) //se a linha i + j for menor que n
                        Console.WriteLine("Right: {0}",mat[i , j+1]);
                        if((i + 1) < m) //se a linha i + 1 for menor que m
                        Console.WriteLine("Down: {0}",mat[i+1 , j]);
                    }

                }
            }
            
        }
    }
}
