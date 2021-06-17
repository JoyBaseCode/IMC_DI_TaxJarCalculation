using System.Collections.Generic;

namespace IMC_DI_TaxJarCalculation.Entities
{
    public class OrderBreakdown
    {
        public decimal city_tax_collectable { get; set; }//        "city_tax_collectable": 0.0,
        public float city_tax_rate { get; set; }//        "city_tax_rate": 0.0,
        public decimal city_taxable_amount { get; set; }//        "city_taxable_amount": 0.0,
        public float combined_tax_rate { get; set; }//        "combined_tax_rate": 0.06625,
        public decimal county_tax_collectable { get; set; }//        "county_tax_collectable": 0.0,
        public float county_tax_rate { get; set; }//        "county_tax_rate": 0.0,
        public decimal county_taxable_amount { get; set; }//        "county_taxable_amount": 0.0,
        public List<OrderTaxLineItem> line_items { get; set; }
        //        "line_items": [
        //            {
        //                "city_amount": 0.0,
        //                "city_tax_rate": 0.0,
        //                "city_taxable_amount": 0.0,
        //                "combined_tax_rate": 0.06625,
        //                "county_amount": 0.0,
        //                "county_tax_rate": 0.0,
        //                "county_taxable_amount": 0.0,
        //                "id": "1",
        //                "special_district_amount": 0.0,
        //                "special_district_taxable_amount": 0.0,
        //                "special_tax_rate": 0.0,
        //                "state_amount": 0.99,
        //                "state_sales_tax_rate": 0.06625,
        //                "state_taxable_amount": 15.0,
        //                "tax_collectable": 0.99,
        //                "taxable_amount": 15.0
        //            }
        //        ],

        public ShippingLineItem shipping { get; set; }
        //        "shipping": {
        //            "city_amount": 0.0,
        //            "city_tax_rate": 0.0,
        //            "city_taxable_amount": 0.0,
        //            "combined_tax_rate": 0.06625,
        //            "county_amount": 0.0,
        //            "county_tax_rate": 0.0,
        //            "county_taxable_amount": 0.0,
        //            "special_district_amount": 0.0,
        //            "special_tax_rate": 0.0,
        //            "special_taxable_amount": 0.0,
        //            "state_amount": 0.1,
        //            "state_sales_tax_rate": 0.06625,
        //            "state_taxable_amount": 1.5,
        //            "tax_collectable": 0.1,
        //            "taxable_amount": 1.5
        //        },
        public decimal special_district_tax_collectable { get; set; }//        "special_district_tax_collectable": 0.0,
        public decimal special_district_taxable_amount { get; set; }//        "special_district_taxable_amount": 0.0,
        public float special_tax_rate { get; set; }//        "special_tax_rate": 0.0,
        public decimal state_tax_collectable { get; set; }//        "state_tax_collectable": 1.09,
        public float state_tax_rate { get; set; }//        "state_tax_rate": 0.06625,
        public decimal state_taxable_amount { get; set; }//        "state_taxable_amount": 16.5,
        public decimal tax_collectable { get; set; }//        "tax_collectable": 1.09,
        public decimal taxable_amount { get; set; }//        "taxable_amount": 16.5
    }
}