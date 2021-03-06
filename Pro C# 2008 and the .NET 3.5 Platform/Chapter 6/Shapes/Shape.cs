using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
  // The abstract base class of the hierarchy.
  abstract class Shape
  {
    public abstract void Draw();

    protected string shapeName;

    public Shape()
    { shapeName = "NoName"; }

    public Shape(string s)
    { shapeName = s; }

    public string PetName
    {
      get { return shapeName; }
      set { shapeName = value; }
    }
  }
}
