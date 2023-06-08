using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Customer : User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        // public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string OtherNames { get; set; }
        public Contact Contact { get; set; }
        // public string Gender { get; set; } = string.Empty;
        public ShippingAddress Shipping { get; set; }
        public BillingAddress Billing { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string OriginalFirstName { get; set; }
        public string OriginalLastName { get; set; }

    }   
}
    



