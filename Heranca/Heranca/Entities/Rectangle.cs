using Heranca.Entities.Enums;

namespace Heranca.Entities
{
    class Rectangle : Shape //Classe filha da classe pai Shape 
    {
        public double Width { get; set; }  //Metodos Getters and Setters 
        public double Height { get; set; } //Metodos Getters and Setters 

        public Rectangle(double width, double height, Color color) : base(color) //Metodo Construtor
        {
            Width = width;
            Height = height;
        }

        public override double Area()    //Metodo abstrato herdado da classe pai Shape
                                         //polimorfismo
        {
            return Width * Height;
        }
    }
}
