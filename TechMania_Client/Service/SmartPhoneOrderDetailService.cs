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
    public class SmartPhoneOrderDetailService : ISmartPhoneOrderDetailService
    {
        private readonly HttpClient _client;

        public SmartPhoneOrderDetailService( HttpClient client)
        {
            _client = client;
        }

        public async Task<SmartPhoneOrderDetailDTO> MarkPaymentSuccessful(SmartPhoneOrderDetailDTO details)
        {

            var stringContent = new StringContent(JsonConvert.SerializeObject(details), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/smartphoneorder/paymentsuccessful", stringContent);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SmartPhoneOrderDetailDTO>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(contentTemp);

            }
        }

        public async Task<SmartPhoneOrderDetailDTO> SaveSmartPhoneOrderDetails(SmartPhoneOrderDetailDTO details)
        {
            var content = JsonConvert.SerializeObject(details);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/smartphoneorder/create", bodyContent);
            //string res = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SmartPhoneOrderDetailDTO>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }
    }
}
