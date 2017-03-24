using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
  /// <summary>
  /// This class represents an Employee.
  /// </summary>
  abstract partial class Employee
  {
    #region Benefit package code
    // This type will function as a contained class.
    // BenefitPackage nests BenefitPackageLevel.
    public class BenefitPackage
    {
      public enum BenefitPackageLevel
      {
        Standard, Gold, Platinum
      }
      public double ComputePayDeduction()
      {
        return 125.0;
      }
    }

    // Contain a BenefitPackage object.
    protected BenefitPackage empBenefits = new BenefitPackage();

    // Expose certain benefit behaviors of object.
    public double GetBenefitCost()
    { return empBenefits.ComputePayDeduction(); }

    // Expose object through a custom property.
    public BenefitPackage Benefits
    {
      get { return empBenefits; }
      set { empBenefits = value; }
    }
    #endregion

    #region Field data.
    /// <summary>
    /// Represents the emp's name.
    /// </summary>
    private string empName;

    /// <summary>
    /// Represents the emp's age.
    /// </summary>
    private int empID;

    /// <summary>
    /// Represents the emp's pay.
    /// </summary>
    private float currPay;

    /// <summary>
    /// Represents the emp's age.
    /// </summary>
    private int empAge;

    /// <summary>
    /// Represents the emp's SSN,
    /// must set in the ctor.
    /// </summary>
    private string empSSN;

    /// <summary>
    /// Company name, set in static ctor.
    /// </summary>
    private static string companyName;
    #endregion

    #region Members
    /// <summary>
    /// Give this person a raise!
    /// </summary>
    /// <param name="amount">Amount of pay increase</param>
    // This method can now be ‘overridden’ by a derived class.
    public virtual void GiveBonus(float amount)
    {
      currPay += amount;
    }

    /// <summary>
    /// Displays the stats of a given employee.
    /// </summary>
    public virtual void DisplayStats()
    {
      Console.WriteLine("Name: {0}", empName);
      Console.WriteLine("ID: {0}", empID);
      Console.WriteLine("Age: {0}", empAge);
      Console.WriteLine("SSN: {0}", empSSN);
      Console.WriteLine("Pay: {0}", currPay);
    }
    #endregion
  }
}