using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNameClash
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
      Octagon oct = new Octagon();

      // This is now a compiler error!
      // oct.Draw();
      
      // We now must use casting to access the Draw()
      // members.
      IDrawToForm itfForm = (IDrawToForm)oct;
      itfForm.Draw();

      // Shorthand notation if you don't need 
      // the interface varaible for later use. 
      ((IDrawToPrinter)oct).Draw();

      // Always a good practice to test
      // before extracting an interface.
      if(oct is IDrawToMemory)
        ((IDrawToMemory)oct).Draw();

      Console.ReadLine();
    }
  }
}
