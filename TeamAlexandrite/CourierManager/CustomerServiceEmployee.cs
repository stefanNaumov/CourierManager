using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    class CustomerServiceEmployee : Employee, ISalary
    {
        public CustomerServiceEmployee(string firstName, string lastName, string address, ulong idNumber, ulong phone) 
            : base(firstName, lastName, address, idNumber, phone)
        {
        }

        public decimal CalculateSalary()
        {
            return this.Salary;
        }
    }
}
