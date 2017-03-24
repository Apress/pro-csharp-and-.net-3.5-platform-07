using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqRetValues
{
  class Car
  {
    public string PetName = string.Empty;
    public string Color = string.Empty;
    public int Speed;
    public string Make = string.Empty;
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ Transformations *****\n");
      IEnumerable<string> subset = GetStringSubSet();
      foreach (string item in subset)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      Array objs = GetProjectedSubset();
      foreach (object o in objs)
      {
        Console.WriteLine(o.ToString());
      }
      Console.ReadLine();
    }

    #region Return IEnumerable<>
    static IEnumerable<string> GetStringSubSet()
    {
      // Assume we have an array of strings.
      string[] currentVideoGames = {"Morrowind", "BioShock",
        "Half Life 2: Episode 1", "The Darkness",
        "Daxter", "System Shock 2"};

      // Build a query expression to represent the items in the array
      // that have more than 6 letters.
      IEnumerable<string> subset = from g in currentVideoGames
                                   where g.Length > 6
                                   orderby g
                                   select g;
      return subset;
    }
    #endregion 

    #region Return Array object
    // Return value is now an Array.
    static Array GetProjectedSubset()
    {
      Car[] myCars = new Car[]{
        new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
        new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
        new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
        new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
        new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
      };

      var makesColors = from c in myCars select new { c.Make, c.Color };

      // Map set of anonymous objects to an Array object.
      return makesColors.ToArray();
    }
    #endregion 
  }
}
