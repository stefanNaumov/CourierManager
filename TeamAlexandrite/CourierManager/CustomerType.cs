using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public enum CustomerType
    {   [Description("Individual customer")]
        Individual,
        [Description("Company customer")]
        Company
    }
}
