using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CustomNonGenericCollection
{
  #region Person type
  public class Person
  {
    // Made public for simplicity.
    public int Age;
    public string FirstName, LastName;

    public Person() { }
    public Person(string firstName, string lastName, int age)
    {
      Age = age;
      FirstName = firstName;
      LastName = lastName;
    }

    public override string ToString()
    {
      return string.Format("Name: {0} {1}, Age: {2}",
        FirstName, LastName, Age);
    }
  }
  #endregion

  #region PersonCollection
  public class PeopleCollection : IEnumerable
  {
    private ArrayList arPeople = new ArrayList();
    public PeopleCollection() { }

    // Cast for caller.
    public Person GetPerson(int pos)
    { return (Person)arPeople[pos]; }

    // Only insert Person types.
    public void AddPerson(Person p)
    { arPeople.Add(p); }

    public void ClearPeople()
    { arPeople.Clear(); }

    public int Count
    { get { return arPeople.Count; } }

    // Foreach enumeration support. 
    IEnumerator IEnumerable.GetEnumerator()
    { return arPeople.GetEnumerator(); }
  }
  #endregion

  #region Car / CarCollection
  public class Car{}

  public class CarCollection : IEnumerable
  {
    private ArrayList arCars = new ArrayList();
    public CarCollection() { }

    // Cast for caller.
    public Car GetCar(int pos)
    { return (Car)arCars[pos]; }

    // Only insert Car types.
    public void AddCar(Car c)
    { arCars.Add(c); }

    public void ClearCars()
    { arCars.Clear(); }

    public int Count
    { get { return arCars.Count; } }

    // Foreach enumeration support. 
    IEnumerator IEnumerable.GetEnumerator()
    { return arCars.GetEnumerator(); }
  }

  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Custom Person Collection *****\n");
      PeopleCollection myPeople = new PeopleCollection();
      myPeople.AddPerson(new Person("Homer", "Simpson", 40));
      myPeople.AddPerson(new Person("Marge", "Simpson", 38));
      myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
      myPeople.AddPerson(new Person("Bart", "Simpson", 7));
      myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

      // This would be a compile-time error!
      // myPeople.AddPerson(new Car());

      foreach (Person p in myPeople)
        Console.WriteLine(p);
      Console.ReadLine();
    }
  }
}
