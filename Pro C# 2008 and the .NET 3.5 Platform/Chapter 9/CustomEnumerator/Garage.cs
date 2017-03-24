using System;
using System.Collections.Generic;
using System.Text;

// Need this for IEnumerator
using System.Collections;

namespace CustomEnumerator
{
  // Garage contains a set of Car objects.
  public class Garage : IEnumerable
  {
    private Car[] carArray= new Car[4];

    // Fill with some Car objects upon startup.
    public Garage()
    {
      carArray[0] = new Car("Rusty", 30);
      carArray[1] = new Car("Clunker", 55);
      carArray[2] = new Car("Zippy", 30);
      carArray[3] = new Car("Fred", 30);
    }

    #region IEnumerable Members

    public IEnumerator GetEnumerator()
    {
      return carArray.GetEnumerator();
    }

    #endregion
  }
}
