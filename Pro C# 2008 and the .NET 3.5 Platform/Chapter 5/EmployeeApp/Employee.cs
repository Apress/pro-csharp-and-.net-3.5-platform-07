using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
  /// <summary>
  /// This class represents an Employee.
  /// </summary>
  partial class Employee
  {
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
    public void GiveBonus(float amount)
    {
      currPay += amount;
    }

    /// <summary>
    /// Displays the stats of a given employee.
    /// </summary>
    public void DisplayStats()
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
