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

namespace Business.Repository
{
    public class SmartPhoneRepository : ISmartPhoneRepository

    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public SmartPhoneRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<SmartPhoneDTO> CreateSmartPhone(SmartPhoneDTO smartPhoneDTO)
        {
            SmartPhone smartPhone = _mapper.Map<SmartPhoneDTO, SmartPhone>(smartPhoneDTO);
            smartPhone.CreatedDate = DateTime.Now;
            smartPhone.AddedBy = "";

            var addedSmartPhone = await _db.SmartPhones.AddAsync(smartPhone);
            await _db.SaveChangesAsync();
            return _mapper.Map<SmartPhone, SmartPhoneDTO>(addedSmartPhone.Entity);
        }

        public async Task<int> DeleteSmartPhone(int PhoneId)
        {
            var phoneDetails = await _db.SmartPhones.FindAsync(PhoneId);
            if (phoneDetails != null)
            {
                var allimages = await _db.SmartPhoneImages.Where(x => x.PhoneId == PhoneId).ToListAsync();

                _db.SmartPhoneImages.RemoveRange(allimages);
                _db.SmartPhones.Remove(phoneDetails);
                return await _db.SaveChangesAsync();
            }
            else
            {
                return 0;
            }
        }

        public async Task<List<SmartPhoneDTO>> GetAllSmartPhone(string Manufacturer)
        {
            try
            {
                List<SmartPhoneDTO> smartPhoneDTOs = new List<SmartPhoneDTO>();
                if (string.IsNullOrEmpty(Manufacturer))
                {
                    smartPhoneDTOs = _mapper.Map<List<SmartPhone>, List<SmartPhoneDTO>>(_db.SmartPhones.Include(x => x.SmartPhoneImages).ToList());
                }
                else
                {
                    smartPhoneDTOs = _mapper.Map<List<SmartPhone>, List<SmartPhoneDTO>>(_db.SmartPhones.Where(m => m.Manufacturer == Manufacturer).Include(x => x.SmartPhoneImages).ToList());
                }

                return smartPhoneDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<bool> IsPhoneSold(int SmartphoneId)
        {
            try
            {
                if (SmartphoneId > 0)
                {
                    
                    var existingBooking = await _db.SmartPhoneOrderDetails.FirstOrDefaultAsync(x => x.SmartPhoneId == SmartphoneId && x.IsPaymentSuccessful);

                    if (existingBooking != null)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public async Task<SmartPhoneDTO> GetSmartPhone(int PhoneId)
        {
            try
            {
                SmartPhoneDTO smartPhone = _mapper.Map<SmartPhone, SmartPhoneDTO>(
                    await _db.SmartPhones.Include(x => x.SmartPhoneImages).FirstOrDefaultAsync(x => x.Id == PhoneId));

                return smartPhone;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //if unique returns null esle returns room obj
        public async Task<SmartPhoneDTO> IsPhoneUnique(string name, int phoneId = 0)
        {
            try
            {
                if (phoneId == 0)
                {
                    SmartPhoneDTO smartPhone = _mapper.Map<SmartPhone, SmartPhoneDTO>(
                        await _db.SmartPhones.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));

                    return smartPhone;
                }
                else
                {
                    SmartPhoneDTO smartPhone = _mapper.Map<SmartPhone, SmartPhoneDTO>(
                        await _db.SmartPhones.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower() && x.Id != phoneId));

                    return smartPhone;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<SmartPhoneDTO> UpdateSmartPhone(int PhoneId, SmartPhoneDTO smartPhoneDTO)
        {
            try
            {
                if (PhoneId == smartPhoneDTO.Id)
                {
                    //valid
                    SmartPhone phoneDetails = await _db.SmartPhones.FindAsync(PhoneId);
                    SmartPhone phone = _mapper.Map<SmartPhoneDTO, SmartPhone>(smartPhoneDTO, phoneDetails);
                    phone.UpdatedBy = "";
                    phone.UpdatedDate = DateTime.Now;
                    var updatedPhone = _db.SmartPhones.Update(phone);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<SmartPhone, SmartPhoneDTO>(updatedPhone.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
