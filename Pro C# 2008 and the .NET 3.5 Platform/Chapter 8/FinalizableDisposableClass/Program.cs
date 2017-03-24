using System;
using System.Collections.Generic;
using System.Text;

namespace FinalizableDisposableClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Dispose() / Destructor Combo Platter *****");
      
      // Call Dispose() manually, this will not call the destructor.
      // Comment out the Dispose() call to hear 2 beeps.
      MyResourceWrapper rw = new MyResourceWrapper();
      rw.Dispose();

      // Don't call Dispose(), this will trigger the destructor
      // and cause a beep.
      MyResourceWrapper rw2 = new MyResourceWrapper();
    }
  }
}
