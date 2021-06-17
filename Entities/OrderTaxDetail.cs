using System;
using System.Collections.Generic;
using System.Text;

namespace IMC_DI_TaxJarCalculation.Entities
{
    public class OrderTaxDetail
    {
        public string amount_to_collect { get; set; }//    "amount_to_collect": 1.09,
        public OrderBreakdown breakdown { get; set; }//    "breakdown": {
        //        "city_tax_collectable": 0.0,
        //        "city_tax_rate": 0.0,
        //        "city_taxable_amount": 0.0,
        //        "combined_tax_rate": 0.06625,
        //        "county_tax_collectable": 0.0,
        //        "county_tax_rate": 0.0,
        //        "county_taxable_amount": 0.0,
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
        //        "special_district_tax_collectable": 0.0,
        //        "special_district_taxable_amount": 0.0,
        //        "special_tax_rate": 0.0,
        //        "state_tax_collectable": 1.09,
        //        "state_tax_rate": 0.06625,
        //        "state_taxable_amount": 16.5,
        //        "tax_collectable": 1.09,
        //        "taxable_amount": 16.5
        //    },

        public bool freight_taxable { get; set; }//    "freight_taxable": true,
        public bool has_nexus { get; set; }//    "has_nexus": true,
        public OrderJurisdiction jurisdictions { get; set; }//    "jurisdictions": {
        //        "city": "RAMSEY",
        //        "country": "US",
        //        "county": "BERGEN",
        //        "state": "NJ"
        //    },

        public string order_total_amount { get; set; }//    "order_total_amount": 16.5,
        public string rate { get; set; }//    "rate": 0.06625,
        public string shipping { get; set; }//    "shipping": 1.5,
        public string tax_source { get; set; }//    "tax_source": "destination",
        public decimal taxable_amount { get; set; }//    "taxable_amount": 16.5
    }
}
