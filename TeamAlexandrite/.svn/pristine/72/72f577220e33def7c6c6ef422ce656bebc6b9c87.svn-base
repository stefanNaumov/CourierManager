using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public class Manager : Employee, ISalary
    {
        public Region ObservedRegion { get; set; }
        public int NewClientsCount { get; set; }
 
        public Manager(string firstName, string lastName, string address, ulong idNumber, ulong phone, Region region)
            : base(firstName, lastName, address, idNumber, phone)
        {
            this.ObservedRegion = region;
        }

        public decimal CalculateSalary()
        {
            decimal salary = this.Salary;
            if (NewClientsCount >= 20)
            {
                salary += 500;
            }

            return salary;
        }
    }
}
