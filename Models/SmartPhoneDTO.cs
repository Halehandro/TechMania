using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SmartPhoneDTO
    {
        public SmartPhoneDTO()
        {
            SmartPhoneImages = new Collection<SmartPhoneImageDTO>();
            ImageUrls = new List<string>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage="Please enter Smartphone name")]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }
        [Range(1, 15000, ErrorMessage = "Price must be between 1 and 15000")]
        public double Price { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        public int TotalPrice { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<SmartPhoneImageDTO> SmartPhoneImages { get; set; }
        public List<string> ImageUrls { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
