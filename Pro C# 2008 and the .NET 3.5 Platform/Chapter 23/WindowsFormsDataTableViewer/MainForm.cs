using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDataTableViewer
{
  public partial class MainForm : Form
  {
    // A collection of Car objects.
    List<Car> listCars = new List<Car>();

    // View of the DataTable.
    DataView coltsOnlyView;

    // Our DataTable.
    DataTable inventoryTable = new DataTable("Inventory");

    public MainForm()
    {
      InitializeComponent();

      #region Fill list with car objects.
      // Fill the list with some cars.
      listCars.Add(new Car("Chucky", "BMW", "Green"));
      listCars.Add(new Car("Tiny", "Yugo", "White"));
      listCars.Add(new Car("Ami", "Jeep", "Tan"));
      listCars.Add(new Car("Pain Inducer", "Caravan", "Pink"));
      listCars.Add(new Car("Fred", "BMW", "Pea Soup Green"));
      listCars.Add(new Car("Sidd", "BMW", "Black"));
      listCars.Add(new Car("Mel", "Firebird", "Red"));
      listCars.Add(new Car("Sarah", "Colt", "Black"));
      #endregion

      // Make a data table.
      CreateDataTable();

      // Make a view.
      CreateDataView();
    }

    #region Create the DataTable object and bind to grid.
    private void CreateDataTable()
    {
      // Create table schema
      DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
      DataColumn carColorColumn = new DataColumn("Color", typeof(string));
      DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
      carPetNameColumn.Caption = "Pet Name";
      inventoryTable.Columns.AddRange(new DataColumn[] { carMakeColumn, 
        carColorColumn, carPetNameColumn });

      // Iterate over the array list to make rows.
      foreach (Car c in listCars)
      {
        DataRow newRow = inventoryTable.NewRow();
        newRow["Make"] = c.carMake;
        newRow["Color"] = c.carColor;
        newRow["PetName"] = c.carPetName;
        inventoryTable.Rows.Add(newRow);
      }

      // Bind the DataTable to the carInventoryGridView.
      carInventoryGridView.DataSource = inventoryTable;
    }
    #endregion

    #region Handler for Remove Button's Click event.
    // Remove this row from the DataRowCollection.
    private void btnRemoveRow_Click(object sender, EventArgs e)
    {
      try
      {
        inventoryTable.Rows[(int.Parse(txtRowToRemove.Text))].Delete();
        inventoryTable.AcceptChanges();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    #endregion

    #region Handler / helper function for filtering logic
    private void btnDisplayMakes_Click(object sender, EventArgs e)
    {
      // Build a filter based on user input.
      string filterStr = string.Format("Make= '{0}' ", txtMakeToView.Text);

      // Find all rows matching the filter.
      DataRow[] makes = inventoryTable.Select(filterStr);

      // Show what we got!
      if (makes.Length == 0)
        MessageBox.Show("Sorry, no cars...", "Selection error!");
      else
      {
        string strMake = null;
        for (int i = 0; i < makes.Length; i++)
        {
          DataRow temp = makes[i];
          strMake += temp["PetName"] + "\n";
        }
        MessageBox.Show(strMake,
          string.Format("{0} type(s):", txtMakeToView.Text));
      }
    }
    #endregion

    #region Change BMWs to Yugos (oh, the horror...)
    private void btnChangeBeemersToYugos_Click(object sender, EventArgs e)
    {
      // Make sure user has not lost his or her mind.
      if (DialogResult.Yes ==
        MessageBox.Show("Are you sure?? BMWs are much nicer than Yugos!",
          "Please Confirm!", MessageBoxButtons.YesNo))
      {
        // Build a filter.
        string filterStr = "Make='BMW'";
        string strMake = string.Empty;

        // Find all rows matching the filter.
        DataRow[] makes = inventoryTable.Select(filterStr);

        // Change all Beemers to Yugos!
        for (int i = 0; i < makes.Length; i++)
        {
          makes[i]["Make"] = "Yugo";
        }
      }
    }
    #endregion

    #region Create our view object.
    private void CreateDataView()
    {
      // Set the table that is used to construct this view.
      coltsOnlyView = new DataView(inventoryTable);

      // Now configure the views using a filter.
      coltsOnlyView.RowFilter = "Make = 'Colt'";

      // Bind to the new grid.
      dataGridColtsView.DataSource = coltsOnlyView;
    }
    #endregion

    #region car ID > 5 (not called, but here for example...
    void ShowCarsWithIdGreaterThanFive()
    {
      // Now show the pet names of all cars with ID greater than 5.
      DataRow[] properIDs;
      string newFilterStr = "ID > 5";
      properIDs = inventoryTable.Select(newFilterStr);
      string strIDs = null;
      for (int i = 0; i < properIDs.Length; i++)
      {
        DataRow temp = properIDs[i];
        strIDs += temp["PetName"]
               + " is ID " + temp["ID"] + "\n";
      }
      MessageBox.Show(strIDs, "Pet names of cars where ID > 5");
    }
    #endregion

    #region This is just to see the row numbers
    void carInventoryGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
      // This extra code will simply make it easier to visualize the # of the rows. 
      using (SolidBrush b = new SolidBrush(Color.Black))
      {
        e.Graphics.DrawString((e.RowIndex).ToString(),
          e.InheritedRowStyle.Font, b, 
          e.RowBounds.Location.X + 15, 
          e.RowBounds.Location.Y + 4);
      }
    }

    private void dataGridColtsView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
      // A more funky font. 
      using (SolidBrush b = new SolidBrush(Color.Green))
      {
        e.Graphics.DrawString((e.RowIndex).ToString(),
          new Font("Times New Roman", 11, FontStyle.Italic | FontStyle.Bold), b,
          e.RowBounds.Location.X + 15,
          e.RowBounds.Location.Y + 4);
      }
    }    
    #endregion 
  }
}
