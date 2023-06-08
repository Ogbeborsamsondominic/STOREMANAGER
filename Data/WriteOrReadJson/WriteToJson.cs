using Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.WriteOrReadJson
{
    public class WriteToJson
    {
        //public void WriteToJsons(List<Customer> customers, string email, string firstName, string lastName, string password, string username, string gender)
        //{
        //    Registration newRegistration = new();
        //    Customer newCustomer = newRegistration.RegisterCustomer(customers, email, firstName, lastName, "", password, username, gender);

        //    Console.WriteLine("Customer registration successful!");
        //    Console.WriteLine("Welcome, " + CapitalizeFirstLetter(newCustomer.FirstName) + " " + CapitalizeFirstLetter(newCustomer.LastName) + "!");

        //    string fileName = "data.json";
        //    string currentDir = Environment.CurrentDirectory;
        //    DirectoryInfo directory = new DirectoryInfo(
        //        Path.GetFullPath(Path.Combine(currentDir, @"..\..\..\" + fileName)));
        //    string customerJson = JsonSerializer.Serialize(customers);
        //    using (StreamWriter writer = new StreamWriter(directory.FullName))
        //    {
        //        writer.Write(customerJson);
        //    }
        //    Console.WriteLine("JSON is written");
        //}

        //private static string CapitalizeFirstLetter(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return input;

        //    return char.ToUpper(input[0]) + input.Substring(1);
        public void WriteToJsons(List<User> user)
        {
            string fullPath = JsonHelper.GetPath("data.json");

            string jsonString = JsonSerializer.Serialize(user);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }

        }
    }
}
