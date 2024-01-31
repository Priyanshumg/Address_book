using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Object for Addressbook 
            AddressBook book = new AddressBook();
            
            book.Greet();
            book.ShowUserDetails();
            Console.ReadLine();
        }
    }
}
