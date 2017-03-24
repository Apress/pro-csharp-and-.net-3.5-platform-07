using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNameClash
{
  class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
  {
    void IDrawToForm.Draw()
    {
      // Shared drawing logic.
      Console.WriteLine("Drawing to form...");
    }
    void IDrawToMemory.Draw()
    {
      // Shared drawing logic.
      Console.WriteLine("Drawing to memory...");
    }
    void IDrawToPrinter.Draw()
    {
      // Shared drawing logic.
      Console.WriteLine("Drawing to a printer...");
    }
  }
}
