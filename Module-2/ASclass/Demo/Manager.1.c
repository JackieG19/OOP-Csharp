using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{      // sub class :  base class
    class Manager :  Employee // inherit from class Employee by appending with the semicolon
    {
        // class Manager automatically assumes the properties of class Employee
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}