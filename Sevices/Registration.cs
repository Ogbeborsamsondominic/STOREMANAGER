using Data.Models;
using System;
using System.Collections.Generic;

namespace Sevices
{
    public class Registration
    {
        public Customer RegisterCustomer(List<Customer> customers, string email, string firstName, string lastName, string otherName, string password, string username, string gender)
        {
            string Username = EmailToUsername(email);
            Customer newCustomer = new Customer
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                OtherName = otherName,
                Password = password,
                Username = username,
                Gender = gender
            };
            customers.Add(newCustomer);
            return newCustomer;
        }

        public Employee RegisterEmployee(List<Employee> employees, string email, string firstName, string lastName, string otherName, string password, string username, string gender)
        {
            string generatedUsername = EmailToUsername(email);
            Employee newEmployee = new Employee
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                OtherName = otherName,
                Password = password,
                Username = generatedUsername,
                Gender = gender
            };
            employees.Add(newEmployee);
            return newEmployee;
        }

        public Supplier RegisterSupplier(List<Supplier> suppliers, string email, string firstName, string lastName, string otherName, string password, string username, string gender)
        {
            string generatedUsername = EmailToUsername(email);
            Supplier newSupplier = new Supplier
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                OtherName = otherName,
                Password = password,
                Username = generatedUsername,
                Gender = gender
            };
            suppliers.Add(newSupplier);
            return newSupplier;
        }

        public string EmailToUsername(string email)
        {
            string[] parts = email.Split('@');
            string username = parts[0];
            return username;
        }
    }
}
