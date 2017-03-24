// This program illustrates some of the 
// more interesting details of working
// with basic data types.
//
// Comment or uncomment the f(x) calls in 
// Main() to test. 

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDataTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with basic data types *****\n");
      LocalVarDeclarations();
      NewingDataTypes();
      ObjectFunctionality();
      DataTypeFunctionality();
      CharFunctionality();
      ParseFromStrings();
    }

    #region Helper functions
    static void LocalVarDeclarations()
    {
      Console.WriteLine("=> Data Declarations:");
      // Local variables are declared and initialized as so:
      // dataType varName = initialValue;
      int myInt = 0;

      string myString;
      myString = "This is my character data";

      // Declare 3 bools on a single line.
      bool b1 = true, b2 = false, b3 = b1;

      // Very verbose manner in which to declare a bool.
      System.Boolean b4 = false;

      Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
          myInt, myString, b1, b2, b3, b4);
      Console.WriteLine();
    }

    static void NewingDataTypes()
    {
      Console.WriteLine("=> Using new to create intrinsic data types:");
      bool b = new bool();            // set to false.
      int i = new int();              // set to 0.
      double d = new double();        // set to 0.0.
      DateTime dt = new DateTime();   // set to 1/1/0001 12:00:00 AM
      Console.WriteLine("{0}, {1}, {2}, {3}",
          b, i, d, dt);
      Console.WriteLine();
    }

    static void ObjectFunctionality()
    {
      Console.WriteLine("=> System.Object Functionality:");
      // A C# int is really a shorthand for System.Int32.
      // which inherits the following members from System.Object.
      Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
      Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
      Console.WriteLine("12.ToString() = {0}", 12.ToString());
      Console.WriteLine("12.GetType() = {0}", 12.GetType());
      Console.WriteLine();
    }

    static void DataTypeFunctionality()
    {
      Console.WriteLine("=> Data type Functionality:");
      Console.WriteLine("Max of int: {0}", int.MaxValue);
      Console.WriteLine("Min of int: {0}", int.MinValue);
      Console.WriteLine("Max of double: {0}", double.MaxValue);
      Console.WriteLine("Min of double: {0}", double.MinValue);
      Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
      Console.WriteLine("double.PositiveInfinity: {0}",
        double.PositiveInfinity);
      Console.WriteLine("double.NegativeInfinity: {0}",
       double.NegativeInfinity);
      Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
      Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
      Console.WriteLine();
    }

    static void CharFunctionality()
    {
      Console.WriteLine("=> char type Functionality:");
      char myChar = 'a';
      Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
      Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
      Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
          char.IsWhiteSpace("Hello There", 5));
      Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
          char.IsWhiteSpace("Hello There", 6));
      Console.WriteLine("char.IsPunctuation('?'): {0}",
          char.IsPunctuation('?'));
      Console.WriteLine();
    }

    static void ParseFromStrings()
    {
      Console.WriteLine("=> Data type parsing:");
      bool b = bool.Parse("True");
      Console.WriteLine("Value of b: {0}", b);
      double d = double.Parse("99.884");
      Console.WriteLine("Value of d: {0}", d);
      int i = int.Parse("8");
      Console.WriteLine("Value of i: {0}", i);
      char c = Char.Parse("w");
      Console.WriteLine("Value of c: {0}", c);
      Console.WriteLine();
    }
    #endregion
  }
}
