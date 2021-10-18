using Business.Repository.IRepository;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SmartPhoneOrderController : Controller
    {
        private readonly ISmartPhoneOrderDetailRepository _repository;
        private readonly IEmailSender _emailSender;

        public SmartPhoneOrderController(ISmartPhoneOrderDetailRepository repository, IEmailSender emailSender)
        {
            _repository = repository;
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SmartPhoneOrderDetailDTO details)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Create(details);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating smartphone Details/ Shop"
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] SmartPhoneOrderDetailDTO details)
        {

            var service = new SessionService();
            
            var sessionDetails = service.Get(details.StripeSessionId);
            if (sessionDetails.PaymentStatus == "paid")
            {
                var result = await _repository.MarkPaymentSuccessful(details.Id);
                if (result == null)
                {
                    return BadRequest(new ErrorModel()
                    {
                        ErrorMessage = "Can not mark payment as successful"
                    });
                }
                await _emailSender.SendEmailAsync(details.Email, "Order Confirmed - TechMania",
                    "Your order has been confirmed at TechMania with order ID :" + details.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Can not mark payment as successful"
                });
            }

        }
    }
}
