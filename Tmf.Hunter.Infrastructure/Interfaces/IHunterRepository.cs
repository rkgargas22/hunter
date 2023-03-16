using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Core.ResponseModels;


namespace Tmf.Hunter.Infrastructure.Interfaces
{
    public interface IHunterRepository
    {
        Task<ValidateCustomerResponse> ValidateCustomer(ValidateCustomerRequest validateCustomerRequest);       
    }
}
