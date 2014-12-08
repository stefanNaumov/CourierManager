using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CourierManager
{
    public abstract class Customer : Subject
    {
        //public int ClientNumber { get; set; }
        protected bool IsANewCustomer { get; set; }
        public int ClientNumber { get; set; }

        public Customer(string address, ulong idNumber, ulong phone) 
            : base(address, idNumber, phone)
        {
            //we assume that the client is a new one.In ReadClientData() we compare every clients IDNumber and if it is equal
            //to the current Customer IdNumber we change the propert value to false
            this.IsANewCustomer = true;
        }
       
        //abstract methods overriden in inheritor classes
        public abstract List<string> ReadClientData();
        public abstract void SaveClientData();
        
    }
   
}
