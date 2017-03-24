using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDispose
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Dispose *****\n");
      // Dispose() is called automatically when the
      // using scope exits.
      using(MyResourceWrapper rw = new MyResourceWrapper(),
            rw2 = new MyResourceWrapper())
      {
        // Use rw and rw2 objects.
      }
    }
  }
}
