using System;
using System.Collections.Generic;
using System.Text;

namespace MethodGroupConversion
{
  #region SimpleMath type
  public class SimpleMath
  {
    public delegate void MathMessage(string msg);
    public event MathMessage ComputationFinished;

    public int Add(int x, int y)
    {
      ComputationFinished("Adding complete.");
      return x + y;
    }

    public int Subtract(int x, int y)
    {
      ComputationFinished("Subtracting complete.");
      return x - y;
    }
  }
  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Method Conversion *****");

      SimpleMath m = new SimpleMath();
      m.ComputationFinished += ComputationFinishedHandler;
      Console.WriteLine("10 + 10 is {0}", m.Add(10, 10));

      // Event handlers to be cast into
      // their underlying delegate.
      SimpleMath.MathMessage mmDelegate =
        (SimpleMath.MathMessage)ComputationFinishedHandler;
      Console.WriteLine(mmDelegate.Method);
      Console.ReadLine();
    }

    static void ComputationFinishedHandler(string msg)
    {
      Console.WriteLine(msg);
    }
  }
}
