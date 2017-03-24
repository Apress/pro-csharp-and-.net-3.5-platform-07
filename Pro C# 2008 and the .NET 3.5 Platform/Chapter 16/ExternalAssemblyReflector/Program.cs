using System;
using System.Reflection;
using System.IO;  // For FileNotFoundException definition.

namespace ExternalAssemblyReflector
{
  class Program
  {
    #region Helper method
    static void DisplayTypesInAsm(Assembly asm)
    {
      Console.WriteLine("\n***** Types in Assembly *****");
      Console.WriteLine("->{0}", asm.FullName);
      Type[] types = asm.GetTypes();
      foreach (Type t in types)
        Console.WriteLine("Type: {0}", t);
      Console.WriteLine("");
    }
    #endregion

    static void Main(string[] args)
    {
      Console.WriteLine("***** External Assembly Viewer *****");

      string asmName = "";
      bool userIsDone = false;
      Assembly asm = null;

      #region Loop for assembly to display
      do
      {
        Console.WriteLine("\nEnter an assembly to evaluate");
        Console.Write("or enter Q to quit: ");

        // Get name of assembly.
        asmName = Console.ReadLine();

        // Does user want to quit?
        if (asmName.ToUpper() == "Q")
        {
          userIsDone = true;
          break;
        }

        // Try to load assembly.
        try
        {
          asm = Assembly.Load(asmName);
          DisplayTypesInAsm(asm);
        }
        catch
        {
          Console.WriteLine("Sorry, can't find assembly.");
        }
      } while (!userIsDone);
      #endregion
    }
  }
}
