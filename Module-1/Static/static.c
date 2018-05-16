// Creating Static Classes and Methods

/* In scenarios like this, you can create a static class. A static class is a class that cannot be
instantiated. To create a static class, you use the static keyword. Any members within the class must
also use the static keyword, as shown in the following example: */

// Static Classes
public static class Conversions
{
   public static double PoundsToKilos(double pounds)
   {
      // Convert argument from pounds to kilograms
      double kilos = pounds * 0.4536;
      return kilos;
   }
   public static double KilosToPounds(double kilos)
   {
      // Convert argument from kilograms to pounds
      double pounds = kilos * 2.205;
      return pounds;
   }
}


/* To call a method on a static class, you call the method on the class name
itself instead of on an instance name, as shown by the following example: */

//Calling Methods on a Static Class
double weightInKilos = 80;
double weightInPounds = Conversions.KilosToPounds(weightInKilos);


/* To declare a static member you use the static keyword before the return type of the member,
as shown by the following example: */

// Static Members in Non-static Classes
public class DrinksMachine
{
   public int Age { get; set; }
   public string Make { get; set; }
   public string Model { get; set; }
   public static int CountDrinksMachines()
   {
      // Add method logic here.
   }
}

/* Regardless of how many instances of your class exist, there is only ever one instance of a static
member. You do not need to instantiate the class in order to use static members. You access static
members through the class name rather than the instance name, as shown by the following example: */

// Access Static Members
int drinksMachineCount = DrinksMachine.CountDrinksMachines();
