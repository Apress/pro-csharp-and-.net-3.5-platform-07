using System;
using System.Collections.Generic;
using System.Text;

namespace GenericInterface
{
  #region A generic interface
  public interface IBinaryOperations<T> where T : struct
  {
    T Add(T arg1, T arg2);
    T Subtract(T arg1, T arg2);
    T Multiply(T arg1, T arg2);
    T Divide(T arg1, T arg2);
  }
  #endregion

  #region Implementation of generic interface.
  public class BasicMath : IBinaryOperations<float>
  {
    public float Add(float arg1, float arg2)
    { return arg1 + arg2; }

    public float Subtract(float arg1, float arg2)
    { return arg1 - arg2; }

    public float Multiply(float arg1, float arg2)
    { return arg1 * arg2; }

    public float Divide(float arg1, float arg2)
    { return arg1 / arg2; }
  }
  #endregion 

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Generic Interfaces *****\n");
      BasicMath m = new BasicMath();
      Console.WriteLine("1.98 + 1.3 = {0}", m.Add(1.98F, 1.3F));
      Console.ReadLine();
    }
  }
}
