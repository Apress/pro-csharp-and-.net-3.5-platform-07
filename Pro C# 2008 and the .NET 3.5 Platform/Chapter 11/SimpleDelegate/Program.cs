using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDelegate
{
  #region Our delegate and SimpleMath class
  // This delegate can point to any method,
  // taking two integers and returning an
  // integer.
  public delegate int BinaryOp(int x, int y);

  // This class contains methods BinaryOp will
  // point to.
  public class SimpleMath
  {
    public int Add(int x, int y)
    { return x + y; }
    public int Subtract(int x, int y)
    { return x - y; }
    public static int SquareNumber(int a)
    { return a * a; }
  }
  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Simple Delegate Example *****\n");

      // .NET delegates can also point to instance methods as well.
      SimpleMath m = new SimpleMath();
      BinaryOp b = new BinaryOp(m.Add);

      // Error! Method does not match delegate pattern!
      // BinaryOp b2 = new BinaryOp(SimpleMath.SquareNumber);

      // Invoke Add() method using delegate.
      Console.WriteLine("10 + 10 is {0}", b.Invoke(10, 10));
      DisplayDelegateInfo(b);
      Console.ReadLine();
    }

    #region Print out the delegate details
    static void DisplayDelegateInfo(Delegate delObj)
    {
      // Print the names of each member in the
      // delegate's invocation list.
      foreach (Delegate d in delObj.GetInvocationList())
      {
        Console.WriteLine("Method Name: {0}", d.Method);
        Console.WriteLine("Type Name: {0}", d.Target);
      }
    } 
    #endregion
  }
}

