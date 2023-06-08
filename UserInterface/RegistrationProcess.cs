using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Data.Models;

namespace UserInterface
{
    public class RegistrationProcess
    {
        private static string ReadInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static string GetValidInput(string message, Func<string, bool> validationFunc, string errorMessage)
        {
            string input;
            do
            {
                input = ReadInput(message);
                if (!validationFunc(input))
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!validationFunc(input));
            return input;
        }
        public static void PerformRegistration<T>(List<T> users) where T : User, new()
        {
            bool ValidateFirstName(string firstName)
            {
                return Regex.IsMatch(firstName, @"^[A-Za-z]{5,}$");
            }

            bool ValidateLastName(string lastName)
            {
                return Regex.IsMatch(lastName, @"^[A-Za-z]{4,}$");
            }

            bool ValidateOtherName(string otherName)
            {
                return Regex.IsMatch(otherName, @"^[A-Za-z]{5,}$");
            }


            string firstname = GetValidInput("Enter your firstname: ", ValidateFirstName, "\u001b[31mInvalid first name! First name must contain letters only.\u001b[0m");
            string lastname = GetValidInput("Enter your lastname: ", ValidateLastName, "\u001b[31mInvalid first name! First name must contain letters only.\u001b[0m");
           // string changefirstname = GetValidInput("Change firstname:", ValidateFirstName, "\u001b[31mInvalid first name! First name must contain letters only.\u001b[0m");
          //  string othername = GetValidInput("Enter your othername: ", ValidateOtherName, "\u001b[31mInvalid other name! Other name must contain letters only.\u001b[0m");
           // string gender = GetValidInput("Enter your gender: ", RegistrationValidation.ValidateGender, "\u001b[31mInvalid gender! Gender must contain letters only.\u001b[0m");
         //   string phonenumber = GetValidInput("Enter your phonenumber: ", RegistrationValidation.ValidatePhoneNumber, "\u001b[31mInvalid phone number! Phone number must contain numbers only.\u001b[0m");
            string email = GetValidInput("Enter your email: ", (input) => RegistrationValidation.ValidateEmail(input, new List<User>(users)), "\u001b[31mInvalid email address! Please enter a valid email address.\u001b[0m");
            string username = email.Split('@')[0]; // Use email as the username
            string password = GetValidInput("Enter your password: MAX Of 8 Char;Uppercase,Lowercase And Number  ", RegistrationValidation.ValidatePassword, "\u001b[31mInvalid password! Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.\u001b[0m");

            string confirmPassword;
            do
            {
                confirmPassword = ReadInput("Confirm Password: ");
                if (password != confirmPassword)
                {
                    Console.WriteLine("Password and confirm password do not match!");
                }
            } while (password != confirmPassword);

            var user = new T
            {
                FirstName = firstname,
                LastName = lastname,
               // OtherName = othername,
                //Gender = gender,
                Email = email,
                Username = username,
                Password = password
            };

            users.Add(user);

            Console.WriteLine("Registration successful!");
           // Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.Clear();
            Console.WriteLine("Kindly Choose your Login ");

        }

        public static void CustomerRegistration(List<Customer> customers)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome To Crown Glory Customer Registration Page");
            Console.ResetColor();
            Console.ResetColor();
            PerformRegistration(customers);
        }

        public static void SupplierRegistration(List<Supplier> suppliers)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome To Crown Glory Supplier Registration Page");
            Console.ResetColor();
            Console.ResetColor();
            PerformRegistration(suppliers);
        }

        public static void EmployeeRegistration(List<Employee> employees)
        {    Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome To Crown Glory Employee Registration Page");
            Console.ResetColor();
            Console.ResetColor();
            PerformRegistration(employees);
        }

    
        }
    }




//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;
//using Data.Models;

//namespace UserInterface
//{
//    public class RegistrationProcess
//    {
//        private static string ReadInput(string message)
//        {
//            Console.Write(message);
//            return Console.ReadLine();
//        }

//        private static string GetValidInput(string message, Func<string, bool> validationFunc, string errorMessage)
//        {
//            string input;
//            do
//            {
//                input = ReadInput(message);
//                if (!validationFunc(input))
//                {
//                    Console.WriteLine(errorMessage);
//                }
//            } while (!validationFunc(input));
//            return input;
//        }

//        public static void PerformRegistration<T>(List<T> users) where T : User, new()
//        {
//            bool ValidateFirstName(string firstName)
//            {
//                return Regex.IsMatch(firstName, @"^[A-Za-z]{2,}$");
//            }

//            bool ValidateLastName(string lastName)
//            {
//                return Regex.IsMatch(lastName, @"^[A-Za-z]{2,}$");
//            }

//            bool ValidateOtherName(string otherName)
//            {
//                return Regex.IsMatch(otherName, @"^[A-Za-z]{2,}$");
//            }

