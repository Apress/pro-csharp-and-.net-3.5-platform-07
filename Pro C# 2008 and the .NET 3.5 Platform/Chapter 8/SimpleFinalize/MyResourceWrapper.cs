using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFinalize
{
  class MyResourceWrapper
  {
    ~MyResourceWrapper()
    {
      // Clean up unmanaged resources here.

      // Beep when destroyed (testing purposes only!)
      Console.Beep();
    }
  }
}
