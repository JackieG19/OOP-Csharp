using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2LabOne
{
    class TechnicalEmployee: Employee
    {
         //create integer variable called "successfulCheckins" and assigns value to 5
        public int successfulCheckins = 5;
        
        //calls upon base-class (Employee Clas) constructor from within derived class(TechnicalEmployee Class)
        //Sets baseSalary to 75000 for all TechnicalEmployee objects
        public TechnicalEmployee(String name) : base(name, 75000)
        {
           
        }

        //this method returns the toString() method - which is the employee's ID number and name - and prints the number of successful check ins the employee has had

        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckins + " successful check ins";
        }
    }
}