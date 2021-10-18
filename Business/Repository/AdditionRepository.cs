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
    public class AdditionRepository : IAdditionRepository

    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public AdditionRepository(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<AdditionDTO> CreateAddition(AdditionDTO addition)
        {
            var amenity = _mapper.Map<AdditionDTO, Addition>(addition);
            amenity.CreatedBy = "";
            amenity.CreatedDate = DateTime.UtcNow;
            amenity.UpdatedBy = "";
            amenity.UpdatedDate = DateTime.UtcNow;
            amenity.Timming = "";
            
            var addedHotelAmenity = await _context.Additions.AddAsync(amenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<Addition, AdditionDTO>(addedHotelAmenity.Entity);
        }

        public async Task<AdditionDTO> UpdateAddition(int amenityId, AdditionDTO hotelAmenity)
        {
            var amenityDetails = await _context.Additions.FindAsync(amenityId);
            var amenity = _mapper.Map<AdditionDTO, Addition>(hotelAmenity, amenityDetails);
            amenity.UpdatedBy = "";
            amenity.UpdatedDate = DateTime.UtcNow;
            var updatedamenity = _context.Additions.Update(amenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<Addition, AdditionDTO>(updatedamenity.Entity);
        }

        public async Task<int> DeleteAddition(int amenityId, string userId)
        {
            var amenityDetails = await _context.Additions.FindAsync(amenityId);
            if (amenityDetails != null)
            {
                _context.Additions.Remove(amenityDetails);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<List<AdditionDTO>> GetAllAdditions()
        {
            return _mapper.Map<List<Addition>, List<AdditionDTO>>(await _context.Additions.ToListAsync());
        }

        public async Task<AdditionDTO> GetAddition(int amenityId)
        {
            var amenityData = await _context.Additions
                .FirstOrDefaultAsync(x => x.Id == amenityId);

            if (amenityData == null)
            {
                return null;
            }
            return _mapper.Map<Addition, AdditionDTO>(amenityData);
        }

        public async Task<AdditionDTO> IsSameNameAdditionAlreadyExists(string name)
        {
            try
            {
                var amenityDetails =
                    await _context.Additions.FirstOrDefaultAsync(x => x.Name.ToLower().Trim() == name.ToLower().Trim()
                    );
                return _mapper.Map<Addition, AdditionDTO>(amenityDetails);
            }
            catch (Exception ex)
            {

            }
            return new AdditionDTO();
        }

    }
}
