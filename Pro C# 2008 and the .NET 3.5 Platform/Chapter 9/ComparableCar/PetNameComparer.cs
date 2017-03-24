using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ComparableCar
{
  // This helper class is used to sort an array of Cars by pet name.
  public class PetNameComparer : IComparer
  {
    // Test the pet name of each object.
    int IComparer.Compare(object o1, object o2)
    {
      Car t1 = (Car)o1;
      Car t2 = (Car)o2;
      return String.Compare(t1.PetName, t2.PetName);
    }
  }
}
