using System;
using System.Collections.Generic;
using System.Text;

namespace StaticData
{
  // This class has a single piece of non-static data.
  class SavingsAccount
  {
    public double currBalance;
    public static double currInterestRate;

    public SavingsAccount(double balance)
    {
      currBalance = balance;
    }

    // A static constructor.
    static SavingsAccount()
    {
      Console.WriteLine("In static ctor!");
      currInterestRate = 0.04;
    }

    #region Gets / sets for interest rate.
    // Static members to get/set interest rate.
    public static void SetInterestRate(double newRate)
    { currInterestRate = newRate; }
    public static double GetInterestRate()
    { return currInterestRate; }

    // Instance members to get/set interest rate.
    public void SetInterestRateObj(double newRate)
    { currInterestRate = newRate; }
    public double GetInterestRateObj()
    { return currInterestRate; }
    #endregion
  }
}
