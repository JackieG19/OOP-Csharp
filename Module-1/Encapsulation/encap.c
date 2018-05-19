/* The following code shows an example of properties being declared in the DrinksMachine class: */

public class DrinksMachine
{
   // private member variables
   private int age;
   private string make;


   // public properties
   public int Age
   {
      get
      {
         return age;
      }
      set
      {
         age = value;
      }
   }
   public string Make
   {
      get
      {
         return make;
      }
      set
      {
         make = value;
      }
   }

   // auto-implemented property
   public string Model { get; set; }

      // Constructors
   public DrinksMachine(int age)
   {
      this.Age = age;
   }
   public DrinksMachine(string make, string model)
   {
      this.Make = make;
      this.Model = model;
   }
   public DrinksMachine(int age, string make, string model)
   {
      this.Age = age;
      this.Make = make;
      this.Model = model;
   }
}

// The properties are Age, Make, and Model.
// These properties would be backed by private member variables called age, make, and model.


/* The following example demonstrates auto-implemented properties: */

// Auto-implemented properties
public double TotalPurchases { get; set; }
public string Name { get; set; }
public int CustomerID { get; set; }...
