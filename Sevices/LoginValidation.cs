using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sevices
{
    public class LoginValidation
    {
        public static bool ValidateUsername(string username)
        {
            return !string.IsNullOrEmpty(username);
        }


        public static bool ValidatePassword(string password)
        {
            return !string.IsNullOrEmpty(password)
                && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z0-9]{8,}$");
        }
    }
}
