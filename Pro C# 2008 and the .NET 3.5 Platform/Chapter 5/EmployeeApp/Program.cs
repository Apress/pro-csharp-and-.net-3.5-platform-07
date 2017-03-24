// This example illustrates building well-encapsulated
// class types. 

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Encapsulation *****\n");
      Console.WriteLine("These folks work at {0}.", Employee.Company);

      Employee emp = new Employee("Marvin", 24, 456, 30000, "111-11-1111");
      emp.GiveBonus(1000);
      emp.DisplayStats();

      Console.ReadLine();
    }
  }
}
