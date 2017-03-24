using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LinqOverArrayList
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ over ArrayList *****\n");

      // Here is a nongeneric collection of cars.
      ArrayList myCars = new ArrayList() {
        new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
        new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
        new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
        new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
        new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
      };

      // Transform ArrayList into an IEnumerable<T>-compatible type.
      IEnumerable<Car> myCarsEnum = myCars.OfType<Car>();

      // Create a query expression.
      var fastCars = from c in myCarsEnum where c.Speed > 55 select c;

      foreach (var car in fastCars)
      {
        Console.WriteLine("{0} is going too fast!", car.PetName);
      }
      Console.WriteLine();

      #region Get ints from an ArrayList of various items.
      // Extract the ints from the ArrayList.
      ArrayList myStuff = new ArrayList();
      myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
      IEnumerable<int> myInts = myStuff.OfType<int>();

      // Prints out 10, 400, and 8.
      foreach (int i in myInts)
      {
        Console.WriteLine("Int value: {0}", i);
      }
      #endregion

      Console.ReadLine();
    }
  }
}
