using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsBackgroundWorkerThread
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnProcessData_Click(object sender, EventArgs e)
    {
      try
      {
      // First get the user data (as numerical).
      int numbOne = int.Parse(txtFirstNumber.Text);
      int numbTwo = int.Parse(this.txtSecondNumber.Text);
      AddParams args = new AddParams(numbOne, numbTwo);

      // Now spin up the new method and pass args variable.
      ProcessNumbersBackgroundWorker.RunWorkerAsync(args);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void ProcessNumbersBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      // Get the incoming AddParam object.
      AddParams args = (AddParams)e.Argument;

      // Artifical lag.
      System.Threading.Thread.Sleep(5000);

      // Return the value. 
      e.Result = args.a + args.b;
    }

    private void ProcessNumbersBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      MessageBox.Show(e.Result.ToString(), "Your result is");
    }
  }
}
