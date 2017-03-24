using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Polymorphism *****\n");

      // Make an array of Shape compatible objects.
      Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), 
                new Circle("Beth"), new Hexagon("Linda")};

      // Loop over each items and interact with the
      // polymorphic interface.
      foreach (Shape s in myShapes)
      {
        s.Draw();
      }

      // Fun with shadowing.
      ThreeDCircle o = new ThreeDCircle();
      o.Draw();
      ((Circle)o).Draw();
      Console.ReadLine();
    }
  }
}
