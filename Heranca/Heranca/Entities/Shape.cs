using Heranca.Entities.Enums;

namespace Heranca.Entities
{
    abstract class Shape //classe pai ou Super Classe abstrata
    {
        public Color Color { get; set; } //Metodos getters and setters
        public Shape(Color color) //metodo construtor
        {
           Color = color;
        }

        public abstract double Area(); //metodo abstrato pois é um termo genérico 
    }
}
