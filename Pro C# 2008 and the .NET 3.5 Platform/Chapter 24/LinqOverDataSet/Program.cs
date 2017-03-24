using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using AutoLotDisconnectedLayer;

namespace LinqOverDataSet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ over DataSet *****\n");

      // Get a DataTable containing the current Inventory
      // of the AutoLot database. 
      InventoryDALDisLayer dal = new InventoryDALDisLayer(
        @"Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;Integrated Security=True");
      DataTable data = dal.GetAllInventory();

      // Comment / uncomment to test.
      // PrintAllCarIDs(data);
      ApplyLinqQuery(data);
      Console.WriteLine();
      BuildDataTableFromQuery(data);
      Console.ReadLine();
    }

    #region Build DataTable from LINQ query
    static void BuildDataTableFromQuery(DataTable data)
    {
      Console.WriteLine("***** New DataTable from LINQ Query *****\n");
      var cars = from car in data.AsEnumerable()
                 where
                   car.Field<int>("CarID") > 5
                 select car;

      // Use this result set to build a new DataTable.
      DataTable newTable = cars.CopyToDataTable();

      // Print the DataTable.
      for (int curRow = 0; curRow < newTable.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < newTable.Columns.Count; curCol++)
        {
          Console.Write(newTable.Rows[curRow][curCol].ToString().Trim() + "\t");
        }
        Console.WriteLine();
      }
    }
    #endregion 

    #region LINQ projection using DataTable
    //private static void ApplyLinqQuery(DataTable data)
    //{
    //  // Project a new result set containing 
    //  // the ID / color for rows with a CarID > 5
    //  var cars = from car in data.AsEnumerable()
    //                where
    //                  (int)car["CarID"] > 5
    //                select new
    //                {
    //                  ID = (int)car["CarID"],
    //                  Color = (string)car["Color"]
    //                };

    //  Console.WriteLine("Cars with ID greater than 5:");
    //  foreach (var item in cars)
    //  {
    //    Console.WriteLine("-> CarID = {0} is {1}", item.ID, item.Color);
    //  }
    //}
    private static void ApplyLinqQuery(DataTable data)
    {
      // Project a new result set containing 
      // the ID / color for rows with a CarID > 5
      var cars = from car in data.AsEnumerable()
                    where
                      car.Field<int>("CarID") > 5
                    select new
                    {
                      ID = car.Field<int>("CarID"),
                      Color = car.Field<string>("Color")
                    };

      Console.WriteLine("Cars with ID greater than 5:");
      foreach (var item in cars)
      {
        Console.WriteLine("-> CarID = {0} is {1}", item.ID, item.Color);
      }
    }
    #endregion

    #region Get LINQ aware DataTable
    private static void PrintAllCarIDs(DataTable data)
    {
      // Get enumerable version of DataTable.
      var enumData = data.AsEnumerable();

      // Print the car ID values.
      foreach (DataRow r in enumData)
        Console.WriteLine("Car ID = {0}", r["CarID"]);
    }
    #endregion
  }
}
