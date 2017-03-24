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

namespace WFMathClient
{
  public enum MathOperation
  {
    Add, Subtract, Multiply, Divide
  }

  public sealed partial class MathWF : SequentialWorkflowActivity
  {    
    public int Result { get; set; }
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public MathOperation Operation { get; set; }

    public MathWF()
    {
      InitializeComponent();

      // Set default Operation to addition.
      Operation = MathOperation.Add;
    }

    #region Code conditions
    private void GetNumbInput(object sender, EventArgs e)
    {
      // For simplicity, we are not bothering to verify that
      // the input values are indeed numerical.
      Console.Write("Enter first number: ");
      FirstNumber = int.Parse(Console.ReadLine());

      Console.Write("Enter second number: ");
      SecondNumber = int.Parse(Console.ReadLine());
    }

    private void GetOpInput(object sender, EventArgs e)
    {
      Console.WriteLine("Do you wish to A[dd], S[ubtract],");
      Console.Write("Do you wish to M[ultiply] or D[ivide]: ");
      string option = Console.ReadLine();

      switch (option.ToUpper())
      {
        case "A":
          Operation = MathOperation.Add;
          break;
        case "S":
          Operation = MathOperation.Subtract;
          break;
        case "M":
          Operation = MathOperation.Multiply;
          break;
        case "D":
          Operation = MathOperation.Divide;
          break;
        default:
          Operation = MathOperation.Add;
          break;
      }
    }

    private void ShowResult(object sender, EventArgs e)
    {
      Console.WriteLine("{0} {1} {2} = {3}",
        FirstNumber, Operation.ToString().ToUpper(), SecondNumber, Result);
    }

    private void WCFResult(object sender, EventArgs e)
    {
      Console.WriteLine("***** WCF Service Addition *****");
      Console.WriteLine("{0} + {1} = {2}",
        FirstNumber, SecondNumber, Result);
    }
    #endregion
  }
}
