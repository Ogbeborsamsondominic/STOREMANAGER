using Data.Models;
using System.Text.RegularExpressions;

namespace UserInterface
{
    public class RegistrationValidation
    {
        public static bool ValidateFirstName(string firstname)
        {
            return !string.IsNullOrEmpty(firstname) && Regex.IsMatch(firstname, @"^[a-zA-Z]{3 ,}$");
        }

        public static bool ValidateLastName(string lastname)
        {
            return !string.IsNullOrEmpty(lastname) && Regex.IsMatch(lastname, @"^[a-zA-Z]+$");
        }

        public static bool ValidateOtherName(string othername)
        {
            return !string.IsNullOrEmpty(othername) && Regex.IsMatch(othername, @"^[a-zA-Z]+$");
        }

        public static bool ValidateGender(string gender)
        {
            return !string.IsNullOrEmpty(gender) && Regex.IsMatch(gender, @"^(male|female)$", RegexOptions.IgnoreCase);
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{11}$");
        }

        public static bool ValidateEmail(string email, List<User> users)
        {
            return !string.IsNullOrEmpty(email)
                && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
                && !users.Exists(u => u.Email == email);
        }

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