using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISmartPhoneOrderDetailRepository
    {
        public Task<SmartPhoneOrderDetailDTO> Create(SmartPhoneOrderDetailDTO details);
        public Task<SmartPhoneOrderDetailDTO> MarkPaymentSuccessful(int id);
        public Task<SmartPhoneOrderDetailDTO> GetSmartphoneOrderDetail(int roomOrderId);
        public Task<List<SmartPhoneOrderDetailDTO>> GetAllSmartphoneOrderDetails();
        public Task<bool> UpdateOrderStatus(int RoomOrderId, string status);
    }
}
