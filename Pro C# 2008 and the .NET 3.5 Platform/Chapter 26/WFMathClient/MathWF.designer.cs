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

namespace WFMathClient
{
	partial class MathWF
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
      System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding4 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding5 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding6 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding7 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding8 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding9 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding10 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding11 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding12 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
      System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
      System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
      System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
      System.Workflow.Activities.ChannelToken channeltoken1 = new System.Workflow.Activities.ChannelToken();
      System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding13 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding14 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
      System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding15 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
      System.Workflow.Activities.TypedOperationInfo typedoperationinfo1 = new System.Workflow.Activities.TypedOperationInfo();
      this.invokeWebServiceActivity4 = new System.Workflow.Activities.InvokeWebServiceActivity();
      this.invokeWebServiceActivity3 = new System.Workflow.Activities.InvokeWebServiceActivity();
      this.invokeWebServiceActivity2 = new System.Workflow.Activities.InvokeWebServiceActivity();
      this.invokeWebServiceActivity1 = new System.Workflow.Activities.InvokeWebServiceActivity();
      this.DivideBranch = new System.Workflow.Activities.IfElseBranchActivity();
      this.MultiplyBranch = new System.Workflow.Activities.IfElseBranchActivity();
      this.SubtractBranch = new System.Workflow.Activities.IfElseBranchActivity();
      this.AddBranch = new System.Workflow.Activities.IfElseBranchActivity();
      this.DisplayWCFResult = new System.Workflow.Activities.CodeActivity();
      this.WCFSendAddActivity = new System.Workflow.Activities.SendActivity();
      this.DisplayResult = new System.Workflow.Activities.CodeActivity();
      this.ifElseMathOpActivity = new System.Workflow.Activities.IfElseActivity();
      this.GetMathOpInput = new System.Workflow.Activities.CodeActivity();
      this.GetNumericalInput = new System.Workflow.Activities.CodeActivity();
      // 
      // invokeWebServiceActivity4
      // 
      this.invokeWebServiceActivity4.MethodName = "Divide";
      this.invokeWebServiceActivity4.Name = "invokeWebServiceActivity4";
      activitybind1.Name = "MathWF";
      activitybind1.Path = "FirstNumber";
      workflowparameterbinding1.ParameterName = "x";
      workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
      activitybind2.Name = "MathWF";
      activitybind2.Path = "SecondNumber";
      workflowparameterbinding2.ParameterName = "y";
      workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
      activitybind3.Name = "MathWF";
      activitybind3.Path = "Result";
      workflowparameterbinding3.ParameterName = "(ReturnValue)";
      workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
      this.invokeWebServiceActivity4.ParameterBindings.Add(workflowparameterbinding1);
      this.invokeWebServiceActivity4.ParameterBindings.Add(workflowparameterbinding2);
      this.invokeWebServiceActivity4.ParameterBindings.Add(workflowparameterbinding3);
      this.invokeWebServiceActivity4.ProxyClass = typeof(WFMathClient.localhost.MathService);
      // 
      // invokeWebServiceActivity3
      // 
      this.invokeWebServiceActivity3.MethodName = "Multiply";
      this.invokeWebServiceActivity3.Name = "invokeWebServiceActivity3";
      activitybind4.Name = "MathWF";
      activitybind4.Path = "FirstNumber";
      workflowparameterbinding4.ParameterName = "x";
      workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
      activitybind5.Name = "MathWF";
      activitybind5.Path = "SecondNumber";
      workflowparameterbinding5.ParameterName = "y";
      workflowparameterbinding5.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
      activitybind6.Name = "MathWF";
      activitybind6.Path = "Result";
      workflowparameterbinding6.ParameterName = "(ReturnValue)";
      workflowparameterbinding6.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
      this.invokeWebServiceActivity3.ParameterBindings.Add(workflowparameterbinding4);
      this.invokeWebServiceActivity3.ParameterBindings.Add(workflowparameterbinding5);
      this.invokeWebServiceActivity3.ParameterBindings.Add(workflowparameterbinding6);
      this.invokeWebServiceActivity3.ProxyClass = typeof(WFMathClient.localhost.MathService);
      // 
      // invokeWebServiceActivity2
      // 
      this.invokeWebServiceActivity2.MethodName = "Subtract";
      this.invokeWebServiceActivity2.Name = "invokeWebServiceActivity2";
      activitybind7.Name = "MathWF";
      activitybind7.Path = "FirstNumber";
      workflowparameterbinding7.ParameterName = "x";
      workflowparameterbinding7.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
      activitybind8.Name = "MathWF";
      activitybind8.Path = "SecondNumber";
      workflowparameterbinding8.ParameterName = "y";
      workflowparameterbinding8.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
      activitybind9.Name = "MathWF";
      activitybind9.Path = "Result";
      workflowparameterbinding9.ParameterName = "(ReturnValue)";
      workflowparameterbinding9.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
      this.invokeWebServiceActivity2.ParameterBindings.Add(workflowparameterbinding7);
      this.invokeWebServiceActivity2.ParameterBindings.Add(workflowparameterbinding8);
      this.invokeWebServiceActivity2.ParameterBindings.Add(workflowparameterbinding9);
      this.invokeWebServiceActivity2.ProxyClass = typeof(WFMathClient.localhost.MathService);
      // 
      // invokeWebServiceActivity1
      // 
      this.invokeWebServiceActivity1.MethodName = "Add";
      this.invokeWebServiceActivity1.Name = "invokeWebServiceActivity1";
      activitybind10.Name = "MathWF";
      activitybind10.Path = "FirstNumber";
      workflowparameterbinding10.ParameterName = "x";
      workflowparameterbinding10.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
      activitybind11.Name = "MathWF";
      activitybind11.Path = "SecondNumber";
      workflowparameterbinding11.ParameterName = "y";
      workflowparameterbinding11.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
      activitybind12.Name = "MathWF";
      activitybind12.Path = "Result";
      workflowparameterbinding12.ParameterName = "(ReturnValue)";
      workflowparameterbinding12.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
      this.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding10);
      this.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding11);
      this.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding12);
      this.invokeWebServiceActivity1.ProxyClass = typeof(WFMathClient.localhost.MathService);
      // 
      // DivideBranch
      // 
      this.DivideBranch.Activities.Add(this.invokeWebServiceActivity4);
      ruleconditionreference1.ConditionName = "Condition3";
      this.DivideBranch.Condition = ruleconditionreference1;
      this.DivideBranch.Name = "DivideBranch";
      // 
      // MultiplyBranch
      // 
      this.MultiplyBranch.Activities.Add(this.invokeWebServiceActivity3);
      ruleconditionreference2.ConditionName = "Condition3";
      this.MultiplyBranch.Condition = ruleconditionreference2;
      this.MultiplyBranch.Name = "MultiplyBranch";
      // 
      // SubtractBranch
      // 
      this.SubtractBranch.Activities.Add(this.invokeWebServiceActivity2);
      ruleconditionreference3.ConditionName = "Condition2";
      this.SubtractBranch.Condition = ruleconditionreference3;
      this.SubtractBranch.Name = "SubtractBranch";
      // 
      // AddBranch
      // 
      this.AddBranch.Activities.Add(this.invokeWebServiceActivity1);
      ruleconditionreference4.ConditionName = "Condition1";
      this.AddBranch.Condition = ruleconditionreference4;
      this.AddBranch.Name = "AddBranch";
      // 
      // DisplayWCFResult
      // 
      this.DisplayWCFResult.Name = "DisplayWCFResult";
      this.DisplayWCFResult.ExecuteCode += new System.EventHandler(this.WCFResult);
      // 
      // WCFSendAddActivity
      // 
      channeltoken1.EndpointName = "WSHttpBinding_IBasicMath";
      channeltoken1.Name = "WSHttpBinding_IBasicMath";
      channeltoken1.OwnerActivityName = "WCFSendAddActivity";
      this.WCFSendAddActivity.ChannelToken = channeltoken1;
      this.WCFSendAddActivity.Name = "WCFSendAddActivity";
      activitybind13.Name = "MathWF";
      activitybind13.Path = "FirstNumber";
      workflowparameterbinding13.ParameterName = "x";
      workflowparameterbinding13.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
      activitybind14.Name = "MathWF";
      activitybind14.Path = "SecondNumber";
      workflowparameterbinding14.ParameterName = "y";
      workflowparameterbinding14.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
      activitybind15.Name = "MathWF";
      activitybind15.Path = "Result";
      workflowparameterbinding15.ParameterName = "(ReturnValue)";
      workflowparameterbinding15.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
      this.WCFSendAddActivity.ParameterBindings.Add(workflowparameterbinding13);
      this.WCFSendAddActivity.ParameterBindings.Add(workflowparameterbinding14);
      this.WCFSendAddActivity.ParameterBindings.Add(workflowparameterbinding15);
      typedoperationinfo1.ContractType = typeof(WFMathClient.ServiceReference.IBasicMath);
      typedoperationinfo1.Name = "Add";
      this.WCFSendAddActivity.ServiceOperationInfo = typedoperationinfo1;
      // 
      // DisplayResult
      // 
      this.DisplayResult.Name = "DisplayResult";
      this.DisplayResult.ExecuteCode += new System.EventHandler(this.ShowResult);
      // 
      // ifElseMathOpActivity
      // 
      this.ifElseMathOpActivity.Activities.Add(this.AddBranch);
      this.ifElseMathOpActivity.Activities.Add(this.SubtractBranch);
      this.ifElseMathOpActivity.Activities.Add(this.MultiplyBranch);
      this.ifElseMathOpActivity.Activities.Add(this.DivideBranch);
      this.ifElseMathOpActivity.Name = "ifElseMathOpActivity";
      // 
      // GetMathOpInput
      // 
      this.GetMathOpInput.Name = "GetMathOpInput";
      this.GetMathOpInput.ExecuteCode += new System.EventHandler(this.GetOpInput);
      // 
      // GetNumericalInput
      // 
      this.GetNumericalInput.Name = "GetNumericalInput";
      this.GetNumericalInput.ExecuteCode += new System.EventHandler(this.GetNumbInput);
      // 
      // MathWF
      // 
      this.Activities.Add(this.GetNumericalInput);
      this.Activities.Add(this.GetMathOpInput);
      this.Activities.Add(this.ifElseMathOpActivity);
      this.Activities.Add(this.DisplayResult);
      this.Activities.Add(this.WCFSendAddActivity);
      this.Activities.Add(this.DisplayWCFResult);
      this.Name = "MathWF";
      this.CanModifyActivities = false;

		}

		#endregion

        private SendActivity WCFSendAddActivity;
        private CodeActivity DisplayWCFResult;
        private InvokeWebServiceActivity invokeWebServiceActivity2;
        private InvokeWebServiceActivity invokeWebServiceActivity3;
        private InvokeWebServiceActivity invokeWebServiceActivity4;
        private CodeActivity DisplayResult;
        private IfElseBranchActivity DivideBranch;
        private IfElseBranchActivity MultiplyBranch;
        private IfElseBranchActivity SubtractBranch;
        private IfElseBranchActivity AddBranch;
        private IfElseActivity ifElseMathOpActivity;
        private InvokeWebServiceActivity invokeWebServiceActivity1;
        private CodeActivity GetMathOpInput;
        private CodeActivity GetNumericalInput;























































  }
}
