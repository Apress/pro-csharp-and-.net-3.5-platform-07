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
      Console.WriteLine("***** Prim and Proper Events *****\n");

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

    #region Handlers
    public static void CarAboutToBlow(object sender, CarEventArgs e)
    { Console.WriteLine("{0} says: {1}", sender, e.msg); }

    public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
    {
      // Just to be safe, perform a 
      // runtime check before casting.
      if (sender is Car)
      {
        Car c = (Car)sender;
        c.CrankTunes(false);
      }
      Console.WriteLine("Critical Message from {0}: {1}", sender, e.msg);
    }

    public static void CarExploded(object sender, CarEventArgs e)
    { Console.WriteLine("{0} says: {1}", sender, e.msg); }
    #endregion
  }
}
