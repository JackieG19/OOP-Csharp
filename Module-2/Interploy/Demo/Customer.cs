using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Customer : ILoyaltyCardHolder
    {
        // Implementing an Interface
        public class Customer : ILoyaltyCardHolder
        {
           private int totalPoints;

           // public accessor method or property for returning the total points
           public int TotalPoints
           {
              get { return totalPoints; }
           }

           // public method that accepts a value coming it
           public int AddPoints(decimal transactionValue)
           {
               // converts the value inti an integer
              int points = Decimal.ToInt32(transactionValue);

              // adds those to the totalPoints
              totalPoints += points;

              // returns the totalPoints to whatever method called it
              return totalPoints;
           }

           public void ResetPoints() // reset method which resets the point itself
           {
              totalPoints = 0;
           }
           // Other members of the Customer class.
        }
    }
}