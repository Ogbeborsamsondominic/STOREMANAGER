using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class UpdateProcess
    {
        public Guid Id { get; set; }    = Guid.NewGuid();

        public string ChangeFirstName { get; set; }
        public string ChangeLastName { get; set; }
        public string AddAddress { get; set; }
        public string AddCity { get; set; }
        public string AddCountry { get; set; }
        public string AddPhoneNumber { get; set; }

    }
}
