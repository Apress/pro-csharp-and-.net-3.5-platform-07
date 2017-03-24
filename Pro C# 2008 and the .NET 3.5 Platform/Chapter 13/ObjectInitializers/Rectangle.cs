using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitializers
{
  public class Rectangle
  {
    private Point topLeft = new Point();
    private Point bottomRight = new Point();

    public Point TopLeft
    {
      get { return topLeft; }
      set { topLeft = value; }
    }
    public Point BottomRight
    {
      get { return bottomRight; }
      set { bottomRight = value; }
    }

    public override string ToString()
    {
      return string.Format("[TopLeft: {0}, {1}, BottomRight: {2}, {3}]", topLeft.X,
          topLeft.Y, bottomRight.X, bottomRight.Y);
    }
  }
}
