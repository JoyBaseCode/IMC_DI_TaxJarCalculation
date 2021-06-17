using RestSharp;
using System;
using System.Collections.Generic;

namespace IMC_DI_TaxJarCalculation
{
    class Program
    {
        public static object location { get; private set; }

        static void Main(string[] args)
        {
            var tcs = new TaxCalcService("https://api.taxjar.com/v2", "5da2f821eee4035db4771edab942a4cc");


            object rates = tcs.GetLocationTaxRates(new Location { City = "Santa Monica", Zip = "90404", Country = "US" });

            object taxfororder = tcs.GetTaxesForOrder(new Order 
                {
                    from_country = "US",
                    from_zip = "07001",
                    from_state = "NJ",
                    to_country = "US",
                    to_zip = "07446",
                    to_state = "NJ",
                    amount = Convert.ToDecimal(16.5),
                    shipping = Convert.ToDecimal(1.5),
                    line_items = new System.Collections.Generic.List<OrderLineItem>
                    {
                        new OrderLineItem
                        {
                            quantity = 1,
                            unit_price = Convert.ToDecimal(15.0),
                            product_tax_code = "31000"
                        }
                    }
                }
            );

        }
    }
}
