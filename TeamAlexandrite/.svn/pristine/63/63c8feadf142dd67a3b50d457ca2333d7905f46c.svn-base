using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public class Van : TransportUnit,ICapacitable
    {
        //we assume that the van has a maximum capacity of 1000
        public Van(string licensePlate) 
            : base(licensePlate, 1000)
        {
            
        }

        public void AddLoad(int load)
        {
            //Check if the transport unit can carry more load.this.Capacity - 50 because the unit cannot be filled at 100%
            if (this.Load + load < this.Capacity - 50)
            {
                this.Load += load;
            }
        }
    }
}
