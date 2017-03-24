// This program illustrates the various loop and branch
// statements of C#.

using System;
using System.Collections.Generic;
using System.Text;

namespace IterationsAndDecisions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Loops and Branches *****");
      ForAndForEachLoop();
      ExecuteWhileLoop();
      ExecuteDoWhileLoop();
      ExecuteIfElse();
      ExecuteSwitch();
      ExecuteSwitchOnString();
      Console.ReadLine();
    }

    #region Helper Methods
    static void ForAndForEachLoop()
    {
      // Note! 'i' is only visible within the scope of the for loop.
      for (int i = 0; i < 4; i++)
      {
        Console.WriteLine("Number is: {0} ", i);
      }
      // 'i' is not visible here.

      string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
      foreach (string c in carTypes)
        Console.WriteLine(c);

      int[] myInts = { 10, 20, 30, 40 };
      foreach (int i in myInts)
        Console.WriteLine(i);
      Console.WriteLine();
    }

    static void ExecuteWhileLoop()
    {
      string userIsDone = "";

      // Test on a lower class copy of the string.
      while (userIsDone.ToLower() != "yes")
      {
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
        Console.WriteLine("In while loop");
      }
    }

    static void ExecuteDoWhileLoop()
    {
      string userIsDone = "";

      do
      {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
      } while (userIsDone.ToLower() != "yes");   // Note the semicolon!
    }

    static void ExecuteIfElse()
    {
      string stringData = "My textual data";
      // Legal, as this resolves to either true or false.
      if (stringData.Length > 0)
        Console.WriteLine("string is greater than 0 characters");
      else
        Console.WriteLine("string is less than 0 characters");
    }

    // Switch on a numerical value.
    static void ExecuteSwitch()
    {
      Console.WriteLine("1 [C#], 2 [VB]");
      Console.Write("Please pick your language preference: ");

      string langChoice = Console.ReadLine();
      int n = int.Parse(langChoice);

      switch (n)
      {
        case 1:
          Console.WriteLine("Good choice, C# is a fine language.");
          break;
        case 2:
          Console.WriteLine("VB .NET: OOP, multithreading, and more!");
          break;
        default:
          Console.WriteLine("Well...good luck with that!");
          break;
      }
    }
    static void ExecuteSwitchOnString()
    {
      Console.WriteLine("C# or VB");
      Console.Write("Please pick your language preference: ");

      string langChoice = Console.ReadLine();
      switch (langChoice)
      {
        case "C#":
          Console.WriteLine("Good choice, C# is a fine language.");
          break;
        case "VB":
          Console.WriteLine("VB .NET: OOP, multithreading and more!");
          break;
        default:
          Console.WriteLine("Well...good luck with that!");
          break;
      }
    }
    #endregion
  }
}
