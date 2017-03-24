using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Need the WF runtime!
using System.Workflow.Runtime;

// Be sure to reference our custom WF library.
using CreditCheckWFLib;

namespace CreditCheckApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnCheckCustomerCredit_Click(object sender, EventArgs e)
    {
      // Create the WF runtime.
      WorkflowRuntime wfRuntime = new WorkflowRuntime();

      // Get ID in the TextBox to pass to the workflow.
      Dictionary<string, object> args = new 
        Dictionary<string, object>();
      args.Add("ID", int.Parse(txtCustomerID.Text));

      // Get an instance of our WF.
      WorkflowInstance myWorkflow =
        wfRuntime.CreateWorkflow(typeof(CreditCheckWF), args);

      // Start it up!
      myWorkflow.Start();
    }
  }
}
