using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeFixacaoSecao6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados vão ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #{0}: ", i + 1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                while (list.Find(x => x.Id == id) != null)
                { //verifica se o ID existe, para isso verifica se o retorno é diferente de nulo
                    //ou seja, se for diferente de nulo o ID já existe, então esta sendo usado
                    Console.Write("ID já existe, por favor insira outra id válido: ");
                    id = int.Parse(Console.ReadLine());
                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, sal));
                Console.WriteLine();
            }

            Console.Write("Entre com o id do empregado que irá aumentar o salario: ");
            int eas = int.Parse(Console.ReadLine());

            Funcionario fun = list.Find(x => x.Id == eas);

            if (fun != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                fun.AumentarSalario(porc);
            }
            else
                Console.WriteLine("Esse id não existe !!!");

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos empregados: ");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
