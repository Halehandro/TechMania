using AutoMapper;
using Business.Repository.IRepository;
using DataAcess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class SmartPhoneImagesRepository : ISmartPhoneImagesRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public SmartPhoneImagesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<int> CreateSmartPhoneImage(SmartPhoneImageDTO imageDTO)
        {
            var image = _mapper.Map<SmartPhoneImageDTO, SmartPhoneImage>(imageDTO);
            await _db.SmartPhoneImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteSmartPhoneImageByImageId(int imageId)
        {
            var image = await _db.SmartPhoneImages.FindAsync(imageId);
            _db.SmartPhoneImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteSmartPhoneImageByImageUrl(string imageUrl)
        {
            var allImages = await _db.SmartPhoneImages.FirstOrDefaultAsync(x => x.PhoneImageUrl.ToLower() == imageUrl.ToLower());
            if(allImages==null)
            {
                return 0;
            }
            _db.SmartPhoneImages.Remove(allImages);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteSmartPhoneImageByPhoneId(int phoneId)
        {
            var imageList = await _db.SmartPhoneImages.Where(x=>x.PhoneId == phoneId).ToListAsync();
            _db.SmartPhoneImages.RemoveRange(imageList);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<SmartPhoneImageDTO>> GetSmartPhoneImages(int phoneId)
        {
            return _mapper.Map<IEnumerable<SmartPhoneImage>, IEnumerable<SmartPhoneImageDTO>>(
            await _db.SmartPhoneImages.Where(x => x.PhoneId == phoneId).ToListAsync());
        }
    }
}
