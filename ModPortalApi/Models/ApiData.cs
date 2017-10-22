using Newtonsoft.Json;

namespace ModPortalApi.Models
{
    public class ApiData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }
}
