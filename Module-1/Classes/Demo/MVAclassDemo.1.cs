using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class program
    {
        static void Main(string[] args)
        {
            DrinkMachine myMachine = new DrinkMachine(); // created a new object

            // start assgining value
            myMachine._location = "kitchen"; // assign value to member variable
            myMachine._model = "DM1000";

            Console.WriteLine(myMachine._location); // output the information to the screen
            myMachine.MakeCappuccino(); // call that method
        }
    }
}