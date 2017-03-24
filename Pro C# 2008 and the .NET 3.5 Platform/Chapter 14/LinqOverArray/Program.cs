using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOverArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with LINQ *****\n");
      QueryOverStrings();
      Console.WriteLine();
      QueryOverInts();
      Console.ReadLine();
    }

    #region LINQ over string array
    static void QueryOverStrings()
    {
      // Assume we have an array of strings.
      string[] currentVideoGames = {"Morrowind", "BioShock",
        "Half Life 2: Episode 1", "The Darkness",
        "Daxter", "System Shock 2"};

      // Build a query expression to represent the items in the array
      // that have more than 6 letters.
      var subset = from g in currentVideoGames
                   where g.Length > 6
                   orderby g
                   select g;

      // Print out the results.
      foreach (string s in subset)
        Console.WriteLine("Item: {0}", s);
      Console.WriteLine();
      ReflectOverQueryResults(subset);
    }
    #endregion

    #region LINQ over int array with differed execution
    static void QueryOverInts()
    {
      int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

      // Get numbers less than ten. 
      System.Collections.IEnumerable subset = from i in numbers where i < 10 select i;
      
      // LINQ statment evalued here!
      foreach (var i in subset)
        Console.WriteLine("{0} < 10", i);
      Console.WriteLine();

      // Change some data in the array.
      numbers[0] = 4;

      // Evaulate again.
      foreach (var j in subset)
        Console.WriteLine("{0} < 10", j);
      Console.WriteLine();
      ReflectOverQueryResults(subset);
    }
    #endregion

    #region Immediate Execution
    static void ImmediateExecution()
    {
      int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

      // Get data NOW as int[].
      int[] subsetAsIntArray = 
        (from i in numbers where i < 10 select i).ToArray<int>();
 
      // Get data NOW as List<int>.
      List<int> subsetAsListOfInts =
        (from i in numbers where i < 10 select i).ToList<int>();
    }
    #endregion

    static void ReflectOverQueryResults(object resultSet)
    {
      Console.WriteLine("***** Info about your query *****");
      Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
      Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly);
    }
  }
}
