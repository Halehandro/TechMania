using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Server.Model
{
    public class BlazorPhone
    {
        public int Id { get; set; }
        public string PhoneName { get; set; }   
        public double PhonePrice { get; set; }
        public bool IsAvailable { get; set; }
        public int PhoneAvailable { get; set; }
        public List<BlazorPhoneProp> PhoneProps { get; set; }

    }
}
