using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SimpleException
{
  class Program
  {
    // Handle the thrown exception.
    static void Main(string[] args)
    {
      Console.WriteLine("***** Simple Exception Example *****");
      Console.WriteLine("=> Creating a car and stepping on it!");
      Car myCar = new Car("Zippy", 20);
      myCar.CrankTunes(true);

      #region try / catch logic
      // Speed up past the car's max speed to
      // trigger the exception.
      try
      {
        for(int i = 0; i < 10; i++)
          myCar. Accelerate(10);
      }
      // TargetSite actually returns a MethodBase object.
      catch(Exception e)
      {
        Console.WriteLine("\n*** Error! ***");
        Console.WriteLine("Member name: {0}", e.TargetSite);
        Console.WriteLine("Class defining member: {0}",
          e.TargetSite.DeclaringType);
        Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
        Console.WriteLine("Message: {0}", e.Message);
        Console.WriteLine("Source: {0}", e.Source);
        Console.WriteLine("Stack: {0}", e.StackTrace);

        // By default, the data field is empty, so check for null.
        Console.WriteLine("\n-> Custom Data:");
        if (e.Data != null)
        {
          foreach (DictionaryEntry de in e.Data)
            Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
        }
      }
      #endregion

      // The error has been handled, processing continues with the next statement.
      Console.WriteLine("\n***** Out of exception logic *****");
      Console.ReadLine();
    }
  }
}
