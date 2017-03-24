using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomaticProperties
{
  #region Car and Garage types.
  // A Car type using automatic property
  // syntax.
  class Car
  {
    // Automatic properties
    public string PetName { get; protected set; }

    public override string ToString()
    {
      return string.Format("PetName = {0}", PetName);
    }
  }

  class Garage
  {
    // The hidden backing field is set to zero!
    public int NumberOfCars { get; set; }

    // The hidden backing field is set to null!
    public Car MyAuto { get; set; }

    public Garage()
    {
      MyAuto = new Car();
      NumberOfCars = 1;
    }
    public Garage(Car car, int number)
    {
      MyAuto = car;
      NumberOfCars = number;
    }
  }
  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Automatic Properties *****");
      Car c = new Car();

      // This is an error with the current automatic
      // property definition. Remove 'protected' to set 
      // the value. 
      // c.PetName = "Frank";
      Console.WriteLine("Your car is named {0}?  That's odd...", 
        c.PetName);

      // Here, the default constructor sets the values
      // of the hidden backing fields.
      Garage g = new Garage();
      Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
      Console.WriteLine(g.MyAuto.PetName);

      Console.ReadLine();
    }
  }
}
