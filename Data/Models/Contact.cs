using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string StreetName { get; set; }= string.Empty;
        public int StreetNumber { get; set; }
        public string City { get; set; } = string.Empty;
        public string LGA { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public List<string> PhoneNumber { get; set; } = new List<string>();
    }
}
