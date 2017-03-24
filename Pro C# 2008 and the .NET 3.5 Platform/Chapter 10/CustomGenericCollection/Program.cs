using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericCollection
{
  #region Automobile definitions
  public class Car
  {
    public string PetName;
    public int Speed;

    public Car(string name, int currentSpeed)
    {
      PetName = name;
      Speed = currentSpeed;
    }
    public Car() { }
  }

  public class SportsCar : Car
  {
    public SportsCar(string p, int s)
      : base(p, s) { }
    // Assume additional SportsCar methods.
  }

  public class MiniVan : Car
  {
    public MiniVan(string p, int s)
      : base(p, s) { }
    // Assume additional MiniVan methods.
  }
  #endregion

  #region Custom Generic Collection
  public class CarCollection<T> : IEnumerable<T> where T : Car
  {
    private List<T> arCars = new List<T>();

    public T GetCar(int pos)
    { return arCars[pos]; }

    public void AddCar(T c)
    { arCars.Add(c); }

    public void ClearCars()
    { arCars.Clear(); }

    public int Count
    { get { return arCars.Count; } }

    // IEnumerable<T> extends IEnumerable, therefore
    // we need to implement both versions of GetEnumerator().
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    { return arCars.GetEnumerator(); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    { return arCars.GetEnumerator(); }

    // This function will only work because
    // of our applied constraint. 
    public void PrintPetName(int pos)
    {
      Console.WriteLine(arCars[pos].PetName);
    }
  }
  #endregion
  
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Custom Generic Collection *****\n");

      // Make a collection of Cars.
      CarCollection<Car> myCars = new CarCollection<Car>();
      myCars.AddCar(new Car("Rusty", 20));
      myCars.AddCar(new Car("Zippy", 90));

      foreach (Car c in myCars)
      {
        Console.WriteLine("PetName: {0}, Speed: {1}",
        c.PetName, c.Speed);
      }
      Console.WriteLine();

      #region Odd ball type param for CarCollection!
      // This is syntactically correct, but confusing at best!
      //CarCollection<int> myInts = new CarCollection<int>();
      //myInts.AddCar(5);
      //myInts.AddCar(11);
      //foreach (int i in myInts)
      //{
      //  Console.WriteLine("Int value: {0}", i);
      //}
      #endregion

      // CarCollection<Car> can hold any type deriving from Car.
      CarCollection<Car> myAutos = new CarCollection<Car>();
      myAutos.AddCar(new MiniVan("Family Truckster", 55));
      myAutos.AddCar(new SportsCar("Crusher", 40));
      foreach (Car c in myAutos)
      {
        Console.WriteLine("Type: {0}, PetName: {1}, Speed: {2}",
          c.GetType().Name, c.PetName, c.Speed);
      }

      Console.ReadLine();
    }
  }
}
