using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TechMania_Client.Service.IService;

namespace TechMania_Client.Service
{
    public class AdditionsService : IAdditionsService
    {
        private readonly HttpClient _client;

        public AdditionsService( HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<AdditionDTO>> GetAdditions()
        {
            var response = await _client.GetAsync($"api/addition");
            var content = await response.Content.ReadAsStringAsync();
            var additions = JsonConvert.DeserializeObject<IEnumerable<AdditionDTO>>(content);
            return additions;
        }
    }
}
