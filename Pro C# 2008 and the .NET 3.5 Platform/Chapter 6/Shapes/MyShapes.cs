using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
  #region Circle class
  // If we did not implement the MustOverride Draw() method, Circle would also be
  // considered abstract, and would have to be marked MustInherit!
  class Circle : Shape
  {
    public Circle()
    {
    }
    public Circle(string name)
      : base(name)
    {
    }
    public override void Draw()
    {
      Console.WriteLine("Drawing {0} the Circle", shapeName);
    }
  }
  #endregion

  #region Hexagon class
  // Hexagon DOES override Draw().
  class Hexagon : Shape
  {
    public Hexagon() { }
    public Hexagon(string name) : base(name) { }
    public override void Draw()
    {
      Console.WriteLine("Drawing {0} the Hexagon", shapeName);
    }
  }
  #endregion

  #region 3D-Circle class
  // This class extends Circle and hides the inherited Draw() method.
  class ThreeDCircle : Circle
  {
    // Hide the shapeName field above me.
    protected new string shapeName;

    // Hide any Draw() implementation above me.
    public new void Draw()
    {
      Console.WriteLine("Drawing a 3D Circle");
    }
  }
  #endregion
}
