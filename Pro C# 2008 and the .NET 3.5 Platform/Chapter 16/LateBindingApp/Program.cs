using System;
using System.Collections.Generic;
using System.Text;

using System.Reflection;
using System.IO;

/* You  must have a copy of carlibrary.dll in 
 * your application directory for this applicaion to 
 * work! */

namespace LateBindingApp
{
  // Create a type dynamically.
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Late Binding *****");
      // Try to load a local copy of CarLibrary.
      Assembly a = null;
      try
      {
        a = Assembly.Load("CarLibrary");
      }
      catch (FileNotFoundException e)
      {
        Console.WriteLine(e.Message);
        return;
      }

      #region Invoke members via late binding
      // Get metadata for the Minivan type.
      Type miniVan = a.GetType("CarLibrary.MiniVan");

      // Create the Minivan on the fly.
      object obj = Activator.CreateInstance(miniVan);
      Console.WriteLine("Created a {0} using late binding!", obj);

      // Get info for TurboBoost.
      MethodInfo mi = miniVan.GetMethod("TurboBoost");

      // Invoke method ('null' for no parameters).
      mi.Invoke(obj, null);

      // Bind late to a method taking params.
      object[] paramArray = new object[2];
      paramArray[0] = "Fred";  // Child name.
      paramArray[1] = 4;       // Shame Intensity.
      mi = miniVan.GetMethod("TellChildToBeQuiet");
      mi.Invoke(obj, paramArray);
      
      #endregion

      Console.ReadLine();
    }
  } 
}
