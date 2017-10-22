using Newtonsoft.Json;

namespace ModPortalApi.Models
{
    public class Result
    {
        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("current_user_rating")]
        public object CurrentUserRating { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("game_versions")]
        public string[] GameVersions { get; set; }

        [JsonProperty("downloads_count")]
        public long DownloadsCount { get; set; }

        [JsonProperty("github_path")]
        public string GithubPath { get; set; }

        [JsonProperty("license_url")]
        public string LicenseUrl { get; set; }

        [JsonProperty("ratings_count")]
        public long RatingsCount { get; set; }

        [JsonProperty("license_flags")]
        public long LicenseFlags { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("license_name")]
        public string LicenseName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("media_files")]
        public object[] MediaFiles { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("releases")]
        public Release[] Releases { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
