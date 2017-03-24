using System;
using System.Collections.Generic;
using System.Text;

namespace CloneablePoint
{
  #region PointDescription type
  // This class describes a point.
  public class PointDescription
  {
    // Exposed publicly for simplicity.
    public string petName;
    public Guid pointID;

    public PointDescription()
    {
      this.petName = "No-name";
      pointID = Guid.NewGuid();
    }
  }
  #endregion

  public class Point : ICloneable
  {
    public int x, y;
    public PointDescription desc = new PointDescription();

    public Point() { }
    public Point(int x, int y)
    {
      this.x = x; this.y = y;
    }
    public Point(int x, int y, string petname)
    {
      this.x = x;
      this.y = y;
      desc.petName = petname;
    }

    // Now we need to adjust for the PointDescription member.
    public object Clone()
    {
      // First get a shallow copy.
      Point newPoint = (Point)this.MemberwiseClone();

      // Then fill in the gaps.
      PointDescription currentDesc = new PointDescription();
      currentDesc.petName = this.desc.petName;
      newPoint.desc = currentDesc;
      return newPoint;
    }

    public override string ToString()
    {
      return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n",
        x, y, desc.petName, desc.pointID);
    }
  }
}
