using System;
using System.Collections.Generic;
using System.Text;

namespace BasicInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Basic Inheritance *****\n");
      // Make a Car type.
      Car myCar = new Car(80);
      myCar.Speed = 50;
      Console.WriteLine("My car is going {0} MPH", myCar.Speed);

      // Make a MiniVan type.
      MiniVan myVan = new MiniVan();
      myVan.Speed = 10;
      Console.WriteLine("My van is going {0} MPH",
        myVan.Speed);

      // Error!  Can’t access private members of an object!
      // myVan.currSpeed = 55;

      Console.ReadLine();
    }
  }
}
