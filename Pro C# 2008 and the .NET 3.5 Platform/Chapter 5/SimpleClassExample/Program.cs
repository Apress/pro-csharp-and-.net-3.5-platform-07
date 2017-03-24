using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Class Types *****\n");

      #region Using the Car type
      // Allocate and configure a Car object.
      Car myCar = new Car();
      myCar.petName = "Henry";
      myCar.currSpeed = 10;

      // Speed up the car a few times and print out the
      // new state.
      for (int i = 0; i <= 5; i++)
      {
        myCar.SpeedUp(5);
        myCar.PrintState();
      }
      Console.WriteLine();
      #endregion

      #region Using the Motorcycle type
      // Make a Motorcycle with a rider named Tiny?
      Motorcycle c = new Motorcycle(5);
      c.SetDriverName("Tiny");
      c.PopAWheely();
      Console.WriteLine("Rider name is {0}", c.driverName); // Prints an empty name value!
      #endregion

      Console.ReadLine();
    }
  }
}
