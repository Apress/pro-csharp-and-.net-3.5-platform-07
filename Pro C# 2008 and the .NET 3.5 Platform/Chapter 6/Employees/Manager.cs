using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
  // Managers need to know their number of stock options.
  class Manager : Employee
  {
    public Manager() { }
    public Manager(string fullName, int age, int empID,
        float currPay, string ssn, int numbOfOpts)
      : base(fullName, age, empID, currPay, ssn)
    {
      // This field is defined by the Manager class.
      numberOfOptions = numbOfOpts;
    }

    private int numberOfOptions;
    public int StockOptions
    {
      get { return numberOfOptions; }
      set { numberOfOptions = value; }
    }

    public override void GiveBonus(float amount)
    {
      base.GiveBonus(amount);
      Random r = new Random();
      numberOfOptions += r.Next(500);
    }

    public override void DisplayStats()
    {
      base.DisplayStats();
      Console.WriteLine("Number of Stock Options: {0}", numberOfOptions);
    }
  }
}
