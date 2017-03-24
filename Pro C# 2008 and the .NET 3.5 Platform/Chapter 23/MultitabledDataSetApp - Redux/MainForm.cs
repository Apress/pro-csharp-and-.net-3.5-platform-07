using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AutoLotDAL;
using AutoLotDAL.AutoLotDataSetTableAdapters;

using System.Data.SqlClient;
using System.Configuration;

namespace MultitabledDataSetApp
{
  public partial class MainForm : Form
  {
    // Form wide strongly typed DataSet.
    private AutoLotDataSet autoLotDS = new AutoLotDataSet();

    // Custom data adapters (for each table).
    private InventoryTableAdapter invTableAdapter;
    private CustomersTableAdapter custTableAdapter;
    private OrdersTableAdapter ordersTableAdapter;

    #region Ctor logic
    public MainForm()
    {
      InitializeComponent();
      
      // Get Adapters.
      invTableAdapter = new InventoryTableAdapter();
      custTableAdapter = new CustomersTableAdapter();
      ordersTableAdapter = new OrdersTableAdapter();

      // Add tables to DS.
      invTableAdapter.Fill(autoLotDS.Inventory);
      custTableAdapter.Fill(autoLotDS.Customers);
      ordersTableAdapter.Fill(autoLotDS.Orders);

      // Bind to grids
      dataGridViewInventory.DataSource = autoLotDS.Inventory;
      dataGridViewCustomers.DataSource = autoLotDS.Customers;
      dataGridViewOrders.DataSource = autoLotDS.Orders;
    }
    #endregion

    #region Update Tables
    private void btnUpdate_Click(object sender, EventArgs e)
    {
      try
      {
        invTableAdapter.Update(autoLotDS.Inventory);
        custTableAdapter.Update(autoLotDS.Customers);
        ordersTableAdapter.Update(autoLotDS.Orders);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    #endregion

    #region Get Order Details
    private void btnGetOrderInfo_Click(object sender, System.EventArgs e)
    {
      string strOrderInfo = string.Empty;
      DataRow[] drsCust = null;
      DataRow[] drsOrder = null;

      // Get the customer ID in the text box.
      int custID = int.Parse(this.txtCustID.Text);

      // Now based on custID, get the correct row in Customers table.
      drsCust = autoLotDS.Tables["Customers"].Select(string.Format("CustID = {0}", custID));
      strOrderInfo += string.Format("Customer {0}: {1} {2}\n", 
        drsCust[0]["CustID"].ToString(),
        drsCust[0]["FirstName"].ToString().Trim(),
        drsCust[0]["LastName"].ToString().Trim());

      // Navigate from customer table to order table.
      drsOrder = drsCust[0].GetChildRows(autoLotDS.Relations["FK_Orders_Customers"]);

      // Get order number.
      foreach (DataRow r in drsOrder)
        strOrderInfo += string.Format("Order Number: {0}\n", r["OrderID"]);

      // Now navigate from order table to inventory table.
      DataRow[] drsInv =
           drsOrder[0].GetParentRows(autoLotDS.Relations["FK_Orders_Inventory"]);

      // Get Car info.
      foreach (DataRow r in drsInv)
      {
        strOrderInfo += string.Format("Make: {0}\n", r["Make"]);
        strOrderInfo += string.Format("Color: {0}\n", r["Color"]);
        strOrderInfo += string.Format("Pet Name: {0}\n", r["PetName"]);
      }
      MessageBox.Show(strOrderInfo, "Order Details");
    }
    #endregion
  }
}