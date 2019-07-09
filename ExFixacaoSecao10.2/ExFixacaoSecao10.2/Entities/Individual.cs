using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExFixacaoSecao10._2.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00 && HealthExpenditures > 0)
            {
                return AnualIncome * 0.15 - (HealthExpenditures * 0.5);
            }
            else if (AnualIncome >= 20000.00 && HealthExpenditures > 0)
            {
                return AnualIncome * 0.25 - (HealthExpenditures * 0.5);
            }
            else if (AnualIncome < 20000.00 && HealthExpenditures == 0)
            {
                return AnualIncome * 0.15;
            }
            else
                return AnualIncome * 0.25;
        }
        public override string ToString()
        {
            return Name
                + ": $ "
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
