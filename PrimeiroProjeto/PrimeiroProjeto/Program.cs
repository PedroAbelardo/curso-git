using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    //byte n aceita numero negativo
                    //o byte so vai ate o numero 255
                    /* Overflow
                     Exemplo: se colocar 255 numa variavel byte e incrementar o numero 1,
                     ele automaticamente vai para o limite oposto, ou seja, ele extrapolou
                     o limite da variavel gerando um Overflow, porque a representação do
                     numero é feita pelo complemento a 2.*/

                    //int.MinValue -> recebe o menor valor de int
                    //int.MaxValue ->  "     " maior valor de int
                    //Isso vale para todas as variaveis também.

                    byte n1 = 126;
                    int n2 = 1000;
                    int n3 = 2147483647;
                    long n4 = 2147483648L;
                    bool completo = false;
                    char genero = '\u0041';
                    float n5 = 4.5f;
                    double n6 = 4.556456;
                    String nome = "Maria";

                    //macete -> cw + TAB + TAB = Console.WriteLine();
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n4);
                    Console.WriteLine(genero);
                    Console.WriteLine(completo);
                    Console.WriteLine(n5);
                    Console.WriteLine(n6.ToString("F2",CultureInfo.InvariantCulture));
                    Console.WriteLine(nome);
                    /*O Console.WriteLine() e o Console.Write() tem o mesmo objetivo
                     * a diferença é que o Console.Write() não pula de linha depois
                     imprimir o valor que queremos imprimir.
                     -----------------------------------------------------------------
                     OBS: No caso da variável float, para especificarmos
                     a quantidade de numeros decimais que queremos, temos que utilizar
                     ToString logo após o nome da variavel no Console.WriteLine()
                     
                     Exemplo:
                     
                     Console.WriteLine(n5.ToString("F2")); -> Irá imprimir o valor com apenas
                     2 casas decimais. Se fosse F3 seria 3 casas e assim por diante.
                     ------------------------------------------------------------------

                    OBS 2 : Observamos que ao compilar, o numero imprimido vem com a vírgula,
                    porém se quisermos modificar isso teremos que utilizar o comando 
                    ToString("F Numero de casas que deseja imprimir o decimal",
                    CultureInfo.InvariantCulture). La em cima eu vou ter que usar
                    um outro comando: using System.Globalization;
                    CultureInfo.InvariantCulture -> esse código vai desconsiderar qualquer
                    formatação específica de país
                     */

                }
            }
        }
    }
}
