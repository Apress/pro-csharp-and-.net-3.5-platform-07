using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace StringIndexer
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
    private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

    // This indexer returns a people based on a string index.
    public Person this[string name]
    {
      get { return listPeople[name]; }
      set { listPeople[name] = value; }
    }

    public PeopleCollection() { }

    public void ClearPeople()
    { listPeople.Clear(); }

    public int Count
    { get { return listPeople.Count; } }

    // Foreach enumeration support. 
    IEnumerator IEnumerable.GetEnumerator()
    { return listPeople.GetEnumerator(); }
  }
  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Indexers *****\n");

      PeopleCollection myPeople = new PeopleCollection();

      myPeople["Homer"] = new Person("Homer", "Simpson", 40);
      myPeople["Marge"] = new Person("Marge", "Simpson", 38);

      // Get 'Homer' and print data.
      Person p = myPeople["Homer"];
      Console.WriteLine(p);

      // Now get 'Marge'.
      p = myPeople["Marge"];
      Console.WriteLine(p);

      Console.ReadLine();
    }
  }
}
