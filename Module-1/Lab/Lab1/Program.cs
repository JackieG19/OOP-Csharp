using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDXLabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();

            Car1.Color = "Silver";
            Car1.Year = 2004;
            Car1.Mileage = 180000;

            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles.");
        }
    }

    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
