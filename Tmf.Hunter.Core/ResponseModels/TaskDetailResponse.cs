using System.Text.Json.Serialization;

namespace Tmf.Hunter.Core.ResponseModels
{
    public class TaskDetailResponse
    {
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; } = string.Empty;
    }
}
