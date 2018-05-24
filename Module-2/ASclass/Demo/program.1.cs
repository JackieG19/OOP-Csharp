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
            //Employee newEmp = new Employee();
            //newEmp.Login();

            Manager myManager = new Manager();
            //myManager.Department
            myManager.Login();
            myManager.Hire();

            #region Anon Class
        }
    }
}