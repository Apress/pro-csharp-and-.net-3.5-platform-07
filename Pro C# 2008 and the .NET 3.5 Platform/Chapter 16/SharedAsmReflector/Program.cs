using System;
using System.Reflection;
using System.IO;
using System.Linq;

namespace SharedAsmReflector
{
  public class SharedAsmReflector
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The Shared Asm Reflector App *****\n");

      // Load System.Windows.Forms.dll from GAC.
      string displayName = null;
      displayName = "System.Windows.Forms," +
        "Version=2.0.0.0," +
        "PublicKeyToken=b77a5c561934e089," +
        @"Culture=""";
      Assembly asm = Assembly.Load(displayName);
      DisplayInfo(asm);
      Console.WriteLine("Done!");
      Console.ReadLine();
    }

    #region Display info method
    private static void DisplayInfo(Assembly a)
    {
      Console.WriteLine("***** Info about Assembly *****");
      Console.WriteLine("Loaded from GAC? {0}", a.GlobalAssemblyCache);
      Console.WriteLine("Asm Name: {0}", a.GetName().Name);
      Console.WriteLine("Asm Version: {0}", a.GetName().Version);
      Console.WriteLine("Asm Culture: {0}",
        a.GetName().CultureInfo.DisplayName);
      Console.WriteLine("\nHere are the public enums:");

      // Use a LINQ query to find the public enums.
      Type[] types = a.GetTypes();
      var publicEnums = from pe in types
                        where pe.IsEnum &&
                          pe.IsPublic
                        select pe;

      foreach (var pe in publicEnums)
      {
        Console.WriteLine(pe);
      }
    }
    #endregion
  }
}
