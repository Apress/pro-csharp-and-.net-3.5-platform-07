using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

// Add the following import.
using AutoLotConnectedLayer;

namespace CreditCheckWFLib
{
	public sealed partial class CreditCheckWF : SequentialWorkflowActivity
	{
    // ID of customer to run credit check against. 
    public int ID { get; set; }

    // We will use this to determine if the credit check 
    // as passed or failed. 
    public bool CreditOK { get; set; }

    public CreditCheckWF()
		{
			InitializeComponent();
    }

    #region Targets for activities
    private void ValidateCredit(object sender, EventArgs e)
    {
      // Pretend that we have preformed some exotic
      // credit validation here...
      Random r = new Random();
      int value = r.Next(500);
      if (value > 300)
        CreditOK = true;
      else
        CreditOK = false;
    }

    private void ProcessCreditRisk(object sender, EventArgs e)
    {
      // Ideally we would store the connection string externally.
      InventoryDAL dal = new InventoryDAL();
      dal.OpenConnection(@"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;" +
        "Initial Catalog=AutoLot");
      try
      {
        dal.ProcessCreditRisk(false, ID);
      }
      finally
      {
        dal.CloseConnection();
      }
    }

    private void PurchaseCar(object sender, EventArgs e)
    {
      // Here, we will opt for simplicity.  However, we could easly update
      // AutoLotDAL.dll with a new method to place a new order within the Orders table. 
      System.Windows.Forms.MessageBox.Show("Your credit has been approved!");
    }

    private void CreditDenied(object sender, EventArgs e)
    {
      System.Windows.Forms.MessageBox.Show("You are a CREDIT RISK!", 
        "Order Denied!");
    }
    #endregion
  }
}
