using System.Text.Json.Serialization;

namespace Tmf.Hunter.Core.RequestModels
{
    public class ValidateCustomerRequest
    {
        [JsonPropertyName("header")]
        public Header Header { get; set; }        

        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }
                
    }

    public class Header
    {
       
        [JsonPropertyName("clientReferenceId")]
        public string ClientReferenceId { get; set; }

        [JsonPropertyName("expRequestId")]
        public string ExpRequestId { get; set; }

        [JsonPropertyName("messageTime")]
        public DateTime MessageTime { get; set; }

        [JsonPropertyName("options")]
        public object Options { get; set; }

        [JsonPropertyName("requestType")]
        public string RequestType { get; set; }

        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("txnId")]
        public string TxnId { get; set; }
    }


    public class Payload
    {
        [JsonPropertyName("application")]
        public Application Application { get; set; }

        [JsonPropertyName("contacts")]
        public List<Contacts> Contacts { get; set; }


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
        public Person Person { get; set; }
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

}
