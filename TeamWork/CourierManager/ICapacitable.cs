using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public interface ICapacitable
    {
        int Capacity { get; set; }
        void AddLoad(int load);
    }
}
