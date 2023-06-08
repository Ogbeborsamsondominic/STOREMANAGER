using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{

        public static class LoginProcess
        {
            public static bool CustomerLogin(List<Customer> customers, string username, string password)
            {
                foreach (Customer customer in customers)
                {
                    if (customer.Username == username && customer.Password == password)
                    {
                        return true; 
                    }
                }

                return false; 
            }

            public static bool EmployeeLogin(List<Employee> employees, string username, string password)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.Username == username && employee.Password == password)
                    {
                        return true; 
                    }
                }

                return false; 
            }

            public static bool SupplierLogin(List<Supplier> suppliers, string username, string password)
            {
                foreach (Supplier supplier in suppliers)
                {
                    if (supplier.Username == username && supplier.Password == password)
                    {
                        return true; 
                    }
                }

                return false; 
            }
        }
    }

