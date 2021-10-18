using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class SmartPhoneImage
    {
        public int Id { get; set; }
        public int PhoneId { get; set; }
        public string PhoneImageUrl { get; set; }
        [ForeignKey ("PhoneId")]
        public virtual SmartPhone SmartPhone { get; set; }

    }
}
