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
            DrinkMachine myMachine = new DrinkMachine("Kitchen", "Brand", "DM1000");
            // myMachine._location = "kitchen"; - No longer needed
            // myMachine._model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);

            myMachine.MakeCappuccino();
        }
    }
}