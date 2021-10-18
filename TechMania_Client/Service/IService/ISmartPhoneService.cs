using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Client.Service.IService
{
    interface ISmartPhoneService
    {
        public Task<List<SmartPhoneDTO>> GetSmartPhones(string Manufacturer);
        public Task<SmartPhoneDTO> GetSmartPhoneDetails(int phoneId);
    }
}
