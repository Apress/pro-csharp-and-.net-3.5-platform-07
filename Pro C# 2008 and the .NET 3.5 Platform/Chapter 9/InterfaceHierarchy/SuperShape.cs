using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHierarchy
{
  public class SuperShape : IRenderToMemory
  {
	  public void Draw()
	  {
		  Console.WriteLine("Drawing...");
	  }

	  public void Print()
	  {
		  Console.WriteLine("Printing...");
	  }

	  public void Render()
	  {
		  Console.WriteLine("Rendering...");
	  }
  }
}
