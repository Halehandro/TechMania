using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAdditionRepository
    {
        public Task<AdditionDTO> CreateAddition(AdditionDTO hotelAmenity);
        public Task<AdditionDTO> UpdateAddition(int amenityId, AdditionDTO hotelAmenity);
        public Task<int> DeleteAddition(int amenityId, string userId);
        public Task<List<AdditionDTO>> GetAllAdditions();
        public Task<AdditionDTO> GetAddition(int amenityId);
        public Task<AdditionDTO> IsSameNameAdditionAlreadyExists(string name);
    }
}
