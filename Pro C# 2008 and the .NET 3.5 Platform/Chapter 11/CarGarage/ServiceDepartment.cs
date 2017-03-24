#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarGarage
{
  public class ServiceDepartment
  {
    // A target for the delegate.
    public void WashCar(Car c)
    {
      if (c.Dirty)
        Console.WriteLine("Cleaning a car");
      else
        Console.WriteLine("This car is already clean...");
    }

    // Another target for the delgate.
    public void RotateTires(Car c)
    {
      if (c.Rotate)
        Console.WriteLine("Tires have been rotated");
      else
        Console.WriteLine("Don't need to be rotated...");

    }
  }
}
