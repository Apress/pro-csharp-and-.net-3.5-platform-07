using System;
using System.Collections.Generic;
using System.Text;

// Need this for IEnumerator
using System.Collections;

namespace CustomEnumeratorWithYield
{
  // Garage contains a set of Car objects.
  public class Garage
  {
    private Car[] carArray = new Car[4];

    // Fill with some Car objects upon startup.
    public Garage()
    {
      carArray[0] = new Car("Rusty", 30);
      carArray[1] = new Car("Clunker", 55);
      carArray[2] = new Car("Zippy", 30);
      carArray[3] = new Car("Fred", 30);
    }

    #region Iterator method (version 1)
    public IEnumerator GetEnumerator()
    {
      foreach (Car c in carArray)
      {
        yield return c;
      }
    }
    #endregion

    #region Iterator method (version 2)
    //public IEnumerator GetEnumerator()
    //{
    //    yield return carArray[0];
    //    yield return carArray[1];
    //    yield return carArray[2];
    //    yield return carArray[3];
    //}
    #endregion

    #region Named Iterator
    public IEnumerable GetTheCars(bool ReturnRevesed)
    {
      // Return the items in reverse.
      if (ReturnRevesed)
      {
        for (int i = carArray.Length; i != 0; i--)
        {
          yield return carArray[i-1];
        }
      }
      else
      {
        // Return the items as placed in the array.
        foreach (Car c in carArray)
        {
          yield return c;
        }
      }
    }
    #endregion
  }
}
