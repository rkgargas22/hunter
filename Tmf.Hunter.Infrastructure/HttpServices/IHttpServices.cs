using System.Text.Json;

namespace Tmf.Hunter.Infrastructure.HttpServices
{
    public interface IHttpServices
    {
        Task<JsonDocument> GetAsync(string uri);

        Task<JsonDocument> PostAsync<TIn>(string uri, string accessToken, TIn model);

        Task<JsonDocument> HunterAuthToken<TIn>(string uri, TIn model);
        

    }
}
