/************************************
 * You will need to build and reference
 * the provided SimpleComServer.dll COM
 * project before this project will 
 * compile and execute! ************/

using System;
using System.Collections.Generic;
using System.Text;
using SimpleComServer;

namespace CSharpComClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The .NET COM Client App *****");
      // Now manually obtain the hidden interface.
      _ComCalc itfComInterface = null;
      ComCalcClass comObj = new ComCalcClass();
      itfComInterface = (_ComCalc)comObj;

      Console.WriteLine("COM server says 10 + 832 is {0}",
        itfComInterface.Add(10, 832));
      Console.ReadLine();
    }
  }
}
