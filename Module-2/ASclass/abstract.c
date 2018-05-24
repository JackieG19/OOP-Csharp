// Abstract Classes

/* Abstract classes are closely related to interfaces, which will be covered in the next topic.
Abstract classes cannot be instantiated, which means we would not be able to create a new Employee
object in code with this statement: */

Employee newEmployee = new Employee();


/*An abstract class requires the subclass to implement some, or all, of the functionality. If we extend our
previous example of the Employee and Manager classes, using abstract classes, we can demonstrate this
concept better. Note that the employee class now includes some methods to implement behaviors.*/

abstract class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        .....

        public virtual void Login()
        {
        }

        public virtual void LogOff()
        {
        }

        public abstract void EatLunch();

    }

/*
Once you create an abstract class, you decide which methods "must" be implemented in
the sub classes and which methods "can" be implemented, or overridden, in the sub class.

Any method you declare in the abstract class that will contain some implementation in the abstract class,
but can be overridden in the sub class, you decorate with the virtual keyword.

You can write implementation code in the abstract class and sub classes are free to override the
implementation , or accept the implementation that is inherited.

There are specific constraints around an abstract method:

An abstract method cannot exist in non-abstract class
An abstract method is not permitted to have any implementation, including curly braces
An abstract method signature must end in a semi-colon
An abstract method MUST be implemented in any sub class. Failure to do so will generate a compiler warning in C#.
*/