//            string firstname = GetValidInput("Enter your firstname: ", ValidateFirstName, "Invalid first name! First name must contain letters only.");
//            string lastname = GetValidInput("Enter your lastname: ", ValidateLastName, "Invalid last name! Last name must contain letters only.");
//            string othername = GetValidInput("Enter your othername: ", ValidateOtherName, "Invalid other name! Other name must contain letters only.");

//            string gender = GetValidInput("Enter your gender: ", RegistrationValidation.ValidateGender, "Invalid gender! Gender must contain letters only.");
//            string phonenumber = GetValidInput("Enter your phonenumber: ", RegistrationValidation.ValidatePhoneNumber, "Invalid phone number! Phone number must contain numbers only.");
//            string email = GetValidInput("Enter your email: ", (input) => RegistrationValidation.ValidateEmail(input, new List<User>(users)), "Invalid email address! Please enter a valid email address.");
//            string username = email.Split('@')[0]; // Use email as the username
//            string password = GetValidInput("Enter your password: ", RegistrationValidation.ValidatePassword, "Invalid password! Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.");

//            string confirmPassword;
//            do
//            {
//                confirmPassword = ReadInput("Confirm Password: ");
//                if (password != confirmPassword)
//                {
//                    Console.WriteLine("Password and confirm password do not match!");
//                }
//            } while (password != confirmPassword);

//            var user = new T
//            {
//                FirstName = firstname,
//                LastName = lastname,
//                OtherName = othername,
//                Gender = gender,
//                Email = email,
//                Username = username,
//                Password = password
//            };

//            users.Add(user);

//            Console.WriteLine("Registration successful!");
//            Console.WriteLine($"Username: {username}");
//            Console.WriteLine($"Password: {password}");
//            Console.Clear();
//        }

//        public static void CustomerRegistration(List<Customer> customers)
//        {
//            Console.WriteLine("Welcome To Crown Glory Customer Registration Page");
//            PerformRegistration(customers);
//        }

//        public static void SupplierRegistration(List<Supplier> suppliers)
//        {
//            Console.WriteLine("Welcome To Crown Glory Supplier Registration Page");
//            PerformRegistration(suppliers);
//        }

//        public static void EmployeeRegistration(List<Employee> employees)
//        {
//            Console.WriteLine("Welcome To Crown Glory Employee Registration Page");
//            PerformRegistration(employees);
//        }
//    }
//}




//using Data.Models;
//using System;
//using System.Collections.Generic;

//namespace UserInterface
//{
//    public class RegistrationProcess
//    {
//        public static void CustomerRegistration(List<Customer> customers)
//        {
//            Console.WriteLine("Welcome To Crown Glory Customer Registration Page");
//            PerformRegistration(customers);
//        }

//        public static void SupplierRegistration(List<Supplier> suppliers)
//        {
//            Console.WriteLine("Welcome To Crown Glory Supplier Registration Page");
//            PerformRegistration(suppliers);
//        }

//        public static void EmployeeRegistration(List<Employee> employees)
//        {
//            Console.WriteLine("Welcome To Crown Glory Employee Registration Page");
//            PerformRegistration(employees);
//        }

//        private static void PerformRegistration<T>(List<T> users) where T : User, new()
//        {
//            Console.Write("Enter your firstname: ");
//            string firstname = Console.ReadLine();

//            if (!RegistrationValidation.ValidateFirstName(firstname))
//            {
//                Console.WriteLine("Invalid first name! First name must contain letters only.");
//                return;
//            }

//            Console.Write("Enter your lastname: ");
//            string lastname = Console.ReadLine();

//            if (!RegistrationValidation.ValidateLastName(lastname))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }

//            Console.Write("Enter your othername: ");
//            string othername = Console.ReadLine();
//            if (!RegistrationValidation.ValidateOtherName(othername))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }

//            Console.Write("Enter your gender: ");
//            string gender = Console.ReadLine();
//            if (!RegistrationValidation.ValidateOtherName(gender))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }

//            Console.Write("Enter your phonenumber: ");
//            string phonenumber = Console.ReadLine();
//            if (!RegistrationValidation.ValidateOtherName(phonenumber))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }

//            Console.Write("Enter your email: ");
//            string email = Console.ReadLine();
//            if (!RegistrationValidation.ValidateOtherName(email))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }


//            Console.Write("Enter your username: ");
//            string username = Console.ReadLine();
//            if (!RegistrationValidation.ValidateOtherName(username))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }

//            Console.Write("Enter your password: ");
//            string password = Console.ReadLine();
//            if (!RegistrationValidation.ValidateOtherName(password))
//            {
//                Console.WriteLine("Invalid last name! Last name must contain letters only.");
//                return;
//            }

//            Console.Write("Confirm Password: ");
//            string confirmPassword = Console.ReadLine();

//            // Perform the remaining validations and registration process
//            // ...

//            var user = new T
//            {
//                FirstName = firstname,
//                LastName = lastname,
//                OtherName = othername,
//                Gender = gender,
//                Email = email,
//                Username = username,
//                Password = password
//            };
//            users.Add(user);

//            Console.WriteLine("Registration successful!");
//            Console.Clear();
//        }
//    }
//}




