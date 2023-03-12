using System.Text.Json.Serialization;

namespace Tmf.Hunter.Core.ResponseModels
{
    public class ValidateCustomerResponse
    {
        [JsonPropertyName("responseHeader")]
        public ResponseHeader ResponseHeader { get; set; }

        [JsonPropertyName("clientResponsePayload")]
        public ClientResponsePayload ClientResponsePayload { get; set; }

        [JsonPropertyName("originalRequestData")]
        public OriginalRequestData OriginalRequestData { get; set; }

    }

    public class ResponseHeader
    {
        [JsonProperty("clientReferenceId")]
        public string ClientReferenceId { get; set; }

        [JsonProperty("expRequestId")]
        public string ExpRequestId { get; set; }

        [JsonProperty("messageTime")]
        public DateTime MessageTime { get; set; }

        [JsonProperty("overallResponse")]
        public OverallResponse OverallResponse { get; set; }

        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseType")]
        public string ResponseType { get; set; }

        [JsonProperty("tenantID")]
        public string TenantID { get; set; }
    }

    public class ClientResponsePayload
    {
        [JsonPropertyName("decisionElements")]
        public List<DecisionElement> DecisionElements { get; set; }

        [JsonPropertyName("orchestrationDecisions")]
        public List<OrchestrationDecision> OrchestrationDecisions { get; set; }
    }

    public class OriginalRequestData
    {
        [JsonPropertyName("contacts")]
        public List<Contacts> Contacts { get; set; }

        [JsonPropertyName("application")]
        public List<Application> Application { get; set; }
    }


    public class OverallResponse
    {
        [JsonProperty("decision")]
        public string Decision { get; set; }

        [JsonProperty("decisionReasons")]
        public List<string> DecisionReasons { get; set; }

        [JsonProperty("decisionText")]
        public string DecisionText { get; set; }

        [JsonProperty("recommendedNextActions")]
        public List<object> RecommendedNextActions { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("spareObjects")]
        public List<object> SpareObjects { get; set; }
    }
       
    public class OrchestrationDecision
    {
        [JsonPropertyName("appReference")]
        public string AppReference { get; set; }

        [JsonPropertyName("decision")]
        public string Decision { get; set; }

        [JsonPropertyName("decisionReasons")]
        public List<object> DecisionReasons { get; set; }

        [JsonPropertyName("decisionSource")]
        public string DecisionSource { get; set; }

        [JsonPropertyName("decisionText")]
        public string DecisionText { get; set; }

        [JsonPropertyName("nextAction")]
        public string NextAction { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("sequenceId")]
        public string SequenceId { get; set; }
    }

    public class DecisionElement
    {
        [JsonPropertyName("appReference")]
        public string AppReference { get; set; }

        [JsonPropertyName("normalizedScore")]
        public int NormalizedScore { get; set; }

        [JsonPropertyName("otherData")]
        public OtherData OtherData { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; }

        [JsonPropertyName("warningsErrors")]
        public List<WarningsError> WarningsErrors { get; set; }
    }

    public class OtherData
    {
        [JsonPropertyName("response")]
        public Response Response { get; set; }
    }

    public class Response
    {
        [JsonPropertyName("errorWarnings")]
        public ErrorWarnings ErrorWarnings { get; set; }

        [JsonPropertyName("matchSummary")]
        public MatchSummary MatchSummary { get; set; }
    }

    public class ErrorWarnings
    {
        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }

        [JsonPropertyName("warnings")]
        public Warnings Warnings { get; set; }
    }

    public class Errors
    {
        [JsonPropertyName("error")]
        public List<object> Error { get; set; }

        [JsonPropertyName("errorCount")]
        public int ErrorCount { get; set; }
    }

    public class Warnings
    {
        [JsonPropertyName("warning")]
        public List<Warning> Warning { get; set; }

        [JsonPropertyName("warningCount")]
        public int WarningCount { get; set; }
    }

    public class Warning
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("values")]
        public Values Values { get; set; }
    }

    public class Values
    {
        [JsonPropertyName("value")]
        public List<string> Value { get; set; }
    }

    public class MatchSummary
    {
        [JsonPropertyName("matches")]
        public int Matches { get; set; }

        [JsonPropertyName("totalMatchScore")]
        public string TotalMatchScore { get; set; }
    }

    public class WarningsError
    {
        [JsonPropertyName("responseCode")]
        public string ResponseCode { get; set; }

        [JsonPropertyName("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    }



    public class Contacts
    {
        [JsonPropertyName("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonPropertyName("emails")]
        public List<Email> Emails { get; set; }

        [JsonPropertyName("employmentHistory")]
        public List<EmploymentHistory> EmploymentHistory { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("identityDocuments")]
        public List<IdentityDocument> IdentityDocuments { get; set; }

        [JsonPropertyName("telephones")]
        public List<Telephone> Telephones { get; set; }

        [JsonPropertyName("person")]
        public List<Person> Person { get; set; }
    }


    public class Person
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

        [JsonPropertyName("personDetails")]
        public PersonDetails PersonDetails { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("surName")]
        public string SurName { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class PersonDetails
    {
        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonPropertyName("qualificationType")]
        public string QualificationType { get; set; }
    }
    public class Telephone
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }

        [JsonPropertyName("buildingName")]
        public string BuildingName { get; set; }

        [JsonPropertyName("county")]
        public string County { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("postal")]
        public string Postal { get; set; }

        [JsonPropertyName("postTown")]
        public string PostTown { get; set; }

        [JsonPropertyName("stateProvinceCode")]
        public string StateProvinceCode { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("street2")]
        public string Street2 { get; set; }

        [JsonPropertyName("timeAtAddress")]
        public TimeAtAddress TimeAtAddress { get; set; }
    }

    public class Email
    {
        [JsonPropertyName("email")]
        public string EmailAddress { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class EmploymentHistory
    {
        [JsonPropertyName("employerAddress")]
        public EmployerAddress EmployerAddress { get; set; }

        [JsonPropertyName("employerName")]
        public string EmployerName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("timeWithEmployer")]
        public TimeWithEmployer TimeWithEmployer { get; set; }
    }

    public class IdentityDocument
    {
        [JsonPropertyName("documentNumber")]
        public string DocumentNumber { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class TimeAtAddress
    {
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class EmployerAddress
    {
        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }

        [JsonPropertyName("buildingName")]
        public string BuildingName { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("street2")]
        public string Street2 { get; set; }
    }

    public class TimeWithEmployer
    {
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Application
    {
        [JsonPropertyName("applicants")]
        public List<Applicant> Applicants { get; set; }

        [JsonPropertyName("notificationRequired")]
        public bool NotificationRequired { get; set; }

        [JsonPropertyName("originalRequestTime")]
        public DateTime OriginalRequestTime { get; set; }

        [JsonPropertyName("productDetails")]
        public ProductDetails ProductDetails { get; set; }
    }

    public class Applicant
    {
        [JsonPropertyName("applicantType")]
        public string ApplicantType { get; set; }

        [JsonPropertyName("contactId")]
        public string ContactId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class ProductDetails
    {
        [JsonPropertyName("productCode")]
        public string ProductCode { get; set; }

        [JsonPropertyName("productType")]
        public string ProductType { get; set; }
    }

}
