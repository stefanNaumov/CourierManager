using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public class Route
    {
        //enum of locations - Location
        private List<Location> locations=new List<Location>();
        public string Name { get; set; }
        //TODO: Decide which is better,parameterless constructor,or constructor containing with parameter List<Location>()
        public Route(string name)
        {
            this.Name = name;
        }

        public void AddLocation(Location location)
        {
            this.locations.Add(location);
        }

        public void RemoveLocation(Location location)
        {
            if (locations.Count < 1)
            {
                throw new ArgumentException("There are no locations in the route!");
            }
            if (!(locations.Contains(location)))
            {
                throw new ArgumentException("No such location!");
            }
            locations.Remove(location);
        }
    }
}
