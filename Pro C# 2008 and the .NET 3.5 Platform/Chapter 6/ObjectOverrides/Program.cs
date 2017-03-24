using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOverrides
{
  #region Person type
  // Remember! Person extends Object.
  class Person
  {
    // Public only for simplicity. Properties and Private data
    // would obviously be perferred.
    public string fName;
    public string lName;
    public byte personAge;

    public Person(string firstName, string lastName, byte age)
    {
      fName = firstName;
      lName = lastName;
      personAge = age;
    }
    public Person() { }

    #region System.Object overrides
    public override string ToString()
    {
      string myState;
      myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", fName, lName, personAge);
      return myState;
    }

    #region Equals(), the long way.
    //public override bool Equals(object obj)
    //{
    //    if (obj is Person && obj != null)
    //    {
    //        Person temp;
    //        temp = (Person)obj;
    //        if (temp.fName == this.fName && temp.lName == this.fName && temp.personAge == this.personAge)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    return false;
    //}
    #endregion

    public override bool Equals(object obj)
    {
      // No need to cast 'obj' to a Person anymore,
      // as everyting has a ToString() method.
      return obj.ToString() == this.ToString();
    }
    // Return a hash code based on the person's ToString() value.
    public override int GetHashCode()
    {
      return this.ToString().GetHashCode();
    }
    #endregion
  }
  #endregion

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with System.Object *****\n");

      // NOTE:  We want these to be identical to test
      // the Equals() and GetHashCode() methods.
      Person p1 = new Person("Homer", "Simpson", 50);
      Person p2 = new Person("Homer", "Simpson", 50);

      // Get stringified version of objects.
      Console.WriteLine("p1.ToString() = {0}", p1.ToString());
      Console.WriteLine("p2.ToString() = {0}", p2.ToString());

      // Test Overridden Equals()
      Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

      // Test hash codes.
      Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
      Console.WriteLine();

      // Change age of p2 and test again.
      p2.personAge = 45;
      Console.WriteLine("p1.ToString() = {0}", p1.ToString());
      Console.WriteLine("p2.ToString() = {0}", p2.ToString());
      Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
      Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

      Console.WriteLine();
      SharedMembersOfObject();
      Console.ReadLine();
    }

    #region Helper method
    static void SharedMembersOfObject()
    {
      //  Static members of System.Object.
      Person p3 = new Person("Sally", "Jones", 4);
      Person p4 = new Person("Sally", "Jones", 4);
      Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
      Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));
    }
    #endregion
  }
}
