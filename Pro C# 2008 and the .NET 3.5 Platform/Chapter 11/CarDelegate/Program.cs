#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarDelegate
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Delegates as event enablers *****\n");

      // Make a car as usual. 
      Car c1 = new Car("SlugBug", 100, 10);

      // Register event handlers.          
      Car.Exploded d = new Car.Exploded(CarExploded);
      c1.OnAboutToBlow(new Car.AboutToBlow(CarIsAlmostDoomed));
      c1.OnAboutToBlow(new Car.AboutToBlow(CarAboutToBlow));
      c1.OnExploded(d);

      // Speed up (this will generate the events.)
      Console.WriteLine("***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

      // Remove CarExploded method 
      // from invocation list.
      c1.RemoveExploded(d);

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
