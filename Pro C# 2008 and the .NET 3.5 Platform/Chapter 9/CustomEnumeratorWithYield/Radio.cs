using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEnumeratorWithYield
{
  public class Radio
  {
    public void TurnOn(bool on)
    {
      if(on)
        Console.WriteLine("Jamming...");
      else
        Console.WriteLine("Quiet time...");
    }
  }
}
