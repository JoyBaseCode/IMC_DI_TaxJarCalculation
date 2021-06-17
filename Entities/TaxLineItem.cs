using System;
using System.Collections.Generic;
using System.Text;

namespace IMC_DI_TaxJarCalculation.Entities
{
    public class TaxLineItem
    {
        public double city_amount { get; set; }//                "city_amount": 0.0,
        public double city_tax_rate { get; set; }//                "city_tax_rate": 0.0,
        public double city_taxable_amount { get; set; }//                "city_taxable_amount": 0.0,
        public double combined_tax_rate { get; set; }//                "combined_tax_rate": 0.06625,
        public double county_amount { get; set; }//                "county_amount": 0.0,
        public double county_tax_rate { get; set; }//                "county_tax_rate": 0.0,
        public double county_taxable_amount { get; set; }//                "county_taxable_amount": 0.0,
        public double special_district_amount { get; set; }//                "special_district_amount": 0.0,
        public double special_district_taxable_amount { get; set; }//                "special_district_taxable_amount": 0.0,
        public double special_tax_rate { get; set; }//                "special_tax_rate": 0.0,
        public double state_amount { get; set; }//                "state_amount": 0.99,
        public double state_sales_tax_rate { get; set; }//                "state_sales_tax_rate": 0.06625,
        public double state_taxable_amount { get; set; }//                "state_taxable_amount": 15.0,
        public double tax_collectable { get; set; }//                "tax_collectable": 0.99,
        public double taxable_amount { get; set; }//                "taxable_amount": 15.0
        //"city_amount": 0,
        //  "city_tax_rate": 0,
        //  "city_taxable_amount": 0,
        //  "combined_tax_rate": 0.06625,
        //  "county_amount": 0,
        //  "county_tax_rate": 0,
        //  "county_taxable_amount": 0,
        //  "id": "1",
        //  "special_district_amount": 0,
        //  "special_district_taxable_amount": 0,
        //  "special_tax_rate": 0,
        //  "state_amount": 0.99,
        //  "state_sales_tax_rate": 0.06625,
        //  "state_taxable_amount": 15,
        //  "tax_collectable": 0.99,
        //  "taxable_amount": 15
    }
}
