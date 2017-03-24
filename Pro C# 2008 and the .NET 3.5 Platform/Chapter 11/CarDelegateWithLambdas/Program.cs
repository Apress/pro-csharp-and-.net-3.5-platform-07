using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarDelegateWithLambdas
{
  // Comment or uncomment the following code to see the
  // connection between delegates, anonymous methods 
  // and lambdas.

  #region Program using traditional delegate syntax.
  //class Program
  //{
  //    static void Main(string[] args)
  //    {
  //        Console.WriteLine("***** More Fun with Lambdas *****\n");

  //        // Make a car as usual.
  //        Car c1 = new Car("SlugBug", 100, 10);

  //        // Traditional delegate syntax.
  //        c1.OnAboutToBlow(new Car.AboutToBlow(CarAboutToBlow));
  //        c1.OnExploded(new Car.Exploded(CarExploded));

  //        // Speed up (this will generate the events.)
  //        Console.WriteLine("\n***** Speeding up *****");
  //        for (int i = 0; i < 6; i++)
  //            c1.SpeedUp(20);

  //        Console.ReadLine();
  //    }

  //    // Delegate targets.
  //    public static void CarAboutToBlow(string msg)
  //    { Console.WriteLine(msg); }

  //    public static void CarExploded(string msg)
  //    { Console.WriteLine(msg); }
  //}
  #endregion

  #region Program using anonymous method syntax.
  //class Program
  //{
  //    static void Main(string[] args)
  //    {
  //        Console.WriteLine("***** More Fun with Lambdas *****\n");

  //        // Make a car as usual.
  //        Car c1 = new Car("SlugBug", 100, 10);

  //        // Now use anonymous methods.
  //        c1.OnAboutToBlow(delegate(string msg) { Console.WriteLine(msg); });
  //        c1.OnExploded(delegate(string msg) { Console.WriteLine(msg); });

  //        // Speed up (this will generate the events).
  //        Console.WriteLine("\n***** Speeding up *****");
  //        for (int i = 0; i < 6; i++)
  //            c1.SpeedUp(20);

  //        Console.ReadLine();
  //    }
  //}
  #endregion

  #region Program using lambda expression syntax.
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** More Fun with Lambdas *****");

      // Make a car as usual. 
      Car c1 = new Car("SlugBug", 100, 10);

      // Tell the car what to invoke under the correct 
      // circumstances.
      c1.OnAboutToBlow(msg => { Console.WriteLine(msg); });
      c1.OnExploded(msg => { Console.WriteLine(msg); });

      // Speed up (this will generate the events.)
      Console.WriteLine("\n***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.SpeedUp(20);

      Console.ReadLine();
    }
  }
  #endregion
}
