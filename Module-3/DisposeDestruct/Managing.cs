// Managing the Lifetime of an Object

/* One approach is to explicitly invoke the Dispose method after any other code that uses the object.
The following code example shows how to invoke the Dispose method on an object that implements
the IDisposable interface:*/

// Invoking the Dispose Method
var word = new ManagedWord();
 // Code to use the ManagedWord object.
word.Dispose();

/* A more reliable approach is to invoke the Dispose method in the finally block of a try/catch/finally or a try/finally statement.
In the scope of the finally block will always execute, regardless of any exceptions that might be thrown.
Therefore, can always guarantee that the code will invoke the Dispose method.*/

// Example: how to invoke the Dispose method in a finally block.

// Invoking the Dispose Method in a finally Block
var word = default(ManagedWord);
try
{
   word = new ManagedWord();
   // Code to use the ManagedWord object.
}
catch
{
    // Code to handle any errors.
}
finally
{
   if(word!=null)
      word.Dispose();
}


/* Alternatively, using a using statement to implicitly invoke the Dispose method.
A using block is exception safe, which means that if the code in the block throws an exception,
the runtime will still dispose of the objects that are specified in the using statement.*/

// Example - how to implicitly dispose of an object by using a using statement.

// Disposing Of an Object by Using a using Statement
using (var word = default(ManagedWord))
{
   // Code to use the ManagedWord object.
}