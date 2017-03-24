using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace SimpleLinqToSqlApp
{
  class Program
  {
    const string cnStr =
      @"Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;" +
       "Integrated Security=True";

    static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ to SQL Sample App *****\n");

      // Create a AutoLotDatabase object.
      AutoLotDatabase db = new AutoLotDatabase(cnStr);

      // Show all data using a LINQ query.
      Console.WriteLine("-> Contents of Inventory Table from AutoLot database:\n");
      foreach (var car in from c in db.Inventory select c)
        Console.WriteLine(car.ToString());
      Console.WriteLine();
      ShowOnlyBimmers(db);
      Console.ReadLine();
    }

    #region Helper method
    static void ShowOnlyBimmers(AutoLotDatabase db)
    {
      Console.WriteLine("***** Only BMWs *****\n");

      // Get the BMWs.
      var bimmers = from s in db.Inventory
                    where s.Make == "BMW"
                    orderby s.CarID
                    select s;

      foreach (var c in bimmers)
        Console.WriteLine(c.ToString());
    }
    #endregion
  }
}
