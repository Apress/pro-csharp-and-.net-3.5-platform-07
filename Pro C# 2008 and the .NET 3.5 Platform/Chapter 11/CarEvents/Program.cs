#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarEvents
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Events *****\n");

      // Make a car as usual. 
      Car c1 = new Car("SlugBug", 100, 10);

      // Register event handlers.          
      c1.AboutToBlow += new Car.CarEventHandler(CarIsAlmostDoomed);
      c1.AboutToBlow += new Car.CarEventHandler(CarAboutToBlow);

      Car.CarEventHandler d = new Car.CarEventHandler(CarExploded);
      c1.Exploded += d;

      // Speed up (this will generate the events.)
      Console.WriteLine("***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

      // Remove CarExploded method 
      // from invocation list.
      c1.Exploded -= d;

      Console.WriteLine("\n***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

      Console.ReadLine();
    }

    public static void CarAboutToBlow(string msg)
    { Console.WriteLine(msg); }

    public static void CarIsAlmostDoomed(string msg)
    { Console.WriteLine("Critical Message from Car: {0}", msg); }

    public static void CarExploded(string msg)
    { Console.WriteLine(msg); }
  }
}
