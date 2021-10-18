using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Client.Service.IService
{
    interface ISmartPhoneOrderDetailService
    {
        public Task<SmartPhoneOrderDetailDTO> SaveSmartPhoneOrderDetails(SmartPhoneOrderDetailDTO details);
        public Task<SmartPhoneOrderDetailDTO> MarkPaymentSuccessful(SmartPhoneOrderDetailDTO details);
    }
}
