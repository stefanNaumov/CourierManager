using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CourierManager
{
    public class IndividualCustomer : Customer, IPerson
    {
        //private string filePath;
        private string pathToDatabase = "../../IndividualCustomers.txt";

        public string PathToDatabase 
        {
            get { return pathToDatabase; }
            set { pathToDatabase = value; }
        }

        private List<string> ClientsList { get; set; }

        public bool WillWrite { get; set; }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public IndividualCustomer(ulong idNumber)
            : this(null, null, null, idNumber, 0)
        { }


        public IndividualCustomer(string firstName, string lastName, string address, ulong idNumber, ulong phone, bool willWrite=true)
            : base(address, idNumber, phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WillWrite = willWrite;
            if (this.FirstName!=null)
            {
                this.ClientsList = this.ReadClientData();
                if (this.IsANewCustomer && this.WillWrite)
                {
                    //see comments in CompanyCustomer.cs
                    this.ClientNumber = this.ClientsList.Count;
                    this.SaveClientData();
                }
            }
        }

        public override List<string> ReadClientData()
        {
            List<string> individualCustomers = new List<string>();

            StreamReader reader = new StreamReader(this.PathToDatabase);
            int lineCounter = 1;
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    string[] splitLine = currentLine.Split('*');
                    if (splitLine[4] == this.IDNumber.ToString())
                    {
                        this.IsANewCustomer = false;
                        this.ClientNumber = lineCounter;
                    }
                    lineCounter++;
                    individualCustomers.Add(currentLine);
                    currentLine = reader.ReadLine();
                }
            }
            return individualCustomers;
        }

        public override void SaveClientData()
        {
            StreamWriter writer = new StreamWriter(this.PathToDatabase, true);
            using (writer)
            {
                string individual = String.Format("{0}*{1}*{2}*{3}*{4}*{5}", this.ClientNumber+1, this.FirstName, this.LastName,
                this.Address, this.IDNumber, this.Phone);
                writer.WriteLine(individual);
            }
        }

        
    }
}
