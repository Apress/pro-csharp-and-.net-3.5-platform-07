using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

namespace UserDataWFApp
{
  class Program
  {
    static void Main(string[] args)
    {
      using (WorkflowRuntime workflowRuntime = new WorkflowRuntime())
      {
        AutoResetEvent waitHandle = new AutoResetEvent(false);
        workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) { waitHandle.Set(); };
        workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
        {
          Console.WriteLine(e.Exception.Message);
          waitHandle.Set();
        };

        // Define two parameters for use by our workflow.
        // Remember!  These must be mapped to identically named
        // properties in our workflow class type.
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        parameters.Add("ErrorMessage", "Ack!  Your name is too long!");
        parameters.Add("NameLength", 5);

        // Now, create a WF instance that represents our type
        // and pass in parameters.
        WorkflowInstance instance =
          workflowRuntime.CreateWorkflow(
              typeof(UserDataWFApp.ProcessUsernameWorkflow), parameters
              );
        instance.Start();
        waitHandle.WaitOne();
      }
    }
  }
}
