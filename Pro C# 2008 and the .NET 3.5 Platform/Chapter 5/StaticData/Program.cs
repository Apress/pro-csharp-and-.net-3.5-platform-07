using System;
using System.Collections.Generic;
using System.Text;

namespace StaticData
{
  // Define the application object as static.
  static class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Static Data *****\n");

      TimeUtilClass.PrintDate();
      // Compiler error! Can't create static classes.
      // TimeUtilClass u = new TimeUtilClass();

      SavingsAccount.SetInterestRate(0.09);
      SavingsAccount s1 = new SavingsAccount(50);
      SavingsAccount s2 = new SavingsAccount(100);

      // All three lines print out "Interest Rate is: 0.09"
      Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
      Console.WriteLine("Interest Rate is: {0}", s2.GetInterestRateObj());
      Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
      Console.ReadLine();
    }
  }
}
