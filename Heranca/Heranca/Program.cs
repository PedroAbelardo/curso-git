using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca.Entities;
using Heranca.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle, Circle, Square or Triangle (r/c/s/t)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red/Yellow): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width1, height1, color));
                }
                else if (ch == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                else if (ch == 't')
                {
                    Console.Write("Width: ");
                    double width2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Triangle(width2, height2, color));
                }
                else
                {
                    Console.Write("Width: ");
                    double width3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Square(width3, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}