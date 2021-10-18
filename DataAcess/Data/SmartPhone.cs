using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class SmartPhone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string AddedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<SmartPhoneImage> SmartPhoneImages { get; set; }
    }
}
