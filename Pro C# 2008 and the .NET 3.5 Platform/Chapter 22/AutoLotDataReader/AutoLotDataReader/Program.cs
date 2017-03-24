using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace AutoLotDataReader
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Data Readers *****\n");

      #region Connection string builder logic
      // Create a connection string via the builder object.
      SqlConnectionStringBuilder cnStrBuilder =
        new SqlConnectionStringBuilder();
      cnStrBuilder.InitialCatalog = "AutoLot";
      cnStrBuilder.DataSource = @"(local)\SQLEXPRESS";
      cnStrBuilder.ConnectTimeout = 30;
      cnStrBuilder.IntegratedSecurity = true;

      SqlConnection cn = new SqlConnection();
      cn.ConnectionString = cnStrBuilder.ConnectionString;
      cn.Open();
      ShowConnectionStatus(cn);
      #endregion

      // Create a SQL command object w/ 2 select statements.
      string strSQL = "Select * From Inventory;Select * from Customers";
      SqlCommand myCommand = new SqlCommand(strSQL, cn);

      // Obtain a data reader a la ExecuteReader().
      SqlDataReader myDataReader;
      myDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

      #region Loop over each table.
      do
      {
        while (myDataReader.Read())
        {
          Console.WriteLine("***** Record *****");
          for (int i = 0; i < myDataReader.FieldCount; i++)
          {
            Console.WriteLine("{0} = {1}",
              myDataReader.GetName(i),
              myDataReader.GetValue(i).ToString().Trim());
          }
          Console.WriteLine();
        }
        Console.WriteLine("**********************************");
      } while (myDataReader.NextResult());
      #endregion

      // Because we specified CommandBehavior.CloseConnection, we 
      // don't need to explicitly call Close() on the connection.
      myDataReader.Close();
      Console.ReadLine();
    }

    #region Helper method
    static void ShowConnectionStatus(DbConnection cn)
    {
      // Show various stats about current connection object.
      Console.WriteLine("***** Info about your connection *****");
      Console.WriteLine("Database location: {0}", cn.DataSource);
      Console.WriteLine("Database name: {0}", cn.Database);
      Console.WriteLine("Timeout: {0}", cn.ConnectionTimeout);
      Console.WriteLine("Connection state: {0}\n", cn.State.ToString());
    }
    #endregion
  }
}
