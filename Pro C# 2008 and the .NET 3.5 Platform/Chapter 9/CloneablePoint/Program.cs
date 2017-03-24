using System;
using System.Collections.Generic;
using System.Text;

namespace CloneablePoint
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Object Cloning *****\n");
      Console.WriteLine("Cloned p3 and stored new Point in p4");
      Point p3 = new Point(100, 100, "Jane");
      Point p4 = (Point)p3.Clone();

      Console.WriteLine("Before modification:");
      Console.WriteLine("p3: {0}", p3);
      Console.WriteLine("p4: {0}", p4);
      p4.desc.petName = "My new Point";
      p4.x = 9;

      Console.WriteLine("\nChanged p4.desc.petName and p4.x");
      Console.WriteLine("After modification:");
      Console.WriteLine("p3: {0}", p3);
      Console.WriteLine("p4: {0}", p4);
      Console.ReadLine();
    }
  }
}
