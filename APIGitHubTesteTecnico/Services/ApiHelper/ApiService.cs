using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace APIGitHubTesteTecnico.Services.ApiHelper
{
    public class ApiService
    {
        private readonly string BaseURL = "https://api.github.com";

        public HttpClient httpClient { get; set; }
        public ApiService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("APIGitHubTesteTecnico", "1"));
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var contentsJson = await httpClient.GetStringAsync(url).ConfigureAwait(false);
            var result = JsonConvert.DeserializeObject<T>(contentsJson);
            return result;
        }

        public string SetUrl(string controller, string user, string action, int? pagination)
        {
            var pag = pagination is null ? string.Empty : $"?per_page={pagination}";

            return $"{BaseURL}/{controller}/{user}/{action}{pag}";
        }
    }
}