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
    // Custom indexer for this class.
    public Person this[int index]
    {
      get { return (Person)arPeople[index]; }
      set { arPeople.Insert(index, value); }
    }

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

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Indexers *****\n");

      PeopleCollection myPeople = new PeopleCollection();
      
      myPeople[0] = new Person("Homer", "Simpson", 40);
      myPeople[1] = new Person("Marge", "Simpson", 38);
      myPeople[2] = new Person("Lisa", "Simpson", 9);
      myPeople[3] = new Person("Bart", "Simpson", 7);
      myPeople[4] = new Person("Maggie", "Simpson", 2);

      // Now obtain and display each item using indexer.
      for (int i = 0; i < myPeople.Count; i++)
      {
        Console.WriteLine("Person number: {0}", i);
        Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
        Console.WriteLine("Age: {0}", myPeople[i].Age);
        Console.WriteLine();
      }
      UseGenericListOfPeople();
      Console.ReadLine();
    }

    #region Generic indexer
    static void UseGenericListOfPeople()
    {
      List<Person> myPeople = new List<Person>();
      myPeople.Add(new Person("Lisa", "Simpson", 9));
      myPeople.Add(new Person("Bart", "Simpson", 7));

      // Change first person.
      myPeople[0] = new Person("Maggie", "Simpson", 2);

      // Now obtain and display each item using indexer.
      for (int i = 0; i < myPeople.Count; i++)
      {
        Console.WriteLine("Person number: {0}", i);
        Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
        Console.WriteLine("Age: {0}", myPeople[i].Age);
        Console.WriteLine();
      }
    }
    #endregion
  }
}
