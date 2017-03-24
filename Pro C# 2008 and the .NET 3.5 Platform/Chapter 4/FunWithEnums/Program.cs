using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithEnums
{
  // A custom enumeration.
  enum EmpType : byte
  {
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("**** Fun with Enums *****");
      // Make a contractor type.
      // EmpType emp = EmpType.Contractor;
      // AskForBonus(emp);
      // This time use typeof to extract a Type.

      EmpType e2 = EmpType.Contractor;
      DayOfWeek day = DayOfWeek.Friday;
      ConsoleColor cc = ConsoleColor.Black;
      EvaluateEnum(e2);
      EvaluateEnum(day);
      EvaluateEnum(cc);
      Console.ReadLine();
    }

    #region Helper methods
    // Enums as parameters.
    static void AskForBonus(EmpType e)
    {
      switch (e)
      {
        case EmpType.Manager:
          Console.WriteLine("How about stock options instead?");
          break;
        case EmpType.Grunt:
          Console.WriteLine("You have got to be kidding...");
          break;
        case EmpType.Contractor:
          Console.WriteLine("You already get enough cash...");
          break;
        case EmpType.VicePresident:
          Console.WriteLine("VERY GOOD, Sir!");
          break;
      }
    }

    // This method will print out the details of any enum.
    static void EvaluateEnum(System.Enum e)
    {
      Console.WriteLine("=> Information about {0}", e.GetType().Name);

      Console.WriteLine("Underlying storage type: {0}",
        Enum.GetUnderlyingType(e.GetType()));

      // Get all name / value pairs for incoming parameter.
      Array enumData = Enum.GetValues(e.GetType());
      Console.WriteLine("This enum has {0} members.", enumData.Length);

      // Now show the string name and associated value.
      for (int i = 0; i < enumData.Length; i++)
      {
        Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
      }
      Console.WriteLine();
    }
    #endregion
  }
}
