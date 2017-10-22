using Newtonsoft.Json;

namespace ModPortalApi.Models
{
    public class Links
    {
        [JsonProperty("last")]
        public object Last { get; set; }

        [JsonProperty("first")]
        public object First { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("prev")]
        public object Prev { get; set; }
    }
}
