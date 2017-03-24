using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Custom Exceptions *****\n");
      Car myCar = new Car("Rusty", 90);
      try
      {
        // Trip exception.
        myCar.Accelerate(50);
      }
      catch (CarIsDeadException e)
      {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.TimeStamp);
        Console.WriteLine(e.Cause);
      }
      Console.ReadLine();
    }
  }
}