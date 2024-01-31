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
        }
    }
}
