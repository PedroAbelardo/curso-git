using System;
using System.Collections.Generic;
using System.Text;

namespace ExResolvidoSecao10.Entities
{
    class OutsourcedEmployee : Employee // classe OutsourcedEmployee herda da classe Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string nome, int hours, double valuePerHour,double additionalCharge) : 
            base(nome, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
        public override string ToString()
        {
            return Nome + "- $ " + Payment();
        }
    }
}
