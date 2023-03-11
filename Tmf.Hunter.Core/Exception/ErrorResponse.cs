using System.Text.Json.Serialization;

namespace Tmf.Hunter.Core.Exception
{
    public class ErrorResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("error")]
        public dynamic Error { get; set; } = string.Empty;
    }
}
