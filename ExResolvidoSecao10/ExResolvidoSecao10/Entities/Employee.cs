using System;
using System.Collections.Generic;
using System.Text;

namespace ExResolvidoSecao10.Entities
{
    class Employee
    {
        public string Nome { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }
        public Employee(string nome, int hours, double valuePerHour)
        {
            Nome = nome;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() //coloca-se o virtual pois haverá uma sobreposição na classe OutsourcedEmployee(polimorfismo)
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Nome + "- $ " + Payment();
        }
    }
}
