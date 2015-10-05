using Newtonsoft.Json;

namespace BeanstreamDotNetSDK.Domain
{
    public class CreditCard
    {
        [JsonProperty(PropertyName = "card_id", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string CardId { get; set; }
        [JsonProperty(PropertyName = "function", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Function { get; set; }

        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "expiry_month", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string ExpiryMonth { get; set; }

        [JsonProperty(PropertyName = "expiry_year", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string ExpiryYear { get; set; }

        [JsonProperty(PropertyName = "cvd", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Cvd { get; set; }
    }
}
