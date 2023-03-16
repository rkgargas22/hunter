using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Net;
using System.Text.Json;
using Tmf.Hunter.Core.Constants;
using Tmf.Hunter.Core.Options;
using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Core.ResponseModels;
using Tmf.Hunter.Infrastructure.HttpServices;
using Tmf.Hunter.Infrastructure.Interfaces;

namespace Tmf.Hunter.Infrastructure.Services
{
    public class HunterRepository : IHunterRepository
    {
        private readonly IHttpServices _httpServices;
        private readonly HunterOptions _options;

        private readonly IConfiguration _configurationManager;
        public HunterRepository(IHttpServices httpServices, IOptions<HunterOptions> options, IConfiguration newConfigurationManager)
        {
            _httpServices = httpServices;
            _options = options.Value;
            this._configurationManager = newConfigurationManager;
        }
        public async Task<ValidateCustomerResponse> ValidateCustomer(ValidateCustomerRequest validateCustomerRequest)
        {
            HunterAuthTokenResponse hunterAuthTokenResponse = await HunterAuthToken();
            var accessToken = hunterAuthTokenResponse.access_token;
            if (!string.IsNullOrEmpty(accessToken))
            {
                var result = await _httpServices.PostAsync(_options.Url.HunterApplication, accessToken, validateCustomerRequest);
                if (result == null)
                {
                    return new ValidateCustomerResponse();
                }

                var jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };

                return JsonSerializer.Deserialize<ValidateCustomerResponse>(result, jsonSerializerOptions);
            }
            else
            {
                return null;
            }     
        }
        private async Task<HunterAuthTokenResponse> HunterAuthToken()
        {  
            var parameters = new Dictionary<string, string>
                    {
                       { "username", _options.HunterAuthTokenCredentials.username },
                       { "password", _options.HunterAuthTokenCredentials.password },
                       { "client_id", _options.HunterAuthTokenCredentials.client_id },
                       { "client_secret", _options.HunterAuthTokenCredentials.client_secret }
                    };
            var result = await _httpServices.HunterAuthToken(_options.HunterAuthTokenCredentials.url, parameters);
            var jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
            return JsonSerializer.Deserialize<HunterAuthTokenResponse>(result, jsonSerializerOptions); 
        }
    }
}
