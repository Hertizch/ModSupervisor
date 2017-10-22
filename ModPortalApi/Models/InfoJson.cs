using Newtonsoft.Json;

namespace ModPortalApi.Models
{
    public class InfoJson
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("dependencies")]
        public string[] Dependencies { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("factorio_version")]
        public string FactorioVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
