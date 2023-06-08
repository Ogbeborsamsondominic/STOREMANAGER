using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Supplier:User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; }
        public Contact Contact { get; set; }
        public List<Product> Product { get; set; }
        public decimal AccountBalance { get; set; }
        public double Rating { get; set; }
        public List<Orders> OrderHistory { get; set; }
        public string PaymentTerms { get; set; }
        public TimeSpan DeliveryLeadTime { get; set; }
        public string PreferredContactMethod { get; set; }
        public string ContactMethod { get; set; }
        public string Address { get; set; }

    }
}
