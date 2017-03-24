// This program illustrates a simple C# app.
//
// Note, I have specified command line args
// using the Properties window for testing.
//
// Also note I have included the *.bat file in 
// this project if you wish to test for the app's
// error code (see text).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpApp
{
  class Program
  {
    static int Main(string[] args)
    {
      // Display a message.
      Console.WriteLine("***** My First C# App *****");
      Console.WriteLine("Hello World!");
      Console.WriteLine();

      // Process any incoming args.
      for (int i = 0; i < args.Length; i++)
        Console.WriteLine("Arg: {0}", args[i]);

      #region Other ways to process args...
      //// Process any incoming args using foreach.
      //foreach(string arg in args)
      //    Console.WriteLine("Arg: {0}", arg);

      //// Get arguments using System.Environment.
      //string[] theArgs = Environment.GetCommandLineArgs();
      //foreach(string arg in theArgs)
      //    Console.WriteLine("Arg: {0}", arg);
      #endregion

      // Show various details about the box
      // running our app.
      ShowEnvironmentDetails();

      // Wait for the Enter key to be pressed.
      Console.ReadLine();

      // Return an arbitrary error code.
      return -1;
    }

    #region Helper method
    static void ShowEnvironmentDetails()
    {
      // Print out the drives on this machine,
      // and other interesteing details.
      foreach (string drive in Environment.GetLogicalDrives())
        Console.WriteLine("Drive: {0}", drive);

      Console.WriteLine("OS: {0}", Environment.OSVersion);
      Console.WriteLine("Number of processors: {0}",
          Environment.ProcessorCount);
      Console.WriteLine(".NET Version: {0}",
          Environment.Version);
    }
    #endregion
  }
}
