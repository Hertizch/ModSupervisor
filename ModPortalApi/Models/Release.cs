using Newtonsoft.Json;

namespace ModPortalApi.Models
{
    public class Release
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("downloads_count")]
        public long DownloadsCount { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("factorio_version")]
        public string FactorioVersion { get; set; }

        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        [JsonProperty("info_json")]
        public InfoJson InfoJson { get; set; }

        [JsonProperty("file_size")]
        public long FileSize { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
