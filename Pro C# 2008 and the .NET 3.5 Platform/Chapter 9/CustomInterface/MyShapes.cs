using System;
using System.Collections.Generic;
using System.Text;

namespace CustomInterface
{
  #region The Circle Type
  // If we did not implement the MustOverride Draw() method, Circle would also be
  // considered abstract, and would have to be marked MustInherit!
  public class Circle : Shape, IDraw3D
  {
      public Circle(){}
      public Circle(string name) : base(name) {}

      public override void Draw()
      {
          Console.WriteLine("Drawing {0} the Circle", shapeName);
      }
      public void Draw3D()
      {
        Console.WriteLine("Drawing circle in 3D!");
      }
    }
    #endregion

  #region The Hexagon Type
  // Hexagon now implements IPointy.
  public class Hexagon : Shape, IPointy, IDraw3D
  {
     public Hexagon(){ }
     public Hexagon(string name) : base(name){ }
     public override void Draw()
     { Console.WriteLine("Drawing {0} the Hexagon", PetName); }

     // IPointy Implementation.
     public byte Points
     {
          get { return 6; }
     }

     public void Draw3D()
     {
        Console.WriteLine("Drawing hexagon in 3D!");
     }
    }
    #endregion

  #region The ThreeDCircle Type
    // This class extends Circle and hides the inherited Draw() method.
    public class ThreeDCircle : Circle
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
