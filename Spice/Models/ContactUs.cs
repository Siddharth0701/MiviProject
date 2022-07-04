using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public int PhoneNumber { get; set; }
        public string Query { get; set; }




    }
}
