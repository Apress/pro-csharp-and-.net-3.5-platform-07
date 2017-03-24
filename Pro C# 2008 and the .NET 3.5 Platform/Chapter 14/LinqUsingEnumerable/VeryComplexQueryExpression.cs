using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqUsingEnumerable
{
  class VeryComplexQueryExpression
  {
    public static void QueryStringsWithRawDelegates()
    {
      Console.WriteLine("***** Using Raw Delegates *****");

      // Assume we have an array of strings.
      string[] currentVideoGames = {"Morrowind", "BioShock",
        "Half Life 2: Episode 1", "The Darkness",
        "Daxter", "System Shock 2"};

      // Build the necessary Func<> delegates using anonymous methods.
      Func<string, bool> searchFilter = new Func<string, bool>(Filter);
      Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

      // Pass the delegates into the methods of Sequence.
      var subset = currentVideoGames
              .Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

      // Print out the results.
      foreach (var game in subset)
        Console.WriteLine("Item: {0}", game);
      Console.WriteLine();
    }

    // Delegate targets.
    public static bool Filter(string s) { return s.Length > 6; }
    public static string ProcessItem(string s) { return s; }
  }
}
