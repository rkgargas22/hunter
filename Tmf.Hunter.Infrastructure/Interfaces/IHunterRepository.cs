using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Core.ResponseModels;


namespace Tmf.Hunter.Infrastructure.Interfaces
{
    public interface IHunterRepository
    {
        Task<TaskDetailResponse> ValidateCustomer(ValidateCustomerRequest validateCustomerRequest);       
    }
}
