using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    public class SupplierOffer
    {
        public SupplierOffer(string AdPrice, string RealPrice)
        {
            this.AdPrice = AdPrice;
            this.RealPrice = RealPrice;
        }

        public string AdPrice;
        public string RealPrice;
    }
}
