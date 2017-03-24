using System;
using System.Collections.Generic;
using System.Text;

namespace MIInterfaceHierarchy
{
  public interface IDrawable
  {
    void Draw();
  }

  public interface IPrintable
  {
    void Print();
    void Draw(); // <-- Note possible name clash here!
  }

  // Multiple interface inheritance. OK!
  public interface IShape : IDrawable, IPrintable
  {
    int GetNumberOfSides();
  }
}
