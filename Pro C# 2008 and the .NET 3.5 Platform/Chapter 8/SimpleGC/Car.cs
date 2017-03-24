using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGC
{
  public class Car
  {
    private int currSp;
    private string petName;

    public Car(){}
    public Car(string name, int speed)
    {
      petName = name;
      currSp = speed;
    }
    public override string ToString()
    {
      return string.Format("{0} is going {1} MPH",
        petName, currSp);
    }
  }
}
