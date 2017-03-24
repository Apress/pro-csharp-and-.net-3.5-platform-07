using System;
using System.Collections.Generic;
using System.Text;

namespace MIInterfaceHierarchy
{
  public class Square : IShape
  {
    // Using explicit implementation to handle member name clash.
    void IPrintable.Draw()
    { // Draw to printer ...
    }
    void IDrawable.Draw()
    { // Draw to screen ...
    }
    public void Print()
    { // Print ...
    }
    public int GetNumberOfSides()
    { return 4; }
  }
}
