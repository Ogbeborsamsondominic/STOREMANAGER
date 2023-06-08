using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BillingAddress : Contact
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PaymentMethod { get; set; } = "";
        public string AccountNumber { get; set; } = "";
        public string BillingCompany { get; set; } = "";
        public string InvoicePreference { get; set; } = "";
        public string BillingType { get; set; } = "";
        public DateTime LastInvoiceDate { get; set; }
        public bool IsPrimary { get; set; }= false;
    }
}
