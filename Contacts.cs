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

        public string FirstName{
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set 
            { 
                city = value; 
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set 
            { 
                state = value; 
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }
        public long PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set 
            {
                phonenumber = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
