using System;
using System.Collections.Generic;
using System.Text;

// We need this to obtain the necessary
// interop attributes.
using System.Runtime.InteropServices;

namespace ComCallableDotNetServer
{
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [Guid("4137CFAB-530B-4667-ADF2-8E2CD63CB462")]
  [ComVisible(true)]
  public class DotNetCalc
  {
    public int Add(int x, int y)
    { return x + y; }

    public int Subtract(int x, int y)
    { return x - y; }
  }
}
