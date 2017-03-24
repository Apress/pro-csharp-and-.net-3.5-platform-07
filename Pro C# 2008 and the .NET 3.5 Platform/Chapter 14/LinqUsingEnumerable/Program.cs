using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqUsingEnumerable
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The Various Flavors of LINQ *****\n");
      QueryStringWithOperators();
      QueryStringsWithEnumerableAndLambdas();
      QueryStringsWithAnonymousMethods();
      VeryComplexQueryExpression.QueryStringsWithRawDelegates();
      Console.ReadLine();
    }

    #region LINQ with operators
    static void QueryStringWithOperators()
    {
      Console.WriteLine("***** Using Query Operators *****");

      string[] currentVideoGames = {"Morrowind", "BioShock",
        "Half Life 2: Episode 1", "The Darkness",
        "Daxter", "System Shock 2"};

      // Build a query expression using query operators.
      var subset = from g in currentVideoGames
                   where g.Length > 6
                   orderby g
                   select g;

      // Print out the results.
      foreach (var s in subset)
        Console.WriteLine("Item: {0}", s);
      Console.WriteLine();
    }
    #endregion

    #region LINQ with Enumerable / Lambdas
    static void QueryStringsWithEnumerableAndLambdas()
    {
      Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");

      string[] currentVideoGames = {"Morrowind", "BioShock",
        "Half Life 2: Episode 1", "The Darkness",
        "Daxter", "System Shock 2"};

      // Build a query expression using extension methods
      // granted to the Array via the Sequence type.
      //var subset = currentVideoGames.Where(game => game.Length > 6)
      //  .OrderBy(game => game).Select(game => game);

      var subset = Enumerable.Where(currentVideoGames, game => game.Length > 6)
      .OrderBy(game => game).Select(game => game);

      // Print out the results.
      foreach (var game in subset)
        Console.WriteLine("Item: {0}", game);
      Console.WriteLine();
    }
    #endregion

    #region LINQ with anonymous methods
    static void QueryStringsWithAnonymousMethods()
    {
      Console.WriteLine("***** Using Anonymous Methods *****");

      string[] currentVideoGames = {"Morrowind", "BioShock",
        "Half Life 2: Episode 1", "The Darkness",
        "Daxter", "System Shock 2"};

      // Build the necessary Func<> delegates using anonymous methods.
      Func<string, bool> searchFilter =
        delegate(string game) { return game.Length > 6; };
      Func<string, string> itemToProcess = delegate(string s) { return s; };

      // Pass the delegates into the methods of Enumerable.
      var subset = currentVideoGames.Where(searchFilter)
        .OrderBy(itemToProcess).Select(itemToProcess);

      // Print out the results.
      foreach (var game in subset)
        Console.WriteLine("Item: {0}", game);
      Console.WriteLine();
    }
    #endregion 
  }
}
