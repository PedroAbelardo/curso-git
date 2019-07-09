using System;
using ExFixacaoSecao10._2.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExFixacaoSecao10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>(); //lista de Pagadores que podem ser físicos ou jurídicos

            for (int i = 1; i <= n;)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                if (ch != 'i' && ch != 'c')
                {
                    Console.WriteLine("Wrong answer !!! Type i or c");
                }
                else if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));

                    i++;
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));

                    i++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach(TaxPayer tp in list)
            {
                Console.WriteLine(tp.ToString());
                sum += tp.Tax();             
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ {0}",sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
