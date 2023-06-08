using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Data.Models;
using Services;

namespace UserInterface
{
    public class Program
    {
        private static List<Customer> customers = new List<Customer>();
        private static List<Employee> employees = new List<Employee>();
        private static List<Supplier> suppliers = new List<Supplier>();
        private static Employee? loggedInEmployee;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Crown Glory");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Customer Registration");
            Console.WriteLine("2. Employee Registration");
            Console.WriteLine("3. Supplier Registration");
            Console.WriteLine("4. Customer Login");
            Console.WriteLine("5. Employee Login");
            Console.WriteLine("6. Supplier Login");
            Console.WriteLine("7. Exit");

            bool isExit = false;
            bool isCustomerLogin = false;
            Customer loggedInCustomer = null;

            while (!isExit)
            {
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegistrationProcess.CustomerRegistration(customers);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine("Customer registration successful!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Please proceed to login.\n");
                        Console.ResetColor();
                        break;
                    case "2":
                        RegistrationProcess.EmployeeRegistration(employees);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine("Employee registration successful!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Please proceed to login.\n");
                        Console.ResetColor();
                        break;
                    case "3":
                        RegistrationProcess.SupplierRegistration(suppliers);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine("Supplier registration successful!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Please proceed to login.\n");
                        Console.ResetColor();
                        break;
                    case "4":
                        isCustomerLogin = true;
                        while (isCustomerLogin)
                        {
                            Console.Write("Username: ");
                            string customerUsername = Console.ReadLine();
                            Console.Write("Password: ");
                            string customerPassword = Console.ReadLine();
                            bool customerLoginSuccess = LoginProcess.CustomerLogin(customers, customerUsername, customerPassword);
                            if (customerLoginSuccess)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Customer login successful!");
                                Console.ResetColor();

                                loggedInCustomer = customers.Find(c => c.Username == customerUsername);
                                Console.WriteLine("Welcome To Your Loginpage, " + loggedInCustomer.Username + "!");
                                Console.Clear();
                                isCustomerLogin = false;
                                CustomerMenu(loggedInCustomer);
                            }
                            else
                            {
                                Console.WriteLine("Invalid username or password. Please try again.");
                            }
                        }
                        break;


