using System;
using System.Collections.Generic;
using System.Text;
using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Get a Type representing the Winnebago.
      Type t = typeof(Winnebago);

      // Get all attributes on the Winnebago.
      object[] customAtts = t.GetCustomAttributes(false);

      // Print the description.
      Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
      foreach (VehicleDescriptionAttribute v in customAtts)
        Console.WriteLine("-> {0}", v.Description);
      Console.ReadLine();
    }
  } 
}
