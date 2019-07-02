using Heranca.Entities.Enums;
using System;

namespace Heranca.Entities 
{
    class Square : Shape // Classe filha da classe pai Shape 
    {
        public double Width { get; set; }   //Metodos getters and setters
                                            //Encapsulamento

        public Square (double width, Color color) : base(color) //Metodo Construtor 
        {
            Width = width;
        }

        public override double Area() //Metodo abstrato herdado da classe pai Shape
                                      //polimorfismo
        {
            return Math.Pow(Width, 2);
        }
    }
}
