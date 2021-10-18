using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISmartPhoneImagesRepository
    {
        public Task<int> CreateSmartPhoneImage(SmartPhoneImageDTO image);
        public Task<int> DeleteSmartPhoneImageByImageId(int imageId);
        public Task<int> DeleteSmartPhoneImageByPhoneId(int phoneId);
        public Task<int> DeleteSmartPhoneImageByImageUrl(string imageUrl);
        public Task<IEnumerable<SmartPhoneImageDTO>> GetSmartPhoneImages(int phoneId);
    }
}
