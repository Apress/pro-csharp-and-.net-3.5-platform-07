using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualDataGridViewApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
      this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
      // TODO: This line of code loads data into the 'autoLotDataSet.Inventory' table. You can move, or remove it, as needed.
      this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
      this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
    }

    private void btnUpdateInventory_Click(object sender, EventArgs e)
    {
      // Push changes back to database.
      this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);

      // Get fresh copy for grid.
      this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
    }

    #region Add Row Version 1
    //private void btnAddRow_Click(object sender, EventArgs e)
    //{
    //  // Get data from widgets
    //  int id = int.Parse(txtCarID.Text);
    //  string make = txtMake.Text; 
    //  string color = txtColor.Text;
    //  string petName = txtPetName.Text;

    //  // Use custom adapter to add row.
    //  inventoryTableAdapter.Insert(id, make, color, petName);

    //  // Re-fill table data.
    //  this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
    //}
    #endregion

    #region Add Row Version 2
    private void btnAddRow_Click(object sender, EventArgs e)
    {
      // Get new Row.
      InventoryDataSet.InventoryRow newRow = inventoryDataSet.Inventory.NewInventoryRow();
      newRow.CarID = int.Parse(txtCarID.Text);
      newRow.Make = txtMake.Text;
      newRow.Color = txtColor.Text;
      newRow.PetName = txtPetName.Text;
      inventoryDataSet.Inventory.AddInventoryRow(newRow);

      // Use custom adapter to add row.
      inventoryTableAdapter.Update(inventoryDataSet.Inventory);

      // Re-fill table data.
      this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
    }
    #endregion

  }
}
