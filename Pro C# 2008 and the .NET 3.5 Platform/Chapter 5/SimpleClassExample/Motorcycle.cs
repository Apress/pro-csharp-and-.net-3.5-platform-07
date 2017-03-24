using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
  class Motorcycle
  {
    public int driverIntensity;
    public string driverName;

    #region Constructors
    // Constructors.
    public Motorcycle()
    {
      Console.WriteLine("In default ctor");
    }
    public Motorcycle(int intensity)
      : this(intensity, "")
    {
      Console.WriteLine("In ctor taking an int");
    }
    public Motorcycle(string name)
      : this(5, name)
    {
      Console.WriteLine("In ctor taking a string");
    }

    // This is the 'master' constructor that does all the real work.
    public Motorcycle(int intensity, string name)
    {
      Console.WriteLine("In master ctor ");
      if (intensity > 10)
      {
        intensity = 10;
      }
      driverIntensity = intensity;
      driverName = name;
    }
    #endregion

    #region Methods
    public void PopAWheely()
    {
      for (int i = 0; i <= driverIntensity; i++)
      {
        Console.WriteLine("Yeeeeeee Haaaaaeewww!");
      }
    }

    public void SetDriverName(string name)
    {
      driverName = name;
    }
    #endregion
  }
}
