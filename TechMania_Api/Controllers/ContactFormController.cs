using Business.Repository.IRepository;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ContactFormController : Controller
    {
        private readonly IEmailSender _emailSender;

        public ContactFormController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] ContactFormModel model)
        {
            if (string.IsNullOrEmpty(model.SenderEmail))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "SenderEmail need to be suplied"
                });
            }
            if (string.IsNullOrEmpty(model.ContactMessage))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "ContactMessage need to be suplied"
                });
            }
            model.ContactMessage = "User with email: " + model.SenderEmail + " has sent you message. Content of the messsage is: " + model.ContactMessage;
            await _emailSender.SendEmailAsync(model.SenderEmail, model.Subject, model.ContactMessage);
            model.MessageSent = true;
            return Ok(model);
        }

    }
}
