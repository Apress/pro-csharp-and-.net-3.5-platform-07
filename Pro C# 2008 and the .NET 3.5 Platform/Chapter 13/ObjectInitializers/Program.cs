using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ObjectInitializers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Object Init Syntax *****\n");

      #region Make some Points
      // Make a Point by setting each property manually...
      Point firstPoint = new Point();
      firstPoint.X = 10;
      firstPoint.Y = 10;

      // ... or make a Point via a custom constructor...
      Point anotherPoint = new Point(20, 20);

      // ... or make some Point types using the new object init syntax.
      var yetAnotherPoint = new Point { X = 30, Y = 30 };
      Point finalPoint = new Point { X = 30, Y = 30 };

      // Calling a more interesting custom constructor with init syntax.
      Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
      Console.WriteLine("Value of Point is: {0}", goldPoint);
      #endregion

      // Create and initialize a Rectangle.
      Rectangle myRect = new Rectangle
      {
        TopLeft = new Point { X = 10, Y = 10 },
        BottomRight = new Point { X = 200, Y = 200 }
      };
      Console.WriteLine(myRect);
      CollectionInit();
      Console.ReadLine();
    }

    #region Collection init syntax
    static void CollectionInit()
    {
      // Init a standard array.
      int[] myArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      // Init a generic List<> of ints.
      List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      // Init an ArrayList with numerical data.
      ArrayList myList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      List<Point> myListOfPoints = new List<Point>
      {
        new Point { X = 2, Y = 2},
        new Point { X = 3, Y = 3},
        new Point(PointColor.BloodRed){ X = 4, Y = 4}
      };

      foreach (var pt in myListOfPoints)
      {
        Console.WriteLine(pt);
      }

      List<Rectangle> myListOfRects = new List<Rectangle>
      {
        new Rectangle {TopLeft = new Point { X = 10, Y = 10 },
                       BottomRight = new Point { X = 200, Y = 200}},
        new Rectangle {TopLeft = new Point { X = 2, Y = 2 },
                       BottomRight = new Point { X = 100, Y = 100}},
        new Rectangle {TopLeft = new Point { X = 5, Y = 5 },
                       BottomRight = new Point { X = 90, Y = 75}}
      };

      foreach (var r in myListOfRects)
      {
        Console.WriteLine(r);
      }
    }
    #endregion
  }
}
