using System;
using System.Collections.Generic;
using System.Globalization;
using ExFixacaoSecao10.Entities;

namespace ExFixacaoSecao10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;i <= n;)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");              
                char c = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(c == 'c')
                {
                    list.Add(new Product(name, price));
                    i++;
                }
                else if(c == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, cf));
                    i++;
                }
                else if(c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                    i++;
                }
                else
                {
                    Console.WriteLine("Wrong answer !!! Type c, u or i");
                }              
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
