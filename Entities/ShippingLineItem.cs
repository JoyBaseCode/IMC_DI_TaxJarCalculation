using System;
using System.Collections.Generic;
using System.Text;

namespace IMC_DI_TaxJarCalculation.Entities
{
    public class ShippingLineItem : TaxLineItem
    {
        public decimal special_taxable_amount { get; set; }//            "special_taxable_amount": 0.0,
    }
}
