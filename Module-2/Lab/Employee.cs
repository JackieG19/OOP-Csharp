using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2LabOne
{
    abstract class Employee
    {
        //creates integer variable called 'employeeCount' and assigns value to 1
        private static int employeeCount = 1;

        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get{
                return employeeBaseSalary;
            }
            set{
                employeeBaseSalary = value;
            }
        }
 public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }


        //Constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        } 

        //this method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        //this method returns the employee's name
        public String getName()
        {
            return this.Name;
        }

         public int getEmployeeID()
        {
            return this.ID;
        }

        //This method returns the employee's ID and Name
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        //this method returns ther employee's ID and NAme and confirms that the employee is in the system

        public abstract String employeeStatus();
        
    }
}