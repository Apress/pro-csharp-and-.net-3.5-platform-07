using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitializers
{
  public enum PointColor
  { LightBlue, BloodRed, Gold }

  public class Point
  {
    private int xPos, yPos;
    private PointColor c;

    public Point(PointColor color)
    {
      xPos = 0; yPos = 0;
      c = color;
    }
    public Point(){}

    public Point(int x, int y)
    {
      xPos = x; yPos = y;
      c = PointColor.Gold;
    }

    public int X
    {
      get { return xPos; }
      set { xPos = value; }
    }
    public int Y
    {
      get { return yPos; }
      set { yPos = value; }
    }

    public override string ToString()
    { return string.Format("[{0}, {1}, Color = {2}]", xPos, yPos, c); }
  }
}
