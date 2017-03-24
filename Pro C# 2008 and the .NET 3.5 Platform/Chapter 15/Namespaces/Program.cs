#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using MyShapes;
using Chapter3.My3DShapes;

// Resolve the ambiguity using a custom alias.
using The3DHexagon = Chapter3.My3DShapes.Hexagon;

using MyAlias = System.Runtime.Serialization.Formatters.Binary;

namespace MyApp
{
  class ShapeTester
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Namespaces *****\n");
      Console.WriteLine("See source code for details...");

      The3DHexagon h = new The3DHexagon();
      Chapter3.My3DShapes.Circle c = new Chapter3.My3DShapes.Circle();
      MyShapes.Square s = new MyShapes.Square();

      MyAlias.BinaryFormatter b = new MyAlias.BinaryFormatter();
      Console.ReadLine();
    }
  }
}

