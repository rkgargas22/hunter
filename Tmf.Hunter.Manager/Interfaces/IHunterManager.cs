using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Core.ResponseModels;

namespace Tmf.Hunter.Manager.Interfaces
{
    public interface IHunterManager
    {
        Task<ValidateCustomerResponse> ValidateCustomer(ValidateCustomerRequest validateCustomerRequest);
    }
}
