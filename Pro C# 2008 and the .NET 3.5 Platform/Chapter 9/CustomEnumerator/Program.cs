using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace CustomEnumerator
{
  // This seems reasonable...
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");

      Garage carLot = new Garage();

      // Hand over each car in the collection?
      foreach (Car c in carLot)
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.Speed);
      }
      
      Console.WriteLine();

      // Manually work with IEnumerator.
      IEnumerator i = carLot.GetEnumerator();
      i.MoveNext();
      Car myCar = (Car)i.Current;
      Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.Speed);
      Console.ReadLine();
    }
  }
}
