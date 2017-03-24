using System;
using System.Collections.Generic;
using System.Text;
using Vb6ComCarServer;

namespace CSharpCarClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** CoCar Client App *****");

      // Create the COM class using early binding.
      CoCar myCar = new CoCar();

      // Handle the BlewUp event.
      myCar.BlewUp += new __CoCar_BlewUpEventHandler(myCar_BlewUp);

      // Call the Create() method.
      myCar.Create(50, 10, CarType.BMW);

      // Set name of driver.
      IDriverInfo itf = null;
      itf = (IDriverInfo)myCar;
      itf.DriverName = "Fred";
      Console.WriteLine("Drive is named: {0}", itf.DriverName);

      // Print type of car.
      Console.WriteLine("Your car is a {0}.", myCar.CarMake);
      Console.WriteLine();

      // Get the Engine and print name of a Cylinders.
      Engine eng = myCar.GetEngine();
      Console.WriteLine("Your Cylinders are named:");
      string[] names = (string[])eng.GetCylinders();
      foreach (string s in names)
      {
        Console.WriteLine(s);
      }
      Console.WriteLine();

      // Speed up car to trigger event.
      for (int i = 0; i < 5; i++)
      {
        myCar.SpeedUp();
      }
    }

    static void myCar_BlewUp()
    {
      Console.WriteLine("Your car is toast!");
    }

    static void UseCar()
    {
      // -Class suffix types expose all
      // members from all interfaces.
      CoCarClass c = new CoCarClass();

      // This property is a member of IDriverInfo.
      c.DriverName = "Mary";

      // This method is a member of _CoCar.
      c.SpeedUp();
    }
  }
}
