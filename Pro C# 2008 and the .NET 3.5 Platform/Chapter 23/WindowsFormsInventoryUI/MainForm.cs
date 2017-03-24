using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AutoLotDisconnectedLayer;
using System.Configuration;

namespace WindowsFormsInventoryUI
{
  public partial class MainForm : Form
  {
    InventoryDALDisLayer dal = null;

    public MainForm()
    {
      InitializeComponent();

      // Assume we have an App.config file
      // storing the connection string. 
      string cnStr =
        ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

      // Create our data access object.
      dal = new InventoryDALDisLayer(cnStr);

      // Fill up our grid!
      inventoryGrid.DataSource = dal.GetAllInventory();
    }

    private void btnUpdateInventory_Click(object sender, EventArgs e)
    {
      // Get modified data from the grid.
      DataTable changedDT = (DataTable)inventoryGrid.DataSource;

      // Commit our changes. 
      dal.UpdateInventory(changedDT);
    }
  }
}
