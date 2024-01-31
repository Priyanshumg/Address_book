using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Contacts
    {
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private long phonenumber;
        private string email;

        public Contacts(string UpdateFname, string UpdateLname,
            string UpdateAddress, string UpdateCity, string UpdateState, string UpdateZipCode,
            long UpdatePhoneNumber, string UpdateEmail)
        {
            firstname = UpdateFname;
            lastname = UpdateLname;
            address = UpdateAddress;
            city = UpdateCity;
            state = UpdateState;
            zipCode = UpdateZipCode;
            phonenumber = UpdatePhoneNumber;
            email = UpdateEmail;
        }
    }
}
