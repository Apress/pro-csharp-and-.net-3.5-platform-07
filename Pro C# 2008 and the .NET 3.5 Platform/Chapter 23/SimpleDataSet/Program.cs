using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleDataSet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with DataSets *****\n");

      DataSet carsInventoryDS = new DataSet("Car Inventory");
      
      #region Add extended properties to the DataSet
      // Create the DataSet object.
      carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
      carsInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
      carsInventoryDS.ExtendedProperties["Company"] = "Intertech Training";
      #endregion

      #region Add columns to a new DataTable
      // Create data columns that map to the 
      // 'real' columns in the Inventory table 
      // of the AutoLot database.
      DataColumn carIDColumn = new DataColumn("CarID", typeof(int));
      carIDColumn.Caption = "Car ID";
      carIDColumn.ReadOnly = true;
      carIDColumn.AllowDBNull = false;
      carIDColumn.Unique = true;
      carIDColumn.AutoIncrement = true;
      carIDColumn.AutoIncrementSeed = 0;
      carIDColumn.AutoIncrementStep = 1;

      DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
      DataColumn carColorColumn = new DataColumn("Color", typeof(string));
      DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
      carPetNameColumn.Caption = "Pet Name";

      // Now add DataColumns to a DataTable.
      DataTable inventoryTable = new DataTable("Inventory");
      inventoryTable.Columns.AddRange(new DataColumn[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });
      #endregion

      #region Add rows to the same DataTable / set primary key
      // Now add some rows to the Inventory Table.
      DataRow carRow = inventoryTable.NewRow();
      carRow["Make"] = "BMW";
      carRow["Color"] = "Black";
      carRow["PetName"] = "Hamlet";
      inventoryTable.Rows.Add(carRow);

      carRow = inventoryTable.NewRow();
      carRow[1] = "Saab";
      carRow[2] = "Red";
      carRow[3] = "Sea Breeze";
      inventoryTable.Rows.Add(carRow);

      // Mark the primary key of this table.
      inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };
      #endregion

      // Finally, add our table to the DataSet.
      carsInventoryDS.Tables.Add(inventoryTable);

      // Now print the DataSet.
      PrintDataSet(carsInventoryDS);

      // Save and load as XML.
      DataSetAsXml(carsInventoryDS);

      // Save and load as binary.
      DataSetAsBinary(carsInventoryDS);

      // Uncomment to test.
      ManipulateDataRowState();
      Console.ReadLine();
    }

    #region DataSet as XML
    private static void DataSetAsXml(DataSet carsInventoryDS)
    {
      // Save this DataSet as XML.
      carsInventoryDS.WriteXml("carsDataSet.xml");
      carsInventoryDS.WriteXmlSchema("carsDataSet.xsd");

      // Clear out DataSet.
      carsInventoryDS.Clear();

      // Load DataSet from XML file.
      carsInventoryDS.ReadXml("carsDataSet.xml");
    }
    #endregion

    #region DataSet as Binary
    private static void DataSetAsBinary(DataSet carsInventoryDS)
    {
      // Set binary serialization flag.
      carsInventoryDS.RemotingFormat = SerializationFormat.Binary;

      // Save this DataSet as binary.
      FileStream fs = new FileStream("BinaryCars.bin", FileMode.Create);
      BinaryFormatter bFormat = new BinaryFormatter();
      bFormat.Serialize(fs, carsInventoryDS);
      fs.Close();

      // Clear out DataSet.
      carsInventoryDS.Clear();

      // Load DataSet from binary file.
      fs = new FileStream("BinaryCars.bin", FileMode.Open);
      DataSet data = (DataSet)bFormat.Deserialize(fs);
    }
    #endregion

    #region DataRowState manipulation test
    private static void ManipulateDataRowState()
    {
      Console.WriteLine("\n\n***** Fun with RowState *****\n");
      // Create a temp DataTable for testing.
      DataTable temp = new DataTable("Temp");
      temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

      // RowState = Detatched. 
      DataRow row = temp.NewRow();           
      Console.WriteLine("After calling NewRow(): {0}", row.RowState);

      // RowState = Added.
      temp.Rows.Add(row);
      Console.WriteLine("After calling Rows.Add(): {0}", row.RowState);

      // RowState = Added.
      row["TempColumn"] = 10;
      Console.WriteLine("After first assignment: {0}", row.RowState);

      // RowState = Unchanged.
      temp.AcceptChanges();
      Console.WriteLine("After calling AcceptChanges: {0}", row.RowState);

      // RowState = Modified.
      row["TempColumn"] = 11;
      Console.WriteLine("After first assignment: {0}", row.RowState);

      // RowState = Deleted.
      temp.Rows[0].Delete();
      Console.WriteLine("After calling Delete: {0}", row.RowState);
    }
    #endregion

    #region Print out DataSet
    static void PrintDataSet(DataSet ds)
    {
      // Print out any name and extended properties. 
      Console.WriteLine("DataSet is named: {0}", ds.DataSetName);
      foreach (System.Collections.DictionaryEntry de in ds.ExtendedProperties)
      {
        Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
      }
      Console.WriteLine();

      foreach (DataTable dt in ds.Tables)
      {
        Console.WriteLine("=> {0} Table:", dt.TableName);

        // Print out the column names.
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Columns[curCol].ColumnName + "\t");
        }
        Console.WriteLine("\n----------------------------------");

        #region Old logic...
        //// Print the DataTable.
        //for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
        //{
        //  for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        //  {
        //    Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");
        //  }
        //  Console.WriteLine();
        //}
        #endregion

        PrintTable(dt);
      }
    }
    #endregion

    #region Print out DataTable using DataTableReader
    private static void PrintTable(DataTable dt)
    {
      // Get the DataTableReader type.
      DataTableReader dtReader = dt.CreateDataReader();

      // The DataTableReader works just like the DataReader.
      while (dtReader.Read())
      {
        for (int i = 0; i < dtReader.FieldCount; i++)
        {
          Console.Write("{0}\t", dtReader.GetValue(i).ToString().Trim());
        }
        Console.WriteLine();
      }
      dtReader.Close();
    }
    #endregion
  }
}
