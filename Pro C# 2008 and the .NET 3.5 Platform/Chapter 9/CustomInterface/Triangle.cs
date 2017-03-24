using System;
using System.Collections.Generic;
using System.Text;

namespace CustomInterface
{
  // New Shape derived class named Triangle.
  public class Triangle : Shape, IPointy
  {
       public Triangle() { }
       public Triangle(string name) : base(name) { }
       public override void Draw()
       { Console.WriteLine("Drawing {0} the Triangle", PetName); }

       // IPointy Implementation.
       public byte Points
       {
            get { return 3; }
       }
  }
}
