using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDXLabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();

            Car1.Color = "Silver";
            Car1.Year = 2004;
            Car1.Mileage = 180000;

            var Car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now.");    
        }
    }

    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }
        private static int instances = 0;

        public Car()
        {
            instances++;
        }
        public static int CountCars()
        {
            return instances;
        }
    }   
}
