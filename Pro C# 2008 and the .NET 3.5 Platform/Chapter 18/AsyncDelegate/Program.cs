using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AsyncDelegate
{
  public delegate int BinaryOp(int x, int y);

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Async Delegate Invocation *****");

      // Print out the ID of the executing thread.
      Console.WriteLine("Main() invoked on thread {0}.",
        Thread.CurrentThread.ManagedThreadId); 

      // Invoke Add() on a secondary thread.
      BinaryOp b = new BinaryOp(Add);
      IAsyncResult iftAR = b.BeginInvoke(10, 10, null, null);

      // This message will keep printing until 
      // the Add() method is finished.
      while (!iftAR.AsyncWaitHandle.WaitOne(1000, true))
      {
        Console.WriteLine("Doing more work in Main()!");
      }

      // Obtain the result of the Add() 
      // method when ready.
      int answer = b.EndInvoke(iftAR);
      Console.WriteLine("10 + 10 is {0}.", answer);
      Console.ReadLine();
    }

    #region Very slow addition...
    static int Add(int x, int y)
    {
      // Print out the ID of the executing thread.
      Console.WriteLine("Add() invoked on thread {0}.",
        Thread.CurrentThread.ManagedThreadId); 

      // Pause to simulate a lengthy operation.
      Thread.Sleep(5000);
      return x + y;
    }  
    #endregion
  }
}
