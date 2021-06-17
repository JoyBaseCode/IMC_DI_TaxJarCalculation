using System.Collections.Generic;

namespace IMC_DI_TaxJarCalculation
{
    public class Order
    {
        public string from_country { get; set; }//from_country: US,   
        public string from_zip { get; set; }//from_zip: 07001,   
        public string from_state { get; set; }//from_state: NJ,   
        public string to_country { get; set; }//to_country: US,   
        public string to_zip { get; set; }//to_zip: 07446,   
        public string to_state { get; set; }//to_state: NJ,   
        public decimal amount { get; set; }//amount: 16.50,   
        public decimal shipping { get; set; }//shipping: 1.5,   
        public List<OrderLineItem> line_items { get; set; }//line_items: [   
        //  {   
        //    quantity: 1,   
        //    unit_price: 15.0,   
        //    product_tax_code: 31000   
        //  }   
        //]
    }
}