using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class DrinkMachine
    {
        // a constructor is public assess modifier keyword (specify value)
        public DrinkMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Location = model;
        }

        private string _location; // private string variable

        public string Location // public accessor methods, property
        {
            get { return _location; } // getters = returns the value/the private member variable
            set { _location = value; } // setters = sets it to value*
        }

        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model;

         public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino in made.");
        }

        public void MakeEspresso()
        {
            // Method logic goes here
        }

    }

}

/* Note:
When going to the processof applying those value in the code will be using "value" as the parameter
that as accepted, or has brought in the value itself*/