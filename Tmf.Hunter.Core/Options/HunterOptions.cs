namespace Tmf.Hunter.Core.Options
{
    public class HunterOptions
    {
        public const string Hunter = "Hunter";
        public string ApiTokenType { get; set; } = string.Empty;
        public string ApiTokenKey { get; set; } = string.Empty;
        public string SecretKeyType { get; set; } = string.Empty;
        public string ApiSecretKey { get; set; } = string.Empty;
        public string DomainId { get; set; } = string.Empty;
        public string DomainValue { get; set; } = string.Empty;
        public UrlData Url { get; set; }
        public AuthTokenCredentialsData HunterAuthTokenCredentials { get; set; }
    }
    public class UrlData
    {
        public string HunterApplication { get; set; } = string.Empty;
        public string BaseURL { get; set; } = string.Empty;
    }

    public class AuthTokenCredentialsData
    {
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string client_id { get; set; } = string.Empty;
        public string client_secret { get; set; } = string.Empty;
        public string domain_id { get; set; } = string.Empty;
        public string domain_value { get; set; } = string.Empty;
        public string url { get; set; } = string.Empty;
    }
}
