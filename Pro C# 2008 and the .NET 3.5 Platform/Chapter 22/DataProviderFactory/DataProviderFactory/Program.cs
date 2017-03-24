using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Configuration;
using System.Data;

namespace DataProviderFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Data Provider Factories *****\n");

      #region Read data from config file & get factory
      string dp =
        ConfigurationManager.AppSettings["provider"];
      string cnStr =
        ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

      // Get the factory provider.
      DbProviderFactory df = DbProviderFactories.GetFactory(dp);
      #endregion

      #region Get connection / command objects
      // Now make connection object.
      DbConnection cn = df.CreateConnection();
      Console.WriteLine("Your connection object is a: {0}", cn.GetType().FullName);
      cn.ConnectionString = cnStr;
      cn.Open();

      // Make command object.
      DbCommand cmd = df.CreateCommand();
      Console.WriteLine("Your command object is a: {0}", cmd.GetType().FullName);
      cmd.Connection = cn;
      cmd.CommandText = "Select * From Inventory";
      #endregion

      // Print out data with data reader.
      // Because we specified CommandBehavior.CloseConnection, we 
      // don't need to explicitly call Close() on the connection.
      DbDataReader dr =
        cmd.ExecuteReader(CommandBehavior.CloseConnection);
      Console.WriteLine("Your data reader object is a: {0}", dr.GetType().FullName);

      Console.WriteLine("\n***** Current Inventory *****");
      while (dr.Read())
        Console.WriteLine("-> Car #{0} is a {1}.",
          dr["CarID"], dr["Make"].ToString().Trim());
      dr.Close();
      Console.ReadLine();
    }
  }
}
