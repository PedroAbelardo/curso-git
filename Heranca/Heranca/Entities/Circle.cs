using Heranca.Entities.Enums;
using System;

namespace Heranca.Entities
{
    class Circle : Shape //Classe filha da classe pai Shape 
    {
        public double Radius { get; set; }  //metodos getters and setters //encapsulamento

        public Circle(double radius, Color color) : base(color) //metodo construtor
        {
            Radius = radius;
        }

        public override double Area()   //Metodo abstrato herdado da classe pai Shape
                                        //polimorfismo
        {
            return Math.PI * Radius * Radius; 
        }
    }
}
