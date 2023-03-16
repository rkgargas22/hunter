using FluentValidation;
using Tmf.Hunter.Core.Constants;
using Tmf.Hunter.Core.RequestModels;

namespace Tmf.Hunter.Api.Validations
{
    public class ValidationCustomerValidator : AbstractValidator<ValidateCustomerRequest>
    {
        public ValidationCustomerValidator()
        {
            //RuleFor(x => x.GroupId).NotEmpty().WithMessage(ValidationMessages.GroupId);
            //RuleFor(x => x.TaskId).NotEmpty().WithMessage(ValidationMessages.TaskId);
            RuleFor(x => x.Header).NotEmpty().WithMessage(ValidationMessages.contacts);
            RuleFor(x => x.Header).SetValidator(new ContactsValidator()).When(x => x.Header != null);
        }
    }
    public class ContactsValidator : AbstractValidator<Header>
    {
        public ContactsValidator()
        {
            RuleFor(x => x.TenantId).NotEmpty().WithMessage(ValidationMessages.id);
            RuleFor(x => x.RequestType).NotEmpty().WithMessage(ValidationMessages.identityDocuments);
            //RuleFor(x => x.identityDocuments).SetValidator(new IdentityDocumentsValidator()).When(x => x.identityDocuments != null);
        }
    }

    //public class IdentityDocumentsValidator : AbstractValidator<identityDocuments>
    //{
    //    public IdentityDocumentsValidator()
    //    {
    //        RuleFor(x => x.id).NotEmpty().WithMessage(ValidationMessages.id);
    //        RuleFor(x => x.documentType).NotEmpty().WithMessage(ValidationMessages.documentType);
    //        RuleFor(x => x.documentNumber).NotEmpty().WithMessage(ValidationMessages.documentNumber);
    //    }
    //}



}
