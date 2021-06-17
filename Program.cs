using RestSharp;
using System;
using System.Collections.Generic;

namespace IMC_DI_TaxJarCalculation
{
    class Program
    {
        private static object order;

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

        private static object GetTaxForOrder(object order)
        {
            var client = new RestClient("https://api.taxjar.com/v2/taxes");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Token token=\"YOUR API TOKEN\"");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"  ""from_country"": ""US""," + "\n" +
            @"  ""from_zip"": ""07001""," + "\n" +
            @"  ""from_state"": ""NJ""," + "\n" +
            @"  ""to_country"": ""US""," + "\n" +
            @"  ""to_zip"": ""07446""," + "\n" +
            @"  ""to_state"": ""NJ""," + "\n" +
            @"  ""amount"": 16.50," + "\n" +
            @"  ""shipping"": 1.5," + "\n" +
            @"  ""line_items"": [" + "\n" +
            @"    {" + "\n" +
            @"      ""quantity"": 1," + "\n" +
            @"      ""unit_price"": 15.0," + "\n" +
            @"      ""product_tax_code"": ""31000""" + "\n" +
            @"    }" + "\n" +
            @"  ]" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static object GetRatesByLocaion(object location)
        {
            var client = new RestClient("https://api.taxjar.com/v2/rates/90404?country=US&city=Santa Monica");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Token token=\"5da2f821eee4035db4771edab942a4cc\"");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response.Content;
        }
    }
}
