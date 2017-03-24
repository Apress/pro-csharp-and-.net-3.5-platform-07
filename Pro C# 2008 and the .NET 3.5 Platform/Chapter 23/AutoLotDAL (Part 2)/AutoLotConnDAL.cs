using System;
using System.Collections.Generic;
using System.Text;

// We will make use of the SQL server
// provider, however it would also be
// permissible to make use of the ADO.NET
// factory pattern for greater flexibility.
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
  public class InventoryDAL
  {
    #region Connection and Disconnection details.
    // This member will be used by all methods.
    private SqlConnection sqlCn = new SqlConnection();

    public void OpenConnection(string connectionString)
    {
      sqlCn.ConnectionString = connectionString;
      sqlCn.Open();
    }
    public void CloseConnection()
    {
      sqlCn.Close();
    }
    #endregion

    #region Insert logic (both versions)
    //public void InsertAuto(int id, string color, string make, string petName)
    //{
    //  // Format and execute SQL statement.
    //  string sql = string.Format("Insert Into Inventory" +
    //      "(CarID, Make, Color, PetName) Values" +
    //      "('{0}', '{1}', '{2}', '{3}')", id, make, color, petName);

    //  // Execute using our connection.
    //  SqlCommand cmd = new SqlCommand(sql, this.sqlCn);
    //  cmd.ExecuteNonQuery();
    //}

    public void InsertAuto(int id, string color, string make, string petName)
    {
      // Note the 'placeholders' in the SQL query.
      string sql = string.Format("Insert Into Inventory" +
          "(CarID, Make, Color, PetName) Values" +
          "(@CarID, @Make, @Color, @PetName)");

      // This command will have internal parameters.
      SqlCommand cmd = new SqlCommand(sql, this.sqlCn);

      // Fill params collection.
      SqlParameter param = new SqlParameter();
      param.ParameterName = "@CarID";
      param.Value = id;
      param.SqlDbType = SqlDbType.Int;
      cmd.Parameters.Add(param);

      param = new SqlParameter();
      param.ParameterName = "@Make";
      param.Value = make;
      param.SqlDbType = SqlDbType.Char;
      param.Size = 10;
      cmd.Parameters.Add(param);

      param = new SqlParameter();
      param.ParameterName = "@Color";
      param.Value = color;
      param.SqlDbType = SqlDbType.Char;
      param.Size = 10;
      cmd.Parameters.Add(param);

      param = new SqlParameter();
      param.ParameterName = "@PetName";
      param.Value = petName;
      param.SqlDbType = SqlDbType.Char;
      param.Size = 10;
      cmd.Parameters.Add(param);

      cmd.ExecuteNonQuery();
    }
    #endregion

    #region Delete logic
    public void DeleteCar(int id)
    {
      // Get ID of car to delete, then do so.
      string sql = string.Format("Delete from Inventory where CarID = '{0}'",
        id);
      SqlCommand cmd = new SqlCommand(sql, this.sqlCn);
      try
      {
        cmd.ExecuteNonQuery();
      }
      catch
      {
        throw new Exception("Sorry!  That car is on order!");
      }
    }
    #endregion

    #region Update logic
    public void UpdateCarPetName(int id, string newPetName)
    {
      // Get ID of car to modify and new pet name.
      string sql =
        string.Format("Update Inventory Set PetName = '{0}' Where CarID = '{1}'",
        newPetName, id);
      SqlCommand cmd = new SqlCommand(sql, this.sqlCn);
      cmd.ExecuteNonQuery();
    }
    #endregion

    #region Select logic
    public DataTable GetAllInventory()
    {
      // Prep command object.
      string sql = "Select * From Inventory";
      SqlCommand cmd = new SqlCommand(sql, this.sqlCn);
      SqlDataReader dr = cmd.ExecuteReader();

      // This will hold the records. 
      DataTable inv = new DataTable();

      // Fill the DataTable with data from the reader and clean up.
      inv.Load(dr);
      dr.Close();
      return inv;
    }
    #endregion

    #region Trigger stored proc logic
    public string LookUpPetName(int carID)
    {
      // Establish name of stored proc.
      SqlCommand cmd = new SqlCommand("GetPetName", this.sqlCn);
      cmd.CommandType = CommandType.StoredProcedure;

      // Input param.
      SqlParameter param = new SqlParameter();
      param.ParameterName = "@carID";
      param.SqlDbType = SqlDbType.Int;
      param.Value = carID;
      param.Direction = ParameterDirection.Input;
      cmd.Parameters.Add(param);

      // Output param.
      param = new SqlParameter();
      param.ParameterName = "@petName";
      param.SqlDbType = SqlDbType.Char;
      param.Size = 10;
      param.Direction = ParameterDirection.Output;
      cmd.Parameters.Add(param);

      // Execute the stored proc.
      cmd.ExecuteNonQuery();

      // Return output param.
      return ((string)cmd.Parameters["@petName"].Value).Trim();
    }
    #endregion

    #region Tx Method
    // A new member of the InventoryDAL class.
    public void ProcessCreditRisk(bool throwEx, int custID)
    {
      // First, look up current name based on customer ID.
      string fName = string.Empty;
      string lName = string.Empty;

      SqlCommand cmdSelect = new SqlCommand(
        string.Format("Select * from Customers where CustID = {0}", custID), sqlCn);
      using (SqlDataReader dr = cmdSelect.ExecuteReader())
      {
        while (dr.Read())
        {
          fName = (string)dr["FirstName"];
          lName = (string)dr["LastName"];
        }
      }

      // Create command objects which represent each step of the operation.
      SqlCommand cmdRemove = new SqlCommand(
        string.Format("Delete from Customers where CustID = {0}", custID), sqlCn);

      SqlCommand cmdInsert = new SqlCommand(string.Format("Insert Into CreditRisks" +
                       "(CustID, FirstName, LastName) Values" +
                       "({0}, '{1}', '{2}')", custID, fName, lName), sqlCn);

      // We will get this from the Connection object.
      SqlTransaction tx = null;
      try
      {
        tx = sqlCn.BeginTransaction();

        // Enlist the commands into this transaction.
        cmdInsert.Transaction = tx;
        cmdRemove.Transaction = tx;

        // Execute the commands.
        cmdInsert.ExecuteNonQuery();
        cmdRemove.ExecuteNonQuery();

        // Simulate error.
        if (throwEx)
        {
          throw new ApplicationException("Sorry!  Database error! Tx failed...");
        }

        // Commit it!
        tx.Commit();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        // Any error will rollback transaction.
        tx.Rollback();
      }
    }
    #endregion 

  }
}
