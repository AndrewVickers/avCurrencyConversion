using System;
using System.Net.Http;
using System.Threading.Tasks;
using CurrencyConversion.ExternalModels;
using Newtonsoft.Json;

namespace CurrencyConversion.Services
{
    public class Repository: IRepository
    {
        private IHttpClientFactory _httpClientFactory;

        public Repository(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }

        public async Task<RootObject> GetConversion(string source, string target)
        {
            const string apiKey = "20a80955ce6608cfcf59";
            var httpClient = _httpClientFactory.CreateClient();
            var response =
                await httpClient.GetAsync(
                    $"https://free.currconv.com/api/v7/convert?q={source}_{target}&compact=ultra&apiKey={apiKey}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            }

            return null;
        }
    }
}