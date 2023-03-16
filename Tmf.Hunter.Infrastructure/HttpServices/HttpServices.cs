using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using Tmf.Hunter.Core.Options;
using Microsoft.Extensions.Options;

namespace Tmf.Hunter.Infrastructure.HttpServices
{
    public class HttpServices : IHttpServices
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HunterOptions _options;
        public HttpServices(IHttpClientFactory httpClientFactory, IOptions<HunterOptions> options)
        {
            _httpClientFactory = httpClientFactory;
            _options = options.Value;
        }

        public async Task<JsonDocument> GetAsync(string uri)
        {
            var httpClient = _httpClientFactory.CreateClient();

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add(_options.ApiTokenType, _options.ApiTokenKey);
            httpClient.DefaultRequestHeaders.Add(_options.SecretKeyType, _options.ApiSecretKey);

            HttpResponseMessage response = await httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }            
            return await response.Content.ReadFromJsonAsync<JsonDocument>();

        }

        public async Task<JsonDocument> HunterAuthToken<TIn>(string uri, TIn model)
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add(_options.HunterAuthTokenCredentials.domain_id, _options.HunterAuthTokenCredentials.domain_value);
            httpClient.DefaultRequestHeaders.Add("X-Correlation-Id", Guid.NewGuid().ToString());

            HttpResponseMessage response = await httpClient.PostAsync(uri, new StringContent(JsonSerializer.Serialize(model), UnicodeEncoding.UTF8, "application/json"));
            return await response.Content.ReadFromJsonAsync<JsonDocument>();
        }

        public async Task<JsonDocument> PostAsync<TIn>(string uri, string accessToken, TIn model)
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //httpClient.DefaultRequestHeaders.Add(_options.ApiTokenType, _options.ApiTokenKey);
            //httpClient.DefaultRequestHeaders.Add(_options.SecretKeyType, _options.ApiSecretKey);
            httpClient.DefaultRequestHeaders.Add(_options.DomainId, _options.DomainValue);
            httpClient.DefaultRequestHeaders.Add("X-Correlation-Id", Guid.NewGuid().ToString());

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            HttpResponseMessage response = await httpClient.PostAsync(uri, new StringContent(JsonSerializer.Serialize(model), UnicodeEncoding.UTF8, "application/json"));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            return await response.Content.ReadFromJsonAsync<JsonDocument>();
        }
        
    }
}
