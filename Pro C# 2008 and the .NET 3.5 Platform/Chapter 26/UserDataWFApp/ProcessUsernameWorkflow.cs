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
using System.Workflow.Runtime.Hosting;

namespace UserDataWFApp
{
  public sealed partial class ProcessUsernameWorkflow : SequentialWorkflowActivity
  {
    public ProcessUsernameWorkflow()
    {
      InitializeComponent();
    }

    public string UserName { get; set; }
    public string ErrorMessage { get; set; }
    public int NameLength { get; set; }

    #region Activity code conditions
    private void ShowInstructions(object sender, EventArgs e)
    {
      ConsoleColor previousColor = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("*******************************************");
      Console.WriteLine("***** Welcome to the first WF Example *****");
      Console.WriteLine("*******************************************\n");
      Console.WriteLine("I will now ask for your name and validate the data...\n");
      Console.ForegroundColor = previousColor;
    }

    private void GetAndValidateUserName(object sender, ConditionalEventArgs e)
    {
      Console.Write("Please enter name, which must be less than {0} chars: ", 
        NameLength);
      UserName = Console.ReadLine();

      // See if name is correct length, and set the result.
      e.Result = (UserName.Length >= NameLength);
    }

    private void NameNotValid(object sender, EventArgs e)
    {
      Console.WriteLine(ErrorMessage);
    }
    #endregion
  }
}
