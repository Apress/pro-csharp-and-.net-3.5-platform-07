using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithLinqExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Query Expressions *****\n");

      // This array will be the basis of our testing...
      Car[] myCars = new[] {
        new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
        new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
        new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
        new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
        new Car{ PetName = "Hank", Color = "Tan", Speed = 0, Make = "Ford"},
        new Car{ PetName = "Sven", Color = "White", Speed = 90, Make = "Ford"},
        new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
        new Car{ PetName = "Zippy", Color = "Yellow", Speed = 55, Make = "VW"},
        new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
      };

      // We will call various methods here!
      BasicSelection(myCars);
      GetSubsets(myCars);
      ReversedSelection(myCars);
      OrderedResults(myCars);
      GetDiff();
      Console.ReadLine();
    }

    #region Basic selections
    static void BasicSelection(Car[] myCars)
    {
      // Get everything.
      Console.WriteLine("All cars:");
      var allCars = from c in myCars select c;
      foreach (var c in allCars)
      {
        Console.WriteLine(c.ToString());
      }
      Console.WriteLine();

      // Now get only the names of the cars.
      Console.WriteLine("Only PetNames:");
      var names = from c in myCars select c.PetName;
      foreach (var n in names)
      {
        Console.WriteLine("Name: {0}", n);
      }
      Console.WriteLine();

      var makes = from c in myCars select c.Make;
      Console.WriteLine("Distinct makes:");
      foreach (var m in makes.Distinct<string>())
      {
        Console.WriteLine("Make: {0}", m);
      }
    }
    #endregion

    #region Get subsets
    static void GetSubsets(Car[] myCars)
    {
      // Now get only the BMWs.
      var onlyBMWs = from c in myCars where c.Make == "BMW" select c;

      foreach (Car c in onlyBMWs)
      {
        Console.WriteLine(c.ToString());
      }
      Console.WriteLine();

      // Get BMWs going at least 100 mph.
      var onlyFastBMWs = from c in myCars
                         where c.Make == "BMW" && c.Speed >= 100
                         select c;

      foreach (Car c in onlyFastBMWs)
      {
        Console.WriteLine("{0} is going {1} MPH", c.PetName, c.Speed);
      }
      Console.WriteLine();

      var makesColors = from c in myCars select new { c.Make, c.Color };
      foreach (var o in makesColors)
      {
        // Could also use Make and Color properties directly.
        Console.WriteLine(o.ToString());
      }
      Console.WriteLine();
    }
    #endregion

    #region Reverse selections
    static void ReversedSelection(Car[] myCars)
    {
      // Get everything in reverse.
      Console.WriteLine("All cars in reverse:");
      var subset = from c in myCars select c;
      foreach (Car c in subset.Reverse<Car>())
      {
        Console.WriteLine(c.ToString());
      }
      Console.WriteLine();
    }
    #endregion

    #region order selections
    static void OrderedResults(Car[] myCars)
    {
      // Order all the cars by PetName.
      var subset = from c in myCars orderby c.PetName select c;

      Console.WriteLine("Ordered by PetName:");
      foreach (Car c in subset)
      {
        Console.WriteLine(c.ToString());
      }

      // Now find the cars that are going less than 55 mph,
      // and order by descending PetName
      subset = from c in myCars
               where c.Speed > 55
               orderby c.PetName descending
               select c;
      Console.WriteLine("\nCars going faster than 55, ordered by PetName:");
      foreach (Car c in subset)
      {
        Console.WriteLine(c.ToString());
      }
      Console.WriteLine();

    }
    #endregion

    #region Get difference
    static void GetDiff()
    {
      List<string> myCars = new List<String>
      { "Yugo", "Aztec", "BMW"};

      List<string> yourCars = new List<String>
      { "BMW", "Saab", "Aztec" };

      var carDiff =(from c in myCars select c)
        .Except(from c2 in yourCars select c2);

      Console.WriteLine("Here is what you don't have, but I do:");
      foreach (string s in carDiff)
        Console.WriteLine(s);
    }
    #endregion

    #region Get count
    static void GetCount()
    {
      string[] currentVideoGames = {"Morrowind", "BioShock",
              "Half Life 2: Episode 1", "The Darkness",
              "Daxter", "System Shock 2"};

      // Get count from the query.
      int numb = (from g in currentVideoGames
                  where g.Length > 6
                  orderby g
                  select g).Count<string>();

      // numb is the value 5.
      Console.WriteLine("{0} items honor the LINQ query.", numb);
    }
    #endregion
  }
}
