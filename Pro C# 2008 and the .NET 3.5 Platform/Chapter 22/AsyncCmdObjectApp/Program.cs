using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace AsyncCmdObjectApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with ASNYC Data Readers *****\n");

      // Create an open a connection that is async-aware.
      // Create and open a connection that is async-aware.
      SqlConnection cn = new SqlConnection();
      cn.ConnectionString = @"Data Source=(local)\SQLEXPRESS" +
        ";Integrated Security=SSPI;" +
        "Initial Catalog=AutoLot;Asynchronous Processing=true";
      cn.Open();


      // Create a SQL command object that waits for approx 2 seconds.
      string strSQL = "WaitFor Delay '00:00:02';Select * From Inventory";
      SqlCommand myCommand = new SqlCommand(strSQL, cn);

      // Execute the reader on a second thread. 
      IAsyncResult itfAsynch;
      itfAsynch = myCommand.BeginExecuteReader(CommandBehavior.CloseConnection);

      #region Simulate work on primary thread
      // Do something while other thread works. 
      while (!itfAsynch.IsCompleted)
      {
        Console.WriteLine("Working on main thread...");
        Thread.Sleep(1000);
      }
      #endregion

      Console.WriteLine();

      // All done!  Get reader and loop over results. 
      SqlDataReader myDataReader = myCommand.EndExecuteReader(itfAsynch);
      while (myDataReader.Read())
      {
        Console.WriteLine("-> Make: {0}, PetName: {1}, Color: {2}.",
          myDataReader["Make"].ToString().Trim(),
          myDataReader["PetName"].ToString().Trim(),
          myDataReader["Color"].ToString().Trim());
      }
      myDataReader.Close();
    }
  }
}
