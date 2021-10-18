using AutoMapper;
using DataAcess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<SmartPhoneDTO, SmartPhone>();
            CreateMap<SmartPhone, SmartPhoneDTO>().ReverseMap();
            CreateMap<Addition, AdditionDTO>().ReverseMap();

            CreateMap<SmartPhoneOrderDetails, SmartPhoneOrderDetailDTO>().ForMember(x => x.SmartPhoneDTO, opt => opt.MapFrom(c => c.SmartPhone));
            CreateMap<SmartPhoneOrderDetailDTO, SmartPhoneOrderDetails>();
            CreateMap<SmartPhoneImage, SmartPhoneImageDTO>().ReverseMap();
        }
    }
}
