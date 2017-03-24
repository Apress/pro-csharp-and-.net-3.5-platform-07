// This example illustrates defining and calling 
// static methods.  

using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Static Methods *****\n");
      for (int i = 0; i < 5; i++)
        Console.WriteLine(Teenager.Complain());
      Console.ReadLine();
    }
  }
}
