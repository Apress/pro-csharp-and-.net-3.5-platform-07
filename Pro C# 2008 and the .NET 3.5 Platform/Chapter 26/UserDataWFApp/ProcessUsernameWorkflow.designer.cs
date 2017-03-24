using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace UserDataWFApp
{
	partial class ProcessUsernameWorkflow
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
      this.CanModifyActivities = true;
      System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
      this.NameNotValidActivity = new System.Workflow.Activities.CodeActivity();
      this.AskForNameLoopActivity = new System.Workflow.Activities.WhileActivity();
      this.ShowInstructionsActivity = new System.Workflow.Activities.CodeActivity();
      // 
      // NameNotValidActivity
      // 
      this.NameNotValidActivity.Name = "NameNotValidActivity";
      this.NameNotValidActivity.ExecuteCode += new System.EventHandler(this.NameNotValid);
      // 
      // AskForNameLoopActivity
      // 
      this.AskForNameLoopActivity.Activities.Add(this.NameNotValidActivity);
      codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.GetAndValidateUserName);
      this.AskForNameLoopActivity.Condition = codecondition1;
      this.AskForNameLoopActivity.Name = "AskForNameLoopActivity";
      // 
      // ShowInstructionsActivity
      // 
      this.ShowInstructionsActivity.Name = "ShowInstructionsActivity";
      this.ShowInstructionsActivity.ExecuteCode += new System.EventHandler(this.ShowInstructions);
      // 
      // ProcessUsernameWorkflow
      // 
      this.Activities.Add(this.ShowInstructionsActivity);
      this.Activities.Add(this.AskForNameLoopActivity);
      this.Name = "ProcessUsernameWorkflow";
      this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity NameNotValidActivity;
        private WhileActivity AskForNameLoopActivity;
        private CodeActivity ShowInstructionsActivity;




  }
}
