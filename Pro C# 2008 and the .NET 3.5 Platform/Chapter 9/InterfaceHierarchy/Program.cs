using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHierarchy
{
  class Program
  {
    static void Main(string[] args)
    {
		  Console.WriteLine("***** The SuperShape *****\n");
		  // Call from object level.
		  SuperShape myShape = new SuperShape();
		  myShape.Draw();

		  // Get IPrintable explicitly.
		  // (and IDrawable implicitly!)
		  IPrintable iPrint;
		  iPrint = (IPrintable)myShape;
		  iPrint.Draw();
		  iPrint.Print();
      Console.ReadLine();
    }
  }
}
