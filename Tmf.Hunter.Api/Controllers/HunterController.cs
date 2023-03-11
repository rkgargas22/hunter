using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Tmf.Hunter.Core.Constants;
using Tmf.Hunter.Core.Exception;
using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Core.ResponseModels;
using Tmf.Hunter.Manager.Interfaces;

namespace Tmf.Hunter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HunterController : ControllerBase
    {
        private readonly IHunterManager _hunterManager;
        private readonly IValidator<ValidateCustomerRequest> _validateCustomeValidator;

        public HunterController(IHunterManager hunterManager, IValidator<ValidateCustomerRequest> validateCustomerValidator)
        {
            _hunterManager = hunterManager;
            _validateCustomeValidator = validateCustomerValidator;
        }

        [HttpPost]
        [Route("ValidateCustomer")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ValidateCustomerResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> ValidateCustomer([FromHeader(Name = "BpNo")] string BpNo, [FromHeader(Name = "UserType")] string UserType, [FromBody] ValidateCustomerRequest validateCustomerRequest)
        {
            ValidationResult result = await _validateCustomeValidator.ValidateAsync(validateCustomerRequest);

            if (!result.IsValid)
            {
                return BadRequest(new ErrorResponse { Message = ValidationMessages.GeneralValidationErrorMessage, Error = result.Errors.Select(m => m.ErrorMessage) });
            }
            var data = await _hunterManager.ValidateCustomer(validateCustomerRequest);

            if (data != null && string.IsNullOrEmpty(data.RequestId))
            {
                return BadRequest(new ErrorResponse { Message = ValidationMessages.ErrorInRequest, Error = data });
            }
            return CreatedAtAction(nameof(ValidateCustomer), new { data.RequestId }, data);
        }
    }
}
