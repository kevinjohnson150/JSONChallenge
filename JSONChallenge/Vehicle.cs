using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Mileage { get; set; }
        public string LicensePlateNumber { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(
            string make, 
            string model,
            int year,
            decimal mileage,
            string licennsePlateNumber)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            LicensePlateNumber = licennsePlateNumber;
        }
    }

}
