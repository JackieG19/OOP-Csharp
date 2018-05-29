using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates Employee Object with name Libby and salary 2000 called employee1

            var employee1 = new TechnicalEmployee("Libby");

             //Instantiates TechincalEmployee Object with name Zaynah called employee2
             var employee2 = new TechincalEmployee("Zaynah");

              //Instantiates BusinessEmployee Object with name Winter called employee3
              var employee3 = new BusinessEmployee("Winter");

              Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }    
}