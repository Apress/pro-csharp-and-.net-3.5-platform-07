#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace PublicDelegateProblem
{
  public class Car
  {
    // A single delegate.
    public delegate void Exploded(string msg);

    // Now public!  No more helper functions!
    public Exploded explodedList;

    // Just fire out the Exploded notification.
    public void Accelerate(int delta)
    {
      if (explodedList != null)
        explodedList("Sorry, this car is dead...");
    }
  }
}
