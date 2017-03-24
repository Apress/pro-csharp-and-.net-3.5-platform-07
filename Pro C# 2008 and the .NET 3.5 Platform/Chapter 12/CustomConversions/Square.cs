using System;
using System.Collections.Generic;
using System.Text;

namespace CustomConversions
{
  public struct Square
  {
    public int Length;
    public Square(int l)
    {
      Length = l;
    }

    public void Draw()
    {
      for (int i = 0; i < Length; i++)
      {
        for (int j = 0; j < Length; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    public override string ToString()
    { return string.Format("[Length = {0}]", Length); }

    #region Conversion routiens
    // Rectangles can be explicitly converted
    // into Squares.
    public static explicit operator Square(Rectangle r)
    {
      Square s;
      s.Length = r.Height;
      return s;
    }
    // Can call as:
    // Square sq2 = (Square)90;
    // or as:
    // Square sq2 = 90;
    public static implicit operator Square(int sideLength)
    {
      Square newSq;
      newSq.Length = sideLength;
      return newSq;
    }

    // Must call as:
    // int side = (int)mySquare;
    public static explicit operator int(Square s)
    { return s.Length; }
    #endregion
  }
}
