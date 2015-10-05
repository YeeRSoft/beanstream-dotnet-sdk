using Newtonsoft.Json;

namespace BeanstreamDotNetSDK.Domain
{
    public class Token
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
    }
}
