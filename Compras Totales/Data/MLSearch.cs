using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Compras_Totales.Data
{
    public class MLSearch : ISearchVendors
    {
        public string vendorName { get ; set; }
        public string logoPath { get; set; }

        public MLSearch()
        {
            this.vendorName = "Mercado Libre";
            this.logoPath = "mercadolibre.svg";
        }

        
        public async Task<List<SearchResponse>> SearchRequestAsync(SearchModel searchName)
        {

            List<SearchResponse> searchViewResults = new();
            // Logic retrieve
            //var bearerToken = GetBearerTokenAsync("TG-619b203a87fb95001a006c97-34996611");

            var searchViewResult = await GetListProductsAsync(searchName);

            //searchViewResults.Add(
            //    new SearchResponse()
            //    {
            //        Name = "Moto G4",
            //        Price = 1600.99M,
            //        Vendor = "Walmart",
            //        ThumbnailPath = "TestData/MotoG4.jpg",
            //        Url = "https://www.mercadolibre.com.mx/moto-g4-16-gb-negro-2-gb-ram/p/MLM6280099"
            //    });
            return searchViewResult;
        }

        private async Task<List<SearchResponse>> GetListProductsAsync(SearchModel searchName)
        {
            List<SearchResponse> searchViewResults = new();

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), $"https://api.mercadolibre.com/sites/MLM/search?q={searchName.searchName}"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer APP_USR-1227389838044175-112216-da8e845d53ee1ec55f864ddc1c00caeb-34996611");
                    try
                    {
                        var response = await httpClient.SendAsync(request).ConfigureAwait(false);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        Root myDeserializedClass = JsonSerializer.Deserialize<Root>(responseBody);
                        return BindResponseML(myDeserializedClass);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
            }

        }

        private List<SearchResponse> BindResponseML(Root myDeserializedClass)
        {
            List<SearchResponse> response = new();
            foreach (var item in myDeserializedClass.Results)
            {
                response.Add(
                    new SearchResponse() { 
                        Price = item.Price,
                        Name = item.Title,
                        Vendor = item.Seller.Permalink,
                        Url = item.Permalink,
                        ThumbnailPath = item.Thumbnail
                    });
            }
            return response;
        }

        private async Task<string> GetBearerTokenAsync(string authToken)
        {
            string bearerToken = "";
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.mercadolibre.com/oauth/token"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");
                    //request.Headers.TryAddWithoutValidation("content-type", "application/x-www-form-urlencoded");

                    var contentList = new List<string>();
                    contentList.Add("grant_type=authorization_code");
                    contentList.Add("client_id=1227389838044175");
                    contentList.Add("client_secret=uVLM7vVoNMAFrVyLFxI5DJVKjoNublVL");
                    contentList.Add("code=TG-619b2abc87fb95001a00721a-34996611");
                    contentList.Add("redirect_uri=https://compras-totales/");
                    request.Content = new StringContent(string.Join("&", contentList));
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
            return bearerToken;
        }
    }
}
