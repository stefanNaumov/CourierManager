﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //secondFreight.DeleteBillOfLading();
            //Console.WriteLine(newFreight.BillOfLading);
            IndividualCustomer individual = new IndividualCustomer("Pesho", "Ivanov", "Sofia", 7802164242, 0888444555);
            //Console.WriteLine(individual.ClientNumber);
            CompanyCustomer company = new CompanyCustomer("a", "BobovDol", 1166445588, 5554448880);
            //Console.WriteLine(company.ClientNumber);
            CompanyCustomer newCompany = new CompanyCustomer("b", "Kaspichan", 1234567895, 1234567891);
            //Console.WriteLine(newCompany.ClientNumber);
            Freight newFreight = new Freight(25.2m,individual,company,Location.Bourgas);
            Freight secondFreight = new Freight(3.5m,company,newCompany,Location.Plovdiv);
            //Freight thirsFreight = new SmallPacket(4.6m);
            Console.WriteLine(EnumHelper.ReturnValue("VN"));
            Driver driver1 = new Driver("Kiro", "Zavoya", "Kashona 1", 6512158861, 359897587457);
            driver1.RoutesCount = 31;
            
            Console.WriteLine(driver1.CalculateSalary());
            Route route1 = new Route("Sofia-Burgas");
            route1.AddLocation(Location.Bourgas);
            route1.AddLocation(Location.Sofia);
            TransportUnit truckMercedes = new Truck("A1108HT");
            TransportUnit vanCitroen = new Van("A3409KM");
            vanCitroen.State = TransportUnitState.OnACourse;
            vanCitroen.CurrentRoute = route1;
            vanCitroen.CurrentDriver = driver1;
            //vanCitroen.AllUnits = vanCitroen.LoadAllTransportUnits();
            vanCitroen.WriteInDatabase();
            //var log = Logger.CurrentLogger;
        }
    }
}
