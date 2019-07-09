using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExFixacaoSecao10.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomsFee = customFee;
        }

        public override string PriceTag()
        {
            return Name 
                + " $ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
