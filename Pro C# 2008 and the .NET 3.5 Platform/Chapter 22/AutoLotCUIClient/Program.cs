using System;
using System.Collections.Generic;
using System.Text;

using AutoLotConnectedLayer;
using System.Configuration;
using System.Data;

namespace AutoLotCUIClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The AutoLot Console UI *****\n");

      // Get connection string from app.config.
      string cnStr =
        ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
      bool userDone = false;
      string userCommand = "";

      // Create our InventoryDAL object.
      InventoryDAL invDAL = new InventoryDAL();
      invDAL.OpenConnection(cnStr);

      // Keep asking for input until user clicks the Q key.
      try
      {
        ShowInstructions();

        #region Get user input option
        do
        {
          Console.Write("Please enter your command: ");
          userCommand = Console.ReadLine();
          Console.WriteLine();
          switch (userCommand.ToUpper())
          {
            case "I":
              InsertNewCar(invDAL);
              break;
            case "U":
              UpdateCarPetName(invDAL);
              break;
            case "D":
              DeleteCar(invDAL);
              break;
            case "L":
              ListInventory(invDAL);
              break;
            case "S":
              ShowInstructions();
              break;
            case "C":
              ClearConsole();
              break;
            case "P":
              LookUpPetName(invDAL);
              break;
            case "Q":
              userDone = true;
              break;
            default:
              Console.WriteLine("Bad data!  Try again");
              break;
          }
        } while (!userDone);
      #endregion
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        invDAL.CloseConnection();
      }
    }

    #region Show Instructions / Clear
    private static void ShowInstructions()
    {
      Console.WriteLine("I: Inserts a new car.");
      Console.WriteLine("U: Updated an existing car.");
      Console.WriteLine("D: Deletes an existing car.");
      Console.WriteLine("L: List current inventory.");
      Console.WriteLine("S: Show these instructions.");
      Console.WriteLine("C: Clear console and show instructions.");
      Console.WriteLine("P: Look up pet name.");
      Console.WriteLine("Q: Quits program.");
    }

    private static void ClearConsole()
    {
      Console.Clear();
      ShowInstructions();
    }
    #endregion

    #region ListInventory method
    private static void ListInventory(InventoryDAL invDAL)
    {
      DataTable dt = invDAL.GetAllInventory();
      DisplayTable(dt);
    }

    private static void DisplayTable(DataTable dt)
    {
      // Print out the column names.
      for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
      {
        Console.Write(dt.Columns[curCol].ColumnName.Trim() + "\t");
      }
      Console.WriteLine("\n----------------------------------");

      // Print the DataTable.
      for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
        }
        Console.WriteLine();
      }
    }
    #endregion

    #region Delete Car
    private static void DeleteCar(InventoryDAL invDAL)
    {
      // Get ID of car to delete.
      Console.Write("Enter ID of Car to delete: ");
      int id = int.Parse(Console.ReadLine());

      // Just in case we have a primary key 
      // violation!
      try
      {
        invDAL.DeleteCar(id);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
    #endregion

    #region Update pet name / Get pet name
    private static void UpdateCarPetName(InventoryDAL invDAL)
    {
      // First get the user data.
      int carID;
      string newCarPetName;

      Console.Write("Enter Car ID: ");
      carID = int.Parse(Console.ReadLine());
      Console.Write("Enter New Pet Name: ");
      newCarPetName = Console.ReadLine();

      // Now pass to data access library.
      invDAL.UpdateCarPetName(carID, newCarPetName);
    }

    private static void LookUpPetName(InventoryDAL invDAL)
    {
      // Get ID of car to look up.
      Console.Write("Enter ID of Car to look up: ");
      int id = int.Parse(Console.ReadLine());

      Console.WriteLine("Petname of {0} is {1}.",
        id, invDAL.LookUpPetName(id));
    }
    #endregion

    #region Insert new car
    private static void InsertNewCar(InventoryDAL invDAL)
    {
      // First get the user data.
      int newCarID;
      string newCarColor, newCarMake, newCarPetName;

      Console.Write("Enter Car ID: ");
      newCarID = int.Parse(Console.ReadLine());
      Console.Write("Enter Car Color: ");
      newCarColor = Console.ReadLine();
      Console.Write("Enter Car Make: ");
      newCarMake = Console.ReadLine();
      Console.Write("Enter Pet Name: ");
      newCarPetName = Console.ReadLine();

      // Now pass to data access library.
      invDAL.InsertAuto(newCarID, newCarColor, newCarMake, newCarPetName);
    }
    #endregion 
  }
}
