using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;



namespace Tmf.Hunter.Core.ResponseModels
{
    public class HunterAuthTokenResponse
    {        
        [JsonPropertyName("issued_at")]
        public string issued_at { get; set; }
        
        [JsonPropertyName("expires_in")]
        public string expires_in { get; set; }

        [JsonPropertyName("token_type")]
        public string token_type { get; set; }

        [JsonPropertyName("access_token")]
        public string access_token { get; set; }
    }
}
