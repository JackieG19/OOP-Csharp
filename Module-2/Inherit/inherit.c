/*To inherit from base class in C#, you append your derived class name with a colon and the name of the base
class. The following example demonstrates the Manager class inheriting the Employee base class from the
previous topic's UML diagram.*/

class Manager : Employee
{
    private char payRateIndicator;
    private Employee[] emps;
}

/*This simple class definition in C# lists the keyword class followed by the class name Manager,
a colon and then the name of the base class Employee. Looking at this snippet we can't tell what the
Manager class has inherited from Employee so we would need to look at that class as well to understand all
the properties available for us. The Employee class is shown here:*/

class Employee
{
    private string empNumber;
    private string firstName;
    private string lastName;
    private string address;

    public string EmpNumber
    {
        get
        {
            return empNumber;
        }

        set
        {
            empNumber = value;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }

        set
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }

        set
        {
            lastName = value;
        }
    }

    public string Address
    {
        get
        {
            return address;
        }

        set
        {
            address = value;
        }
    }
}

// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance