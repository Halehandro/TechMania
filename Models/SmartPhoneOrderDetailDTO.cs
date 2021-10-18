using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SmartPhoneOrderDetailDTO
    {
        public SmartPhoneOrderDetailDTO()
        {
            SmartPhoneDTO = new SmartPhoneDTO();
        }
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ActualCheckInDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        [Required]
        public string StripeSessionId { get; set; }
        [Required]
        public double TotalCost { get; set; }
        [Required]
        public int SmartPhoneId { get; set; }
        public bool IsPaymentSuccessful { get; set; } = false;
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public SmartPhoneDTO SmartPhoneDTO { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }
        public int OrderQuantity { get; set; }

    }
}
