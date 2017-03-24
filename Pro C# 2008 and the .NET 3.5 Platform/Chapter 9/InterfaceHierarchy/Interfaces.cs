using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHierarchy
{
  public interface IDrawable
  {
    void Draw();
  }
  public interface IPrintable : IDrawable
  {
    void Print();
  }
  public interface IRenderToMemory : IPrintable
  {
    void Render();
  }
}
