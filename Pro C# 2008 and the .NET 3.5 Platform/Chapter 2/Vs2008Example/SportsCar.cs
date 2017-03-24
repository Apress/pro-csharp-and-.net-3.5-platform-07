using System;
using System.Collections.Generic;
using System.Text;

namespace Vs2008Example
{
  public class SportsCar : Car
  {
    public string GetPetName()
    {
      PetName = "Fred";
      return PetName;
    }
  }
}