                    case "5":
                        bool isEmployeeLogin = true;
                        while (isEmployeeLogin)
                        {
                            Console.Write("Username: ");
                            string employeeUsername = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Password: ");
                            string employeePassword = Console.ReadLine();
                            Console.Clear();
                            bool employeeLoginSuccess = LoginProcess.EmployeeLogin(employees, employeeUsername, employeePassword);
                            if (employeeLoginSuccess)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Employee login successful!");
                                Console.ResetColor();

                                Console.WriteLine("Enter the new employee last name:");
                                string newEmployeeLastName = Console.ReadLine();
                                EmployeeMenu(newEmployeeLastName);
                                loggedInEmployee = employees.Find(e => e.Username == employeeUsername);
                                Console.WriteLine("Welcome, " + loggedInEmployee.Username + "!");
                                isEmployeeLogin = false;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid username or password. Please try again.");
                                Console.ResetColor();
                            }
                        }
                        break;

                    case "6":
                        bool isSupplierLogin = true;
                        while (isSupplierLogin)
                        {
                            Console.Write("Username: ");
                            string supplierUsername = Console.ReadLine();
                            Console.Write("Password: ");
                            string supplierPassword = Console.ReadLine();
                            bool supplierLoginSuccess = LoginProcess.SupplierLogin(suppliers, supplierUsername, supplierPassword);
                            if (supplierLoginSuccess)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Supplier login successful!");
                                Console.ResetColor();
                                Console.ResetColor();

                                isSupplierLogin = false;
                                SupplierMenu();
                            }
                            else
                            {
                                Console.WriteLine("Invalid username or password. Please try again.");
                            }
                        }
                        break;
                    case "7":
                        isExit = true;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine();
                if (!isExit && !isCustomerLogin)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Customer Registration");
                    Console.WriteLine("2. Employee Registration");
                    Console.WriteLine("3. Supplier Registration");
                    Console.WriteLine("4. Customer Login");
                    Console.WriteLine("5. Employee Login");
                    Console.WriteLine("6. Supplier Login");
                    Console.WriteLine("7. Exit");
                }
            }

            Console.WriteLine("Thank you for using Crown Glory. Goodbye!");
        }

        public static void CustomerMenu(Customer customer)
        {
            bool isCustomerMenuExit = false;

            while (!isCustomerMenuExit)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Update Information");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. View Orders");
                Console.WriteLine("4. Logout");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        UpdateCustomerInformation(customer);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Logged out successfully!");
                        isCustomerMenuExit = true;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public static void UpdateCustomerInformation(Customer customer)
        {
            bool isUpdating = true;

            while (isUpdating)
            {
                Console.WriteLine("Update Customer Information");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Address");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Current first name: " + customer.FirstName);
                        Console.Write("Enter new first name: ");
                        string newFirstName = Console.ReadLine();
                        if (Regex.IsMatch(newFirstName, @"^[A-Za-z]{5,}$"))
                        {
                            customer.FirstName = newFirstName;
                            Console.WriteLine("First name changed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid first name. Please enter a name with at least 5 alphabetic characters.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Current last name: " + customer.LastName);
                        Console.Write("Enter new last name: ");
                        string newLastName = Console.ReadLine();
                        if (Regex.IsMatch(newLastName, @"^[A-Za-z]{4,}$"))
                        {
                            customer.LastName = newLastName;
                            Console.WriteLine("Last name changed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid last name. Please enter a name with at least 4 alphabetic characters.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Current address: " + customer.Address);
                        Console.Write("Enter new address: ");
                        string newAddress = Console.ReadLine();
                        if (Regex.IsMatch(newAddress, @"^(?i)#[0-9]+\s+[\w\s]+$"))
                        {
                            customer.Address = newAddress;
                            Console.WriteLine("Address changed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid address. Please enter an address in the format '#1 Main Street City'.");
                        }
                        break;

                    case "4":
                        isUpdating = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Update Information");
                Console.WriteLine("2. Place Order");
                Console.WriteLine("3. View Orders");
                Console.WriteLine("4. Logout");
            }
        }

        public static void EmployeeMenu(string? newEmployeeLastName)
        {
            bool isEmployeeMenuExit = false;

            while (!isEmployeeMenuExit)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Update Information");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Logout");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the new employee first name:");
                        string newEmployeeFirstName = Console.ReadLine();
                        if (!Regex.IsMatch(newEmployeeFirstName, @"^[A-Za-z]{5,}$"))
                        {
                            Console.WriteLine("Invalid employee first name format!");
                            break;
                        }

                        Console.WriteLine("Enter the new employee last name:");
                        string newemployeelastname = Console.ReadLine();
                        if (!Regex.IsMatch(newEmployeeLastName, @"^[A-Za-z]{5,}$"))
                        {
                            Console.WriteLine("Invalid employee last name format!");
                            break;
                        }

                        Console.WriteLine("Enter the employee new address:");
                        string newEmployeeAddress = Console.ReadLine();
                        if (!Regex.IsMatch(newEmployeeAddress, @"^(?i)#[0-9]+\s+[\w\s]+$"))
                        {
                            Console.WriteLine("Invalid employee address format!");
                            break;
                        }

                        Employee employeeToUpdate = employees.FirstOrDefault();
                        if (employeeToUpdate == null)
                        {
                            Console.WriteLine("Employee not found!");
                            break;
                        }

                        employeeToUpdate.FirstName = newEmployeeFirstName;
                        employeeToUpdate.LastName = newEmployeeLastName;
                        employeeToUpdate.Address = newEmployeeAddress;

                        Console.WriteLine("Employee information updated successfully!");
                        break;


                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Logged out successfully!");
                        isEmployeeMenuExit = true;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public static void SupplierMenu()
        {
            bool isSupplierMenuExit = false;

            while (!isSupplierMenuExit)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Update Information");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Logout");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the new supplier first name:");
                        string newSupplierFirstName = Console.ReadLine();
                        if (!Regex.IsMatch(newSupplierFirstName, @"^[A-Za-z]{5,}$"))
                        {
                            Console.WriteLine("Invalid supplier first name format!");
                            break;
                        }

                        Console.WriteLine("Enter the new supplier last name:");
                        string newSupplierLastName = Console.ReadLine();
                        if (!Regex.IsMatch(newSupplierLastName, @"^[A-Za-z]{5,}$"))
                        {
                            Console.WriteLine("Invalid supplier last name format!");
                            break;
                        }

                        Console.WriteLine("Enter the supplier new address:");
                        string newSupplierAddress = Console.ReadLine();
                        if (!Regex.IsMatch(newSupplierAddress, @"^(?i)#[0-9]+\s+[\w\s]+$"))
                        {
                            Console.WriteLine("Invalid supplier address format!");
                            break;
                        }

                        Supplier supplierToUpdate = suppliers.FirstOrDefault();
                        if (supplierToUpdate == null)
                        {
                            Console.WriteLine("Supplier not found!");
                            break;
                        }

                        supplierToUpdate.FirstName = newSupplierFirstName;
                        supplierToUpdate.LastName = newSupplierLastName;
                        supplierToUpdate.Address = newSupplierAddress;

                        Console.WriteLine("Supplier information updated successfully!");
                        break;



                        {
                            Console.WriteLine("Supplier not found!");
                            break;
                        }

                        

                        Console.WriteLine("Supplier information updated successfully!");
                        break;

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Logged out successfully!");
                        isSupplierMenuExit = true;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}

