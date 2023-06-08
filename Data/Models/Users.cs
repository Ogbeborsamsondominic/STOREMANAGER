using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User:Contact
    {
        public Guid id =  Guid .NewGuid ();
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string OtherName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;      
        public Contact Contact { get; set; } = new Contact ();
        public List<Guid> RoleId { get; set; }= new List<Guid> ();
    }
}
