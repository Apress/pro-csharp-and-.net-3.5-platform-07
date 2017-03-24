using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
  // Salespeople need to know their number of sales.
  class SalesPerson : Employee
  {
    private int numberOfSales;
    public int SalesNumber
    {
      get { return numberOfSales; }
      set { numberOfSales = value; }
    }

    public SalesPerson() { }
    public SalesPerson(string fullName, int age, int empID,
        float currPay, string ssn, int numbOfSales)
      : base(fullName, age, empID, currPay, ssn)
    {
      // This belongs with us!
      numberOfSales = numbOfSales;
    }

    #region Methods
    // A salesperson's bonus is influenced by the number of sales.
    public override sealed void GiveBonus(float amount)
    {
      int salesBonus = 0;
      if (numberOfSales >= 0 && numberOfSales <= 100)
      {
        salesBonus = 10;
      }
      else
      {
        if (numberOfSales >= 101 && numberOfSales <= 200)
        {
          salesBonus = 15;
        }
        else
        {
          salesBonus = 20;
        }
      }
      base.GiveBonus(amount * salesBonus);
    }

    public override void DisplayStats()
    {
      base.DisplayStats();
      Console.WriteLine("Number of Sales: {0}", numberOfSales);
    }
    #endregion
  }
}
