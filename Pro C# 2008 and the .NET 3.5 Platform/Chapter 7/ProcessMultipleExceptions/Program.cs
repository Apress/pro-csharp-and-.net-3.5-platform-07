using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProcessMultipleExceptions
{
  class Program
  {
    // This code compiles just fine.
    static void Main(string[] args)
    {
      Console.WriteLine("***** Handling Multiple Exceptions *****\n");

      Car myCar = new Car("Rusty", 90);
      myCar.CrankTunes(true);

      #region Try / Catch logic.
      try
      {
        // Trip Arg out of range exception.
        myCar.Accelerate(-10);
      }
      catch (CarIsDeadException e)
      {
        try
        {
          FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
          // Assume we write stack trace to file...
        }
        catch (Exception e2)
        {
          // Throw an exception that records the new exception,
          // as well as the message of the first exception.
          throw new CarIsDeadException(e.Message, e2);
        }
      }
      catch (ArgumentOutOfRangeException e)
      {
        Console.WriteLine(e.Message);
      }
      // This will catch any other exception
      // beyond CarIsDeadException or
      // ArgumentOutOfRangeException.
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        // This will always occur. Exception or not.
        myCar.CrankTunes(false);
      }
      #endregion

      Console.ReadLine();
    }
  }
}
