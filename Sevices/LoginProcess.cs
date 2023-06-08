using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Data.Models
{
    public class LoginProcess
    {
        public static bool CustomerLogin(List<Customer> customers, string username, string password)
        {
            Customer customer = customers.Find(c => c.Username == username && c.Password == password);
            return customer != null;
        }

        public static bool EmployeeLogin(List<Employee> employees, string username, string password)
        {
            Employee employee = employees.Find(e => e.Username == username && e.Password == password);
            return employee != null;
        }

        public static bool SupplierLogin(List<Supplier> suppliers, string username, string password)
        {
            Supplier supplier = suppliers.Find(s => s.Username == username && s.Password == password);
            return supplier != null;

        }
    }
}



