using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneableExample
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** A First Look at Interfaces *****\n");

      // All of these types support the ICloneable interface.
      string myStr = "Hello";
      OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
      System.Data.SqlClient.SqlConnection sqlCnn = 
        new System.Data.SqlClient.SqlConnection();

      // Therefore, they can all be passed into a method taking ICloneable.
      CloneMe(myStr);
      CloneMe(unixOS);
      CloneMe(sqlCnn);
      Console.ReadLine();
    }

    private static void CloneMe(ICloneable c)
    {
      // Clone whatever we get and print out the name.
      object theClone = c.Clone();
      Console.WriteLine("Your clone is a: {0}", 
        theClone.GetType().Name);
    }
  }
}