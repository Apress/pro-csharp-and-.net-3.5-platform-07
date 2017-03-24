#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AnonymousMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Anonymous Methods *****");

      int aboutToBlowCounter = 0;

      // Make a car as usual. 
      Car c1 = new Car("SlugBug", 100, 10);

      // Register event handlers as anonymous methods.          
      c1.AboutToBlow += delegate
      {
        aboutToBlowCounter++;
        Console.WriteLine("Eek!  Going too fast!");
      };

      c1.AboutToBlow += delegate(object sender, CarEventArgs e)
      {
        aboutToBlowCounter++;
        Console.WriteLine("Message from Car: {0}", e.msg);
      };

      c1.Exploded += delegate(object sender, CarEventArgs e)
      { Console.WriteLine("Message from Car: {0}", e.msg); };

      // Speed up (this will generate the events.)
      Console.WriteLine("\n***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.SpeedUp(20);

      Console.WriteLine("AboutToBlow event was fired {0} times",
        aboutToBlowCounter);

      Console.ReadLine();
    }
  }
}
