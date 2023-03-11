using FluentValidation;
using Tmf.Hunter.Core.Constants;
using Tmf.Hunter.Core.RequestModels;

namespace Tmf.Hunter.Api.Validations
{
    public class TaskDetailValidator : AbstractValidator<TaskDetailRequest>
    {
        public TaskDetailValidator()
        {
            RuleFor(x => x.RequestId).NotEmpty().WithMessage(ValidationMessages.RequestId);
            RuleFor(x => x.RequestType).NotEmpty().WithMessage(ValidationMessages.RequestType);
        }
    }
}
