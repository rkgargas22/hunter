﻿using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Core.ResponseModels;
using Tmf.Hunter.Infrastructure.Interfaces;
using Tmf.Hunter.Manager.Interfaces;

namespace Tmf.Hunter.Manager.Services
{
    public class HunterManager : IHunterManager
    {
        private readonly IHunterRepository _hunterRepository;
        public HunterManager(IHunterRepository hunterRepository)
        {
            _hunterRepository = hunterRepository;
        }
            
        public async Task<ValidateCustomerResponse> ValidateCustomer(ValidateCustomerRequest validateCustomerRequest)
        {           
            ValidateCustomerResponse customerResponse = await _hunterRepository.ValidateCustomer(validateCustomerRequest);
            return customerResponse;
           
        }

    }
}
