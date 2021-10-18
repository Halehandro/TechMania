using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AdditionDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter addition name")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Please enter addition timming")]
        public string Timming { get; set; }
        [Required(ErrorMessage = "Please enter addition description")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "Please enter addition icon from font awesome")]
        public string IconStyle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
