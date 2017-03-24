using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDispose
{
  // Implementing IDisposable.
  public class MyResourceWrapper : IDisposable
  {
    // The object user should call this method
    // when they finished with the object.
    public void Dispose()
    {
      // Clean up unmanaged resources here.

      // Dispose other contained disposable objects.
   
      // Just for a test.
      Console.WriteLine("***** In Dispose! *****");
    }
  }
}
