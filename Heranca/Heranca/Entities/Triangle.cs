using Heranca.Entities.Enums;

namespace Heranca.Entities
{
    class Triangle : Shape //Classe filha da classe pai Shape
    {
        public double Width { get; set; }   //Metodos getters and setters 
                                            //Encapsulamento
        public double Height { get; set; }  //Metodos getters and setters

        public Triangle (double width, double height, Color color) : base(color) //metodos construtores
        {
            Width = width;
            Height = height;
        }

        public override double Area() //Metodo abstrato herdado da classe pai Shape
                                      //polimorfismo
        {
            return (Width * Height) / 2;
        }
    }
}
