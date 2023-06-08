using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Orders:Supplier
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerID { get; set; } 
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool Status { get; set; }=false;
        public ShippingAddress ShippingAddress { get; set; } = new ShippingAddress();
        public BillingAddress BillingAddress { get; set; } = new BillingAddress();
    }
}
