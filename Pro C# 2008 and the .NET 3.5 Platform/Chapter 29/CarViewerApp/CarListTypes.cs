using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace CarViewerApp
{

  public class CarList : ObservableCollection<Car>
  {
    public CarList()
    {
      // Add a few entries to the CarList object.
      Add(new Car(40, "BMW", "Black", "Sidd"));
      Add(new Car(55, "VW", "Black", "Mary"));
      Add(new Car(100, "Ford", "Tan", "Mel"));
      Add(new Car(0, "Yugo", "Green", "Clunker"));
    }
  }

  public class Car
  {
    public int Speed { get; set; }
    public string Make { get; set; }
    public string Color { get; set; }
    public string PetName { get; set; }

    #region ctors
    public Car(int speed, string make, string color, string name)
    {
      Speed = speed; Make = make; Color = color; PetName = name;
    }
    public Car()
    {
    }
    #endregion

    public override string ToString()
    {
      return string.Format("{0} the {1} {2} is going {3} MPH", 
        PetName, Color, Make, Speed);
    }
  }
}