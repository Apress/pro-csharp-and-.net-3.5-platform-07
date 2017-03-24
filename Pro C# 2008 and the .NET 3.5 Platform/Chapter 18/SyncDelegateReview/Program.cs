// Need this for the Thread.Sleep() call.
using System.Threading;
using System;

namespace SyncDelegate
{
  public delegate int BinaryOp(int x, int y);

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Synch Delegate Review *****");

      // Print out the ID of the executing thread.
      Console.WriteLine("Main() invoked on thread {0}.",
        Thread.CurrentThread.ManagedThreadId);

      // Invoke Add() in a synchronous manner.
      BinaryOp b = new BinaryOp(Add);

      // Could also write b.Invoke(10, 10);
      int answer = b(10, 10);

      // These lines will not execute until 
      // the Add() method has completed.
      Console.WriteLine("Doing more work in Main()!");
      Console.WriteLine("10 + 10 is {0}.", answer);
      Console.ReadLine();
    }

    #region Very time consuming addition!
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
