using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Client.Service.IService
{
    interface IAdditionsService
    {
        public Task<IEnumerable<AdditionDTO>> GetAdditions();
    }
}
