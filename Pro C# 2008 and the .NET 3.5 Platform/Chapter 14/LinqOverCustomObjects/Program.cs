using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOverCustomObjects
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** More fun with LINQ Expressions *****\n");

      // Make a List<> of Car objects
      // using the new object init syntax.
      List<Car> myCars = new List<Car>() {
        new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
        new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
        new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
        new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
        new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
      };

      GetFastCars(myCars);
      Console.ReadLine();
    }

    #region Get subset of List<Car>
    static void GetFastCars(List<Car> myCars)
    {
      // Create a query expression.
      // Create a query expression.
      var fastCars = from c in myCars
                     where
                       c.Speed > 90 && c.Make == "BMW"
                     select c;

      foreach (var car in fastCars)
      {
        Console.WriteLine("{0} is going too fast!", car.PetName);
      }
    }
    #endregion
  }
}
