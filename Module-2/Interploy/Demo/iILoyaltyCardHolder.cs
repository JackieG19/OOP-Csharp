using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    // Defining an Interface
    public interface ILoyaltyCardHolder
    {
        // get accessor method, provide a way of seeing how many points are in the card itself
       int TotalPoints { get; }

       // accepts a decimal value which accepts a numeric value coming in at addPoint
       int AddPoints(decimal transactionValue);

       // if needed to reset points, a method that would be responsible for setting those points
       void ResetPoints();
    }
}