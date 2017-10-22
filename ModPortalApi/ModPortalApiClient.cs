using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ModPortalApi.Models;
using Newtonsoft.Json;

namespace ModPortalApi
{
    public class ModPortalApiClient
    {
        public ModPortalApiClient()
        {
            
        }

        private const string ApiResponseUrl = "https://mods.factorio.com/api/mods?page_size=max";
        private WebClient _webClient;

        public ApiData ApiData { get; set; }

        public async Task GetModInfo(string request)
        {
            var json = await GetJson(request);

            if (string.IsNullOrEmpty(json)) return;

            ApiData = JsonConvert.DeserializeObject<ApiData>(json, JsonSerializerSettings);
        }

        private async Task<string> GetJson(string request)
        {
            Debug.WriteLine($"[INFO] Called {typeof(Task<string>)} {nameof(GetJson)} with parameter: {request}");

            string json = null;
            Exception exception = null;

            using (_webClient = new WebClient { Proxy = null })
            {
                try
                {
                    json = await _webClient.DownloadStringTaskAsync($"{ApiResponseUrl}{request}");
                }
                catch (Exception ex)
                {
                    exception = ex;
                    Debug.WriteLine($"[ERROR] Execution of {typeof(Task<string>)} {nameof(GetJson)} failed. Exception message: {ex.Message}");
                }
                finally
                {
                    if (exception == null)
                        Debug.WriteLine($"[SUCCESS] Execution of {typeof(Task<string>)} {nameof(GetJson)} succeeded");
                }
            }

            return json;
        }

        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            NullValueHandling = NullValueHandling.Ignore
        };
    }
}
