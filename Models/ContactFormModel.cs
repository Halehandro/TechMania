using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string SenderName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string SenderEmail { get; set; }
        [Required(ErrorMessage = "Message can't be empty")]
        public string ContactMessage { get; set; }
        public bool MessageSent { get; set; }
    }
}
