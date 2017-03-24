using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithLinqExpressions
{
  class Car
  {
    public string PetName = string.Empty;
    public string Color = string.Empty;
    public int Speed;
    public string Make = string.Empty;

    public override string ToString()
    {
      return string.Format("Make={0}, Color={1}, Speed={2}, PetName={3}",
        Make, Color, Speed, PetName);
    }
  }
}
