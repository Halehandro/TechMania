using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechMania_Client.Service.IService;

namespace TechMania_Client.Service
{
    public class ContactFormService : IContactFormService
    {
        private readonly HttpClient _client;

        public ContactFormService( HttpClient client)
        {
            _client = client;
        }

        public async Task<ContactFormModel> SendContactMessage(ContactFormModel model)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/contactform/send", stringContent);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var phone = JsonConvert.DeserializeObject<ContactFormModel>(content);
                return phone;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

    }
}
