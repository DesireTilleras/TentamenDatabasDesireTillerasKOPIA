using System;
using System.Collections.Generic;
using System.Text;

namespace HemtentaDesireDatabaserPragueParking
{
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public string Address { get; set; }
        public int? TelePhonenUmber { get; set; }
        public string? EmailAddress { get; set; }

        public Employee(string name, int employeeNumber, string address, int? telePhoneNumber = null, string? emailAddress = null)
        {
            this.Name = name;
            this.EmployeeNumber = employeeNumber;
            this.Address = address;
            this.TelePhonenUmber = telePhoneNumber;
            this.EmailAddress = emailAddress;
        }

    }
}
