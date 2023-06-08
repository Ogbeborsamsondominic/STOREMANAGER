using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Employee:User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Position { get; set; }
        public Contact Contact { get; set; }
        public string DateOfBirth { get; set; } = string.Empty;
        public DateTime ResumptionDate { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Address { get; set; } 
    }
}
