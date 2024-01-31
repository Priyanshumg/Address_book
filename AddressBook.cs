using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class AddressBook
    {
        Contacts UserDetails = new Contacts("Priyanshu","Ginkal","Potheri", "Chennai", "Tamil Nadu", "603203", +4664654,"gp@gmail.com");
        public void Greet()
        {
            Console.WriteLine("Welcome to the AddressBook");
            Console.WriteLine();
        }

        public void ShowUserDetails()
        {
            Console.WriteLine("Printing User Details ...");
            Console.WriteLine($"User First Name: {UserDetails.FirstName}");
            Console.WriteLine($"User Last Name: {UserDetails.LastName}");
            Console.WriteLine($"User Address: {UserDetails.Address}");
            Console.WriteLine($"User City: {UserDetails.City}");
            Console.WriteLine($"User State: {UserDetails.State}");
            Console.WriteLine($"User Zip Code: {UserDetails.ZipCode}");
            Console.WriteLine($"User Phone Number: {UserDetails.PhoneNumber}");
            Console.WriteLine($"User Email: {UserDetails.Email}");
        }
    }
}
