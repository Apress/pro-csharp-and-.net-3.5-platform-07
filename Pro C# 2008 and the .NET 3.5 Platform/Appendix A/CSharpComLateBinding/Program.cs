/************************************
 * You will need to build 
 * the provided SimpleComServer.dll COM
 * project or you will get a runtime
 * exception! **********************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace CSharpComLateBinding
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The Late Bound .NET Client *****");

      // First get IDispatch reference from coclass.
      Type calcObj =
        Type.GetTypeFromProgID("SimpleCOMServer.ComCalc");
      object calcDisp = Activator.CreateInstance(calcObj);

      // Make the array of args.
      object[] addArgs = { 100, 24 };

      // Invoke the Add() method and obtain summation.
      object sum = null;
      sum = calcObj.InvokeMember("Add", BindingFlags.InvokeMethod,
        null, calcDisp, addArgs);

      // Display result.
      Console.WriteLine("Late bound adding: 100 + 24 is: {0}", sum);
      Console.ReadLine();
    }
  }
}
