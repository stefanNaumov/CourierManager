using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public abstract class TransportUnit
    {
        public string LicensePlate { get; set; }
        public int Load { get; set; }
        public Driver CurrentDriver { get; set; }
        public int Capacity { get; set; }
        public TransportUnitState State { get; set; }
        public List<string> AllUnits { get; set; }
        //public bool IsBeingRepaired { get; protected set; }
        //public bool IsOnACourse { get; protected set; }
        public Route CurrentRoute { get; set; }
        public bool IsANewTransportUnit { get; set; }

        public TransportUnit(string licensePlate, int capacity)
        {
            //if (this.Load >= this.Capacity)
            //{
            //    throw new ArgumentException("Load cannot be bigger tha capacity!");
            //}
            this.LicensePlate = licensePlate;
            //this.Load = load;
            this.Capacity = capacity;
            this.State = TransportUnitState.Available;
            this.IsANewTransportUnit = true;
            this.AllUnits = LoadAllTransportUnits();
            WriteInDatabase();
        }

        //public bool IsUnitAvaliable
        //{
        //    get { return !this.IsBeingRepaired && !this.IsOnACourse; }
        //}

        public void WriteInDatabase()
        {
            this.AllUnits = LoadAllTransportUnits();
            StreamWriter writeInFile = new StreamWriter(@"..\..\TransportUnits.txt");
            using (writeInFile)
            {
                if (this.AllUnits.Count != 0)
                {
                    foreach (string currentRow in this.AllUnits)
                    {
                        if (currentRow.Split('*')[0] != this.LicensePlate)
                        {
                            if (!String.IsNullOrEmpty(currentRow))
                            {
                                writeInFile.WriteLine(currentRow);
                            }
                        }
                        else
                        {
                            writeInFile.Write("{0}*{1}*{2}",
                                this.LicensePlate, this.Load, this.State);

                            if (this.State == TransportUnitState.OnACourse)
                            {
                                writeInFile.WriteLine("*{0}*{1}", this.CurrentRoute.Name, this.CurrentDriver.IDNumber);
                            }
                            else
                            {
                                writeInFile.WriteLine();
                            }
                            this.IsANewTransportUnit = false;
                        }
                    }
                }

                if (IsANewTransportUnit)
                {
                    writeInFile.WriteLine("{0}*{1}*{2}",
                                this.LicensePlate, this.Load, this.State);
                }
            }
        }

        public List<string> LoadAllTransportUnits()
        {
            List<string> allUnits = new List<string>();
            if (File.Exists(@"..\..\TransportUnits.txt"))
            {
                StreamReader readFromFile = new StreamReader(@"..\..\TransportUnits.txt");

                using (readFromFile)
                {
                    string currentRow = readFromFile.ReadLine();
                    while (currentRow != null)
                    {
                        allUnits.Add(currentRow);
                        currentRow = readFromFile.ReadLine();
                    }
                }
            }
            return allUnits;
        }
    }
}
