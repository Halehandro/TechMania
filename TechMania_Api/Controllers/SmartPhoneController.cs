using Business.Repository.IRepository;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Api.Controllers
{
    [Route("api/[controller]")]
    public class SmartPhoneController : Controller
    {
        private readonly ISmartPhoneRepository _smartPhoneRepository;

        public SmartPhoneController(ISmartPhoneRepository smartPhoneRepository)
        {
            _smartPhoneRepository = smartPhoneRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSmartPhones(string Manufacturer = null)
        {
           

            var allPhones = await _smartPhoneRepository.GetAllSmartPhone(Manufacturer);
            return Ok(allPhones);
        }

        [HttpGet("{phoneId}")]
        public async Task<IActionResult> GetSmartPhone(int? phoneId)
        {
            if (phoneId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Phone Id",
                    StatusCode = StatusCodes.Status400BadRequest

                });
            }

            var phoneDetails = await _smartPhoneRepository.GetSmartPhone(phoneId.Value);

            if (phoneDetails == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Phone Id",
                    StatusCode = StatusCodes.Status404NotFound

                });
            }

            return Ok(phoneDetails);
        }

    }
}
