using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Methods *****");

      #region Pass by value
      // Pass two variables in by value.
      int x = 9, y = 10;
      Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
      Console.WriteLine("Answer is: {0}", Add(x, y));
      Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
      #endregion
      
      Console.WriteLine();

      #region Use output params
      // No need to assign initial value to local variables
      // used as output parameters.
      int ans;
      Add(90, 90, out ans);
      Console.WriteLine("90 + 90 = {0} ", ans);

      // Grab multiple values from a method using
      // output parameters.
      int i; string str; bool b;
      FillTheseValues(out i, out str, out b);
      Console.WriteLine("Int is: {0}", i);
      Console.WriteLine("String is: {0}", str);
      Console.WriteLine("Boolean is: {0}", b);
      #endregion

      Console.WriteLine();

      #region Pass by reference
      string s1 = "Flip";
      string s2 = "Flop";
      Console.WriteLine("Before: {0}, {1} ", s1, s2);
      SwapStrings(ref s1, ref s2);
      Console.WriteLine("After: {0}, {1} ", s1, s2);
      #endregion

      Console.WriteLine();

      #region Use parameter array
      // Pass in a comma-delimited list of doubles...
      double average;
      average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
      Console.WriteLine("Average of data is: {0}", average);

      // ...or pass an array of doubles.
      double[] data = { 4.0, 3.2, 5.7 };
      average = CalculateAverage(data);
      Console.WriteLine("Average of data is: {0}", average);

      // Average of 0 is 0!
      Console.WriteLine("Average of data is: {0}", CalculateAverage());

      #endregion

      Console.ReadLine();
    }

    #region Helper methods
    // Arguments are passed by value by default.
    static int Add(int x, int y)
    {
      int ans = x + y;

      // Caller will not see these changes
      // as you are modifying a copy of the 
      // original data.
      x = 10000; y = 88888;
      return ans;
    }

    // Output parameters must be assigned by the called method.
    static void Add(int x, int y, out int ans)
    {
      ans = x + y;
    }

    // Returning multiple output parameters.
    static void FillTheseValues(out int a, out string b, out bool c)
    {
      a = 9;
      b = "Enjoy your string.";
      c = true;
    }

    // Uncomment this method to generate compiler
    // errors.
    //static void ThisWontCompile(out int a)
    //{ Console.WriteLine("This is an error..."); }

    // Reference parameters.
    static void SwapStrings(ref string s1, ref string s2)
    {
      string tempStr = s1;
      s1 = s2;
      s2 = tempStr;
    }

    // Return average of 'some number' of doubles.
    static double CalculateAverage(params double[] values)
    {
      Console.WriteLine("You sent me {0} doubles.", values.Length);

      double sum = 0;
      if (values.Length == 0)
        return sum;

      for (int i = 0; i < values.Length; i++)
        sum += values[i];
      return (sum / values.Length);
    }

    #endregion
  }
}
