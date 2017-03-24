#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarGarage
{
  public class Garage
  {
    // We have some cars.
    private List<Car> theCars = new List<Car>();

    public Garage()
    {
      theCars.Add(new Car("Viper", 100, 0, true, false));
      theCars.Add(new Car("Fred", 100, 0, false, false));
      theCars.Add(new Car("BillyBob", 100, 0, false, true));
    }

    // This method takes a CarDelegate as a parameter.
    // Therefore!  'proc' is nothing more than a function pointer...
    public void ProcessCars(Car.CarMaintenanceDelegate proc)
    {
      // Where are we passing the call?
      foreach (Delegate d in proc.GetInvocationList())
      {
        Console.WriteLine("***** Calling: {0} *****",
          d.Method);
      }

      // Am I calling an object's method or a static method?
      if (proc.Target != null)
        Console.WriteLine("\n-->Target: {0}", proc.Target);
      else
        Console.WriteLine("\n-->Target is a static method");

      // Now call method for each car.
      foreach (Car c in theCars)
      {
        Console.WriteLine("\n-> Processing a Car");
        proc(c);
      }
      Console.WriteLine();
    }
  }
}
