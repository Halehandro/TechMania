using Business.Repository.IRepository;
using DataAcess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Common;

namespace Business.Repository
{
    public class SmartPhoneOrderDetailRepository : ISmartPhoneOrderDetailRepository

    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public SmartPhoneOrderDetailRepository(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<SmartPhoneOrderDetailDTO> Create(SmartPhoneOrderDetailDTO details)
        {
            try
            {
                var smartphonedb = _context.SmartPhones
                    .FirstOrDefaultAsync(u => u.Id == details.SmartPhoneDTO.Id);
                if (smartphonedb.Result != null)
                {
                    smartphonedb.Result.Quantity -= details.OrderQuantity;
                    var savedId = await _context.SaveChangesAsync();
                }

                details.CheckInDate = details.CheckInDate.Date;
                details.CheckOutDate = details.CheckOutDate.Date;
                var phoneOrder = _mapper.Map<SmartPhoneOrderDetailDTO, SmartPhoneOrderDetails>(details);
                phoneOrder.Status = SD.Status_Pending;
                var result = await _context.SmartPhoneOrderDetails.AddAsync(phoneOrder);
                await _context.SaveChangesAsync();
                return _mapper.Map<SmartPhoneOrderDetails, SmartPhoneOrderDetailDTO>(result.Entity);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<List<SmartPhoneOrderDetailDTO>> GetAllSmartphoneOrderDetails()
        {
            try
            {
                List<SmartPhoneOrderDetailDTO> phoneOrders = _mapper.Map<List<SmartPhoneOrderDetails>, List<SmartPhoneOrderDetailDTO>>
                    (_context.SmartPhoneOrderDetails.Include(u => u.SmartPhone).ToList());

                return phoneOrders;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<SmartPhoneOrderDetailDTO> GetSmartphoneOrderDetail(int phoneOrderId)
        {
            try
            {
                SmartPhoneOrderDetails phoneOrder = await _context.SmartPhoneOrderDetails
                    .Include(u => u.SmartPhone).ThenInclude(x => x.SmartPhoneImages)
                    .FirstOrDefaultAsync(u => u.Id == phoneOrderId);

                SmartPhoneOrderDetailDTO phoneOrderDetailsDTO = _mapper.Map<SmartPhoneOrderDetails, SmartPhoneOrderDetailDTO>(phoneOrder);

                return phoneOrderDetailsDTO;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<SmartPhoneOrderDetailDTO> MarkPaymentSuccessful(int id)
        {
            var data = await _context.SmartPhoneOrderDetails.FindAsync(id);
            if (data == null)
            {
                return null;
            }
            if (!data.IsPaymentSuccessful)
            {
                data.IsPaymentSuccessful = true;
                data.Status = SD.Status_Ordered;
                var markPaymentSuccessful = _context.SmartPhoneOrderDetails.Update(data);
                await _context.SaveChangesAsync();
                return _mapper.Map<SmartPhoneOrderDetails, SmartPhoneOrderDetailDTO>(markPaymentSuccessful.Entity);
            }
            return new SmartPhoneOrderDetailDTO();
        }

        public async Task<bool> UpdateOrderStatus(int phoneOrderId, string status)
        {
            try
            {
                var phoneOrder = await _context.SmartPhoneOrderDetails.FirstOrDefaultAsync(u => u.Id == phoneOrderId);
                if (phoneOrder == null)
                {
                    return false;
                }
                phoneOrder.Status = status;
                if (status == SD.Status_OrderConfirmed)
                {
                    phoneOrder.ActualCheckInDate = DateTime.Now;
                }
                if (status == SD.Status_Order_Completed)
                {
                    phoneOrder.ActualCheckOutDate = DateTime.Now;
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
