/* Constructors are often used to specify initial or default values for
data members within the new object, as shown by the following example: */

// Adding a Constructor
public class DrinksMachine
{
   public int Age { get; set; }
   public DrinksMachine()
   {
      Age = 0;
   }
}

/*A constructor that takes no parameters is known as the default constructor.
This constructor is called whenever someone instantiates your class without providing any arguments.
If you do not include a constructor in your class, the Visual C# compiler will automatically add an
empty public default constructor to your compiled class.*/


/* Consumers of your class can use any of the constructors to create instances of your class,
depending on the information that is available to them at the time. For example: */

// Calling Constructors:
var dm1 = new DrinksMachine(2);
var dm2 = new DrinksMachine("Fourth Coffee", "BeanCrusher 3000");
var dm3 = new DrinksMachine(3, "Fourth Coffee", "BeanToaster Turbo");

