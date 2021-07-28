using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Kevin";
            person.LastName = "Johnson";
            person.DOB = new DateTime(1997, 3, 3);
            person.FavoriteIceCreamFlavors = new List<string>
            {
                "Strawberry",
                "Cookie Dough"
            };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);
            Console.ReadKey();

            Event eventChallenge = new Event();

            eventChallenge.StartDate = new DateTime(2021, 7, 27);
            eventChallenge.EndDate = new DateTime(2021, 7, 31);
            eventChallenge.Title = "Gen Con";
            eventChallenge.Capacity = 10000;
            eventChallenge.Price = 325.50m;

            string json1 = JsonConvert.SerializeObject(eventChallenge);

            Console.WriteLine(json1);
            Console.ReadKey();

            Badge badge = new Badge();

            badge.BadgeID = "12345";
            badge.ListOfDoors = new List<string>
            {
                "A1",
                "B2",
                "B5",
                "G21"
            };
            badge.HasSecurityClearance = true;
            badge.EmployeeID = "F54G678HJ32321S";
            badge.CreatedOn = DateTime.Now;

            string json2 = JsonConvert.SerializeObject(badge);

            Console.WriteLine(json2);
            Console.ReadKey();

            Vehicle vehicle = new Vehicle();

            vehicle.Make = "Dodge";
            vehicle.Model = "Challenger";
            vehicle.Year = 2017;
            vehicle.Mileage = 27456m;
            vehicle.LicensePlateNumber = "393DFD";

            string json3 = JsonConvert.SerializeObject(vehicle);

            Console.WriteLine(json3);
            Console.ReadKey();




        }
    }
}
