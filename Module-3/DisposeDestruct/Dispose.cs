// Implementing the IDisposable Interface

/* To implement the IDisposable interface in your application, perform the following steps:

- Ensure that the System namespace is in scope by adding the using
  statement to the top of the code file: using System;

- Implement the IDisposable interface in your class definition.*/

 public class ManagedWord : IDisposable
    {
       public void Dispose()
       {
          throw new NotImplementedException();
       }
    }

/* - Add a private field to the class, which can be used to track the disposal status of the object,
     and check whether the Dispose method has already been invoked and the resources released.*/

  public class ManagedWord : IDisposable
    {
       bool _isDisposed;
       ...
    }

/* - Add code to any public methods in the class to check whether the object has already been
  disposed of. If the object has been disposed of, should throw an ObjectDisposedException.*/

   public void OpenWordDocument(string filePath)
    {
       if (this._isDisposed)
          throw new ObjectDisposedException("ManagedWord");
           ...
    }


/*
- Add an overloaded implementation of the Dispose method that accepts a Boolean parameter.

- The overloaded Dispose method should dispose of both managed and unmanaged resources if
  it was called directly, in which case, pass a Boolean parameter with the value true.

- If passing a Boolean parameter with the value of false, the Dispose method should only attempt to release unmanaged resources.
  Do this if the object has already been disposed of or is about to be disposed of by the GC.*/

    public class ManagedWord : IDisposable
    {
       ...
        protected virtual void Dispose(bool isDisposing)
        {
            if (this._isDisposed)
                return;
            if (isDisposing)
            {
               // Release only managed resources.
               ...
            }
            // Always release unmanaged resources.
            ...
            // Indicate that the object has been disposed.
            this._isDisposed = true;
        }
    }


/* - Add code to the parameterless Dispose method to invoke the overloaded Dispose method and then
     call the GC.SuppressFinalize method. The GC.SuppressFinalize method instructs the GC that the
     resources that the object referenced have already been released and the GC does not need to
     waste time running the finalization code.*/

 public void Dispose()
    {
       Dispose(true);
       GC.SuppressFinalize(this);
    }

/* After having implemented the IDisposable interface in the class definitions
Can then invoke the Dispose method on the object to release any resources that the object has consumed.
Can invoke the Dispose method from a destructor that is defined in the class. */



