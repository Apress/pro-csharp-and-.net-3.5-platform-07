// This project illustrates basic I/O
// with the console and .NET string formatting.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConsoleIO
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Basic Console I/O *****");
      GetUserData();
      Console.WriteLine();
      FormatNumericalData();
      Console.ReadLine();
    }

    #region Formatting
    // Now make use of some format tags.
    static void FormatNumericalData()
    {
      Console.WriteLine("The value 99999 in various formats:");
      Console.WriteLine("c format: {0:c}", 99999);
      Console.WriteLine("d9 format: {0:d9}", 99999);
      Console.WriteLine("f3 format: {0:f3}", 99999);
      Console.WriteLine("n format: {0:n}", 99999);
      
      // Notice that upper or lower casing for hex 
      // determines if letters are upper/lowercase.
      Console.WriteLine("E format: {0:E}", 99999);
      Console.WriteLine("e format: {0:e}", 99999);
      Console.WriteLine("X format: {0:X}", 99999);
      Console.WriteLine("x format: {0:x}", 99999);
    }
    #endregion

    #region Get user data.
    static void GetUserData()
    {
      // Get name and age.
      Console.Write("Please enter your name: ");
      string userName = Console.ReadLine();
      Console.Write("Please enter your age: ");
      string userAge = Console.ReadLine();

      // Change echo color, just for fun.
      ConsoleColor prevColor = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;

      // Echo to the console.
      Console.WriteLine("Hello {0}!  You are {1} years old.",
          userName, userAge);

      // Restore origional color.
      Console.ForegroundColor = prevColor;
    }
    #endregion
  }
}
