using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class SmartPhoneOrderDetails
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime ActualCheckInDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        [Required]
        public string StripeSessionId { get; set; }
        [Required]
        public double TotalCost { get; set; }
        [Required]
        public int SmartPhoneId { get; set; }
        public bool IsPaymentSuccessful { get; set; } = false;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [ForeignKey("SmartPhoneId")]
        public SmartPhone SmartPhone { get; set; }
        public string Status { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
