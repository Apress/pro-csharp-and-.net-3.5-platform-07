using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsDataTableViewer
{
  class Car
  {
    // Use automatic props.
    public string carPetName { get; set; }
    public string carMake { get; set; }
    public string carColor { get; set; }

    public Car(string petName, string make, string color)
    {
      carPetName = petName;
      carColor = color;
      carMake = make;
    }
  }
}
