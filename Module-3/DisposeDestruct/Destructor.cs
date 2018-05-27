// Implementing a Destructor

// Example that shows the syntax for adding a destructor:

// Defining a Destructor
class ManagedWord
{
    ...
    // Destructor
    ~ManagedWord()
    {
        // Destructor logic.
    }
}

/* When you declare a destructor, the compiler automatically converts it to an override of the
Finalize method of the object class. However, you cannot explicitly override the Finalize method;
you must declare a destructor and let the compiler perform the conversion.*/


/* To guarantee the Dispose method is always invoked, you can include it as part of the finalization
process that the GC performs. To do this, add a call to the Dispose method in the destructor of the class.*/

// The following code example shows how to invoke the Dispose method from a destructor.

// Calling the Dispose Method from a Destructor
class ManagedWord
{
    ...
    // Destructor
    ~ManagedWord()
    {
        Dispose(false);
    }
}