using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public class InvalidIDNumberException 
        : ApplicationException
    {
        private readonly string iDNumber;

        public string IDNumber
        {
            get { return iDNumber; }
        }

        public InvalidIDNumberException(string msg, Exception innerEx, string iDNumber)
            : base(msg,innerEx)
        {
            this.iDNumber = iDNumber;
        }

        public InvalidIDNumberException(string msg, string iDNumber)
            : this(msg, null, iDNumber)
        { 
        }
    }
}
