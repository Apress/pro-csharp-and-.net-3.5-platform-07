// This program illustrates various issues
// regarding data type conversion.

// Note!  The /checked option has been enabled!
// Therefore any unchecked overflow/underflow 
// conditions will result in a runtime exception.

using System;
using System.Collections.Generic;
using System.Text;

namespace TypeConversions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with type conversions *****");

      // Declare two shorts to add.
      short numb1 = 30000, numb2 = 30000;

      // This will not throw an exception.
      unchecked
      {
        short answer = (short)Add(numb1, numb2);
        Console.WriteLine("{0} + {1} = {2}",
            numb1, numb2, answer);
      }

      NarrowingAttempt();
      ProcessBytes();
      NarrowWithConvert();
      Console.ReadLine();
    }

    #region Helper methods
    static int Add(int x, int y)
    { return x + y; }

    static void NarrowingAttempt()
    {
      byte myByte = 0;
      int myInt = 200;
      myByte = (byte)myInt;
      Console.WriteLine("Value of myByte: {0}", myByte);
    }

    static void ProcessBytes()
    {
      // Overflow the max value of a System.Byte.
      byte b1 = 100;
      byte b2 = 250;

      try
      {
        byte sum = unchecked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
      }
      catch (OverflowException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    static void NarrowWithConvert()
    {
      byte myByte = 0;
      int myInt = 200;
      myByte = Convert.ToByte(myInt);
      Console.WriteLine("Value of myByte: {0}", myByte);
    }

    #endregion
  }
}
