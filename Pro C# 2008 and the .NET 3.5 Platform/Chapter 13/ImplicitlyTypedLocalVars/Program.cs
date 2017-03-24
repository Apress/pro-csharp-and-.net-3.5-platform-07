using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ImplicitlyTypedLocalVars
{
  #region Types just for testing purposes...
  class SportsCar { }
  class MiniVan { }
  #endregion

  #region Bad use of var
  class ThisWillNeverCompile
  {
    // Error! var cannot be used on field data!
    //private var myInt = 10;

    // Error!  var cannot be used as return values
    // or parameter types!
    //public var MyMethod(var x, var y) { }

    public void WontWork()
    {
      // Nope, can’t define nullable implicit variables,
      // as implicit variables can never be initially assigned 
      // null to begin with.
      //var nope = new SportsCar();
      //var stillNo = 12;
      //var noWay = null;
    }
  }

  #endregion

  class Program
  {
    static void Main()
    {
      Console.WriteLine("***** Fun with Implicit Typing *****\n");
      DeclareImplicitVars();
      DeclareImplicitArrays();
      QueryOverInts();
      Console.ReadLine();
    }

    #region Returning implicilty typed local var
    static int GetAnInt()
    {
      var retVal = 9;
      return retVal;
    }
    #endregion

    #region Implicit arrays
    static void DeclareImplicitArrays()
    {
      // a is really int[].
      var a = new[] { 1, 10, 100, 1000 };
      Console.WriteLine("a is a: {0}", a.ToString());

      // b is really double[].
      var b = new[] { 1, 1.5, 2, 2.5 };
      Console.WriteLine("b is a: {0}", b.ToString());

      // c is really string[].
      var c = new[] { "hello", null, "world" };
      Console.WriteLine("c is a: {0}", c.ToString());

      // myCars is really SportsCar[].
      var myCars = new[] { new SportsCar(), new SportsCar() };
      Console.WriteLine("myCars is a: {0}", myCars.ToString());

      // Error! Mixed types!
      // var d = new[] { 1, "one", 2, "two", false };

      Console.WriteLine();
    }
    #endregion

    #region Declaring implicit variables
    static void DeclareImplicitVars()
    {
      // Implicitly typed local variables. 
      var myInt = 0;
      var myBool = true;
      var myString = "Time, marches on…";
      var evenNumbers = new int[] { 2, 4, 6, 8 };
      var myMinivans = new List<MiniVan>();
      var myCar = new SportsCar();
       
      // Print out the underlying type. 
      Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
      Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
      Console.WriteLine("myString is a: {0}", myString.GetType().Name);
      Console.WriteLine("evenNumbers is a: {0}", evenNumbers.GetType().Name);
      Console.WriteLine("myMinivans is a: {0}", myMinivans.GetType().Name);
      Console.WriteLine("myCar is a: {0}", myCar.GetType().Name);
      Console.WriteLine();
    }
    #endregion

    #region Var in foreach loop
    static void VarInForeachLoop()
    {
      // Use 'var' in a standard for each loop.
      var evenNumbers = new int[] { 2, 4, 6, 8 };

      // Here, var is really a System.Int32.
      foreach (var item in evenNumbers)
      {
        Console.WriteLine("Item value: {0}", item);
      }
    }
    #endregion

    #region var with LINQ expression
    static void QueryOverInts()
    {
      int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
      var subset = from i in numbers where i < 10 select i;

      Console.Write("Values in subset: ");
      foreach (var i in subset)
      {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();

      // Humm...what type is subset?
      Console.WriteLine("subset is a: {0}", subset.GetType().Name);
      Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
    }
    #endregion

    #region implicit data is strongly typed
    static void ImplicitTypingIsStrongTyping()
    {
      // The compiler knows 's' is a System.String
      var s = "This variable can only hold string data!";
      s = "This is fine...";
      string upper = s.ToUpper();

      // Error! Can't assign numerical data to a a string!
      // s = 44; 
    }
    #endregion
  }
}
