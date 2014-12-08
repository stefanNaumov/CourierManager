﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public class Driver : Employee, ISalary 
    {
        public Route DriverRoute { get; set; }
        public int RoutesCount { get; set; }
        
        public Driver(string firstName, string lastName, string address, ulong idNumber, ulong phone) 
            : base(firstName, lastName, address, idNumber, phone)
        {
            
        }

        public decimal CalculateSalary()
        {
            decimal salary = this.Salary;
            if (RoutesCount >= 30)
            {
                salary += 250;
            }

            return salary;
        }
    }
}
