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
    public class SmartPhoneService : ISmartPhoneService
    {
        private readonly HttpClient _client;

        public SmartPhoneService ( HttpClient client)
        {
            _client = client;
        }

        public async Task<SmartPhoneDTO> GetSmartPhoneDetails(int phoneId)
        {
            var response = await _client.GetAsync($"api/smartphone/{phoneId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var room = JsonConvert.DeserializeObject<SmartPhoneDTO>(content);
                return room;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<List<SmartPhoneDTO>> GetSmartPhones(string Manufacturer)
        {
            var response = await _client.GetAsync($"api/smartphone?Manufacturer={Manufacturer}");
            var content = await response.Content.ReadAsStringAsync();
            var phones = JsonConvert.DeserializeObject<List<SmartPhoneDTO>>(content);
            return phones;
        }
    }
}
