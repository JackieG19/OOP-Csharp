using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class DrinkMachine
    {
        public DrinkMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Location = model;
        }

        private string _location;

        public string Location
        {
            get { return _location; }
            get { _location = value; }
        }

        private string _make;

        public string Make
        {
            get { return _make; }
            get { _make = value; }
        }

        private string _model;

         public string Model
        {
            get { return _model; }
            get { _model = value; }
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