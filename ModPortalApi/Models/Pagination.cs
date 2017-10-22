using Newtonsoft.Json;

namespace ModPortalApi.Models
{
    public class Pagination
    {
        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("page_count")]
        public long PageCount { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
