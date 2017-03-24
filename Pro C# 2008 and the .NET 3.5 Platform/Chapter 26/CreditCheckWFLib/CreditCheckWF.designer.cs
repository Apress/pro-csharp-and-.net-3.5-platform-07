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

namespace CreditCheckWFLib
{
	partial class CreditCheckWF
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
      System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
      this.ShowDenyMessageActivity = new System.Workflow.Activities.CodeActivity();
      this.ProcessCreditRiskActivity = new System.Workflow.Activities.CodeActivity();
      this.PurchaseCarActivity = new System.Workflow.Activities.CodeActivity();
      this.CreditCheckFailed = new System.Workflow.Activities.IfElseBranchActivity();
      this.CreditCheckOK = new System.Workflow.Activities.IfElseBranchActivity();
      this.CreditCheckPassedActivity = new System.Workflow.Activities.IfElseActivity();
      this.ValidateCreditActivity = new System.Workflow.Activities.CodeActivity();
      // 
      // ShowDenyMessageActivity
      // 
      this.ShowDenyMessageActivity.Name = "ShowDenyMessageActivity";
      this.ShowDenyMessageActivity.ExecuteCode += new System.EventHandler(this.CreditDenied);
      // 
      // ProcessCreditRiskActivity
      // 
      this.ProcessCreditRiskActivity.Name = "ProcessCreditRiskActivity";
      this.ProcessCreditRiskActivity.ExecuteCode += new System.EventHandler(this.ProcessCreditRisk);
      // 
      // PurchaseCarActivity
      // 
      this.PurchaseCarActivity.Name = "PurchaseCarActivity";
      this.PurchaseCarActivity.ExecuteCode += new System.EventHandler(this.PurchaseCar);
      // 
      // CreditCheckFailed
      // 
      this.CreditCheckFailed.Activities.Add(this.ProcessCreditRiskActivity);
      this.CreditCheckFailed.Activities.Add(this.ShowDenyMessageActivity);
      this.CreditCheckFailed.Name = "CreditCheckFailed";
      // 
      // CreditCheckOK
      // 
      this.CreditCheckOK.Activities.Add(this.PurchaseCarActivity);
      ruleconditionreference1.ConditionName = "Condition1";
      this.CreditCheckOK.Condition = ruleconditionreference1;
      this.CreditCheckOK.Name = "CreditCheckOK";
      // 
      // CreditCheckPassedActivity
      // 
      this.CreditCheckPassedActivity.Activities.Add(this.CreditCheckOK);
      this.CreditCheckPassedActivity.Activities.Add(this.CreditCheckFailed);
      this.CreditCheckPassedActivity.Name = "CreditCheckPassedActivity";
      // 
      // ValidateCreditActivity
      // 
      this.ValidateCreditActivity.Name = "ValidateCreditActivity";
      this.ValidateCreditActivity.ExecuteCode += new System.EventHandler(this.ValidateCredit);
      // 
      // CreditCheckWF
      // 
      this.Activities.Add(this.ValidateCreditActivity);
      this.Activities.Add(this.CreditCheckPassedActivity);
      this.Name = "CreditCheckWF";
      this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity ShowDenyMessageActivity;
        private CodeActivity PurchaseCarActivity;
        private IfElseBranchActivity CreditCheckFailed;
        private IfElseBranchActivity CreditCheckOK;
        private IfElseActivity CreditCheckPassedActivity;
        private CodeActivity ProcessCreditRiskActivity;
        private CodeActivity ValidateCreditActivity;






  }
}
