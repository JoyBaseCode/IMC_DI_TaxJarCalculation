using IMC_DI_TaxJarCalculation.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC_DI_TaxJarCalculation
{
    public sealed class TaxCalcService
    {
        public string BaseRequestUrl { get; set; }
        public string AuthToken { get; set; }
        public TaxCalcService(string _BaseRequestUrl,string _AuthToken)
        {
            BaseRequestUrl = _BaseRequestUrl;
            AuthToken = _AuthToken;
        }

        public LocationTaxRate GetLocationTaxRates(Location location)
        {
            var client = new RestClient(string.Format(BaseRequestUrl + "/rates/{0}?country={1}&city={2}", location.Zip, location.Country, location.City))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Token token=\"" + AuthToken + "\"");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            LocationTaxRate taxRate = SimpleJson.DeserializeObject<LocationTaxRate>(response.Content);
            try
            {
                
                if (taxRate != null)
                {
                    return taxRate;
                }
            }catch
            {
                //error logging
            }
            //Try to get rates or return null
            return null;
        }


        public OrderTax GetTaxesForOrder(Order order) 
        {
            var client = new RestClient(BaseRequestUrl + "/taxes")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Token token=\"" + AuthToken + "\"");
            request.AddHeader("Content-Type", "application/json");
            var body = SimpleJson.SerializeObject(order);

            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

            try
            {
                var orderTax = SimpleJson.DeserializeObject<OrderTax>(response.Content);
                if (orderTax != null)
                {
                    return orderTax;
                }
            }
            catch (Exception ex)
            {
                //error logging
            }

            return null;
        }
    }
}
