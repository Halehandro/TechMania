using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISmartPhoneRepository
    {
        public Task<SmartPhoneDTO> CreateSmartPhone(SmartPhoneDTO smartPhoneDTO);
        public Task<SmartPhoneDTO> UpdateSmartPhone(int PhoneId, SmartPhoneDTO smartPhoneDTO);
        public Task<SmartPhoneDTO> GetSmartPhone(int PhoneId);
        public Task<bool> IsPhoneSold(int PhoneId);
        public Task<int> DeleteSmartPhone(int PhoneId);
        public Task<List<SmartPhoneDTO>> GetAllSmartPhone(string Manufacturer = null);
        public Task<SmartPhoneDTO> IsPhoneUnique(string name, int phoneId=0);
    }
}
