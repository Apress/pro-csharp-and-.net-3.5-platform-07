using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEnumeratorWithYield
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with the Yield Keyword *****\n");
      Garage carLot = new Garage();

      // Get items using GetEnumerator().
      foreach (Car c in carLot)
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.Speed);
      }

      Console.WriteLine();

      // Get items (in reverse!) using named iterator. 
      foreach (Car c in carLot.GetTheCars(true))
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.Speed);        
      }
      Console.ReadLine();
    }
  }
}
