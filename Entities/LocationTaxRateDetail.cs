namespace IMC_DI_TaxJarCalculation
{
    public class LocationTaxRateDetail
    {
        public string city { get; set; } // city: SANTA MONICA,
        public string city_rate { get; set; } //city_rate: 0.0,
        public string combined_district_rate { get; set; }//combined_district_rate: 0.03,
        public string combined_rate { get; set; }//combined_rate: 0.1025,
        public string country { get; set; }//country: US,
        public string country_rate { get; set; }//country_rate: 0.0,
        public string county { get; set; }//county: LOS ANGELES,
        public string county_rate { get; set; }//county_rate: 0.01,
        public bool freight_taxable { get; set; }//freight_taxable: false,
        public string state { get; set; }//state: CA,
        public string state_rate { get; set; }//state_rate: 0.0625,
        public string zip { get; set; }//zip: 90404 --Sample data could be an INT but the format might change to "#####-####"
    }
}