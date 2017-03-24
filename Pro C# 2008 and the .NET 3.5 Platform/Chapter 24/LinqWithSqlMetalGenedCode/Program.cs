using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoLotDatabase;

namespace LinqWithSqlMetalGenedCode
{
  class Program
  {
    const string cnStr =
      @"Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;" +
       "Integrated Security=True";

    static void Main(string[] args)
    {
      Console.WriteLine("***** More Fun with LINQ to SQL *****\n");
      AutoLot carsDB = new AutoLot(cnStr);
      InvokeStoredProc(carsDB);
      Console.WriteLine();
      PrintOrderForCustomer(carsDB);
      Console.ReadLine();
    }

    #region Call stored proc
    private static void InvokeStoredProc(AutoLot carsDB)
    {
      int carID = 0;
      string petName = "";
      Console.Write("Enter ID: ");
      carID = int.Parse(Console.ReadLine());

      // Invoke stored proc and print out the petname.
      carsDB.GetPetName(carID, ref petName);
      Console.WriteLine("Car ID {0} has the petname: {1}",
        carID, petName);
    }
    #endregion

    #region Print customer order
    static void PrintOrderForCustomer(AutoLot carsDB)
    {
      int custID = 0;
      Console.Write("Enter customer ID: ");
      custID = int.Parse(Console.ReadLine());

      var customerOrders =
        from cust in carsDB.Customers
        from o in cust.Orders
        where cust.CustID == custID
        select new { cust, o };

      Console.WriteLine("***** Order Info for Customer ID: {0}. *****", custID);
      foreach (var q in customerOrders)
      {
        Console.WriteLine("{0} {1} is order ID # {2}.",
          q.cust.FirstName.Trim(),
          q.cust.LastName.Trim(),
          q.o.OrderID);
        Console.WriteLine("{0} bought Car ID # {1}.",
        q.cust.FirstName.Trim(), q.o.CarID);
      }
      Console.WriteLine("\ncustomerOrders as a string: {0}", customerOrders);
    }
    #endregion
  }
}
