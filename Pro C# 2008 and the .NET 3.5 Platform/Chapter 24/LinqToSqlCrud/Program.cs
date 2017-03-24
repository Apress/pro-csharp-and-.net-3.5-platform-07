using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace LinqToSqlCrud
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** CRUD with LINQ to SQL *****\n");
      const string cnStr =
        @"Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;" +
         "Integrated Security=True";      

      AutoLotObjectsDataContext ctx = new AutoLotObjectsDataContext(cnStr);
      InsertNewCars(ctx);
      UpdateCar(ctx);
      DeleteCar(ctx);
      Console.ReadLine();
    }

    #region Insert new car
    static void InsertNewCars(AutoLotObjectsDataContext ctx)
    {
      Console.WriteLine("***** Adding 2 Cars *****");
      int newCarID = 0;
      Console.Write("Enter ID for Betty: ");
      newCarID = int.Parse(Console.ReadLine());

      // Add a new row using 'long hand' notation.
      Inventory newCar = new Inventory();
      newCar.Make = "Yugo";
      newCar.Color = "Pink";
      newCar.PetName = "Betty";
      newCar.CarID = newCarID;

      //////////////////////////////////////////////
      // Late breaking RC1 change!
      // ctx.Inventories.Add(newCar);
      ctx.Inventories.InsertOnSubmit(newCar);
      //////////////////////////////////////////////

      ctx.SubmitChanges();

      // Add another row using 'short hand' object init syntax.
      Console.Write("Enter ID for Henry: ");
      newCarID = int.Parse(Console.ReadLine());

      newCar = new Inventory
      {
        Make = "BMW",
        Color = "Silver",
        PetName = "Henry",
        CarID = newCarID
      };

      //////////////////////////////////////////////
      // Late breaking RC1 change!
      // ctx.Inventories.Add(newCar);
      ctx.Inventories.InsertOnSubmit(newCar);
      //////////////////////////////////////////////
      
      ctx.SubmitChanges();
    }
    #endregion

    #region Update car
    static void UpdateCar(AutoLotObjectsDataContext ctx)
    {
      Console.WriteLine("***** Updating color of 'Betty' *****");

      // Update betty's color to light pink.
      var betty = (from c in ctx.Inventories
                   where c.PetName == "Betty"
                   select c).First();
      betty.Color = "Green";
      ctx.SubmitChanges();
    }
    #endregion

    #region Delete a car
    static void DeleteCar(AutoLotObjectsDataContext ctx)
    {
      int carToDelete = 0;
      Console.Write("Enter ID of car to delete: ");
      carToDelete = int.Parse(Console.ReadLine());


      // Another late breaking RC1 change!!
      // Remove specified car.
      //ctx.Inventories.Remove((from c in ctx.Inventories
      //                        where c.CarID == carToDelete
      //                        select c).First());
      ctx.Inventories.DeleteOnSubmit((from c in ctx.Inventories
                              where c.CarID == carToDelete
                              select c).First());

      ctx.SubmitChanges();
    }
    #endregion
  }
}
