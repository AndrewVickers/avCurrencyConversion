using Newtonsoft.Json;

namespace CurrencyConversion.ExternalModels
{
    [JsonObject]
    public class RootObject
    {
        public double USD_PHP { get; set; }
    }
}