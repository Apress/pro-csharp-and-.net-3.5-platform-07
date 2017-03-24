using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadedOps
{
  // Just a simple everyday C# struct.
  public struct Point : IComparable
  {
    private int x, y;
    public Point(int xPos, int yPos)
    {
      x = xPos;
      y = yPos;
    }

    #region Object overrides
    public override string ToString()
    {
      return string.Format("[{0}, {1}]", this.x, this.y);
    }
    public override bool Equals(object o)
    {
      return o.ToString() == this.ToString();
    }

    public override int GetHashCode()
    { return this.ToString().GetHashCode(); }
    #endregion

    #region Binary Operators
    // overloaded operator +
    public static Point operator +(Point p1, Point p2)
    { return new Point(p1.x + p2.x, p1.y + p2.y); }

    public static Point operator +(Point p1, int change)
    {
      return new Point(p1.x + change, p1.y + change); 
    }
    public static Point operator +(int change, Point p1)
    {
      return new Point(p1.x + change, p1.y + change); 
    }

    // overloaded operator -
    public static Point operator -(Point p1, Point p2)
    { return new Point(p1.x - p2.x, p1.y - p2.y); }
    #endregion

    #region Unary Operators
    // Add 1 to the incoming Point.  
    public static Point operator ++(Point p1)
    { return new Point(p1.x + 1, p1.y + 1); }

    // Subtract 1 from the incoming Point.   
    public static Point operator --(Point p1)
    { return new Point(p1.x - 1, p1.y - 1); }
    #endregion

    #region Relational Operators
    public static bool operator <(Point p1, Point p2)
    { return (p1.CompareTo(p2) < 0); }

    public static bool operator >(Point p1, Point p2)
    { return (p1.CompareTo(p2) > 0); }

    public static bool operator <=(Point p1, Point p2)
    { return (p1.CompareTo(p2) <= 0); }

    public static bool operator >=(Point p1, Point p2)
    { return (p1.CompareTo(p2) >= 0); }
    #endregion

    #region Equality Operators
    // Now let's overload the == and != operators.
    public static bool operator ==(Point p1, Point p2)
    { return p1.Equals(p2); }

    public static bool operator !=(Point p1, Point p2)
    { return !p1.Equals(p2); }
    #endregion

    #region IComparable Members
    public int CompareTo(object obj)
    {
      if (obj is Point)
      {
        Point p = (Point)obj;
        if (this.x > p.x && this.y > p.y)
          return 1;
        if (this.x < p.x && this.y < p.y)
          return -1;
        else
          return 0;
      }
      else
        throw new ArgumentException();
    }
    #endregion
  }
}
