using System;
using System.Collections.Generic;
using System.Text;

namespace CustomInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Interfaces *****\n");

      // Make an array of Shapes.
      Shape[] s = { new Hexagon(), new Circle(), new Triangle("Joe"),
        new Circle("JoJo")};

      #region Process the array
      for (int i = 0; i < s.Length; i++)
      {
        // Recall the Shape base class defines an abstract Draw()
        // member, so all shapes know how to draw themselves.
        s[i].Draw();

        // Who's pointy?
        if (s[i] is IPointy)
          Console.WriteLine("-> Points: {0}", ((IPointy)s[i]).Points);
        else
          Console.WriteLine("-> {0}\'s not pointy!", s[i].PetName);

        // Can I draw you in 3D?
        if (s[i] is IDraw3D)
          DrawIn3D((IDraw3D)s[i]);

        //// Attempt to get IPointy from array of ints.
        //int[] myInts = {10, 20, 30};
        //IPointy itfPt = ExtractPointyness(myInts);

        //if(itfPt != null)
        //  Console.WriteLine("Object has {0} points.", itfPt.Points);
        //else
        //  Console.WriteLine("This object does not implement IPointy");
        Console.WriteLine();
      }
      #endregion

      // This array can only contain types that
      // implement the IPointy interface.
      IPointy[] myPointyObjects = {new Hexagon(), new Knife(),
          new Triangle(), new Fork(), new PitchFork()};

      foreach (IPointy i in myPointyObjects)
        Console.WriteLine("Object has {0} points.", i.Points);
      Console.ReadLine();

    }

    #region Helper methods
    // I'll draw anyone supporting IDraw3D.
    static void DrawIn3D(IDraw3D itf3d)
    {
      Console.WriteLine("-> Drawing IDraw3D compatible type");
      itf3d.Draw3D();
    }

    // This method tests for IPointy-compatibility and,
    // if able, returns an interface reference.
    static IPointy ExtractPointyness(object o)
    {
      if (o is IPointy)
        return (IPointy)o;
      else
        return null;
    }
    #endregion 
  }
}
