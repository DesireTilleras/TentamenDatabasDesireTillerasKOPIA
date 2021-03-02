using System;
using System.Collections.Generic;
using System.Text;

namespace HemtentaDesireDatabaserPragueParking
{
    class Customer
    {  
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        private string? address;

        public string? Address
        {
            get { return address; }
            set { address = value; }
        }

        private int? socialSecNumber;

        public int? SocialSecNumber
        {
            get { return socialSecNumber; }
            set { socialSecNumber = value; }
        }
                
        public int TelephoneNumber { get; set; }
        public int CustomerNumber { get; set; }
        public string EmailAddress { get; set; }

        public Customer(string firstName, string lastName, int telePhoneNumber, int customerNumber, string email, string? address = null, int? socialSecNumber = null)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.socialSecNumber = socialSecNumber;
            this.TelephoneNumber = telePhoneNumber;
            this.CustomerNumber = customerNumber;
            this.EmailAddress = email;

        }
        public Customer()
        {

        }
    }

}
