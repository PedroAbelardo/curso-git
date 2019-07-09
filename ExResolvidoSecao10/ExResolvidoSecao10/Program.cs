using System;
using ExResolvidoSecao10.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExResolvidoSecao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: "); 
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1;i <= n;) //leitura do numero de empregados para adiciona-los na lista
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");  // É ou não funcionário terceirizado ???
                char c = char.Parse(Console.ReadLine().ToLower());

                if (c != 'y' && c != 'n')
                {
                    Console.WriteLine("Wrong awswer !!! Type y or n ");
                }

                else
                {
                    if (c == 'y')    //Se é funcionário terceirizado
                    {
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Hour: ");
                        int hour = int.Parse(Console.ReadLine());

                        Console.Write("Value per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Employee emp = new OutsourcedEmployee(nome, hour, valuePerHour, additionalCharge);

                        if (emp is OutsourcedEmployee)
                        {
                            OutsourcedEmployee ose = (OutsourcedEmployee)emp;
                            list.Add(ose);
                        }
                        else
                            Console.WriteLine("Erro de instanciação !!");

                    }
                    else if (c == 'n')  //Se for não for um funcionário terceirizado
                    {
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Hour: ");
                        int hour = int.Parse(Console.ReadLine());

                        Console.Write("Value per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Employee(nome, hour, valuePerHour));
                    }
                    i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
