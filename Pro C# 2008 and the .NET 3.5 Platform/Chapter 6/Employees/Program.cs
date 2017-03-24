using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The Employee Class Hierarchy *****\n");

      // A better bonus system!
      Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
      chucky.GiveBonus(300);
      chucky.DisplayStats();
      Console.WriteLine();

      SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
      fran.GiveBonus(200);
      fran.DisplayStats();
      Console.WriteLine();

      // Error!  Cannot create an abstract class!
      // Employee X = new Employee();
      FunWithCasting();
      Console.ReadLine();
    }

    #region Helper methods
    static void FunWithCasting()
    {
      // A Manager "is-a" System.Object.
      object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

      // A Manager "is-a" Employee too.
      Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

      // A PTSalesPerson "is-a" SalesPerson.
      SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);

      // Streamline the staff.
      FireThisPerson(moonUnit);
      FireThisPerson(jill);
      FireThisPerson((Manager)frank);
    }

    static void FireThisPerson(Employee emp)
    {
      if (emp is SalesPerson)
      {
        Console.WriteLine("Lost a sales person named {0}", emp.Name);
        Console.WriteLine("{0} made {1} sale(s)...", emp.Name, ((SalesPerson)emp).SalesNumber);
        Console.WriteLine();
      }
      if (emp is Manager)
      {
        Console.WriteLine("Lost a suit named {0}", emp.Name);
        Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
        Console.WriteLine();
      }
    }
    #endregion
  }
}
