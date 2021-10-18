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
    public class AdditionController : Controller
    {
        private readonly IAdditionRepository _additionRepository;

        public AdditionController(IAdditionRepository additionRepository)
        {
            _additionRepository = additionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAdditions()
        {
            var allAmenity = await _additionRepository.GetAllAdditions();
            return Ok(allAmenity);
        }

    }
}
