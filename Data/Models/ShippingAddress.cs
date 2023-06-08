using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ShippingAddress:Contact
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string DeliveryInstructions { get; set; } = "";
        public string TrackingNumber { get; set; } = "";
        public string Carrier { get; set; } = "";
        public DateTime EstimatedDeliveryDate { get; set; } = DateTime.Now;
        public string ShippingMethod { get; set; } = "";
        public decimal ShippingCost { get; set; }= decimal.Zero;

        //public string StreetName { get; set; }
        //public int StreetNumber { get; set; }
        //public string City { get; set; }
        //public string LGA { get; set; }
        //public string State { get; set; }
        //public string PostalCode { get; set; }
    }
}
