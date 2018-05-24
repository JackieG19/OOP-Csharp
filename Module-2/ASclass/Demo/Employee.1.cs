using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    abstract class Employee // create a base class
    {
        public virtual void Login()
        {
            Console.WriteLine("Employee login");
        }

         public abstract void Hire();

        private string = empNumber; // private string variable
        private string = firstName;
        private string = lastName;
        private string = address;

        public string EmpNumber // properties established for each private variable,
        // default properties that assigned to this class so that we can have access to all the member variable
        {
            get { return empNumber; }
            set { empNumber = value; }
        }

          public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

          public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

          public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }

}