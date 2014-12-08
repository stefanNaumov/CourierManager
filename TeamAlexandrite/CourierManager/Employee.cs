using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public abstract class Employee : Subject, IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName, string address, ulong idNumber, ulong phone)
            : base(address, idNumber, phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
