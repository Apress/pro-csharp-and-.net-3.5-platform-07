using System;
using System.Collections.Generic;
using System.Text;

using AutoLotConnectedLayer;

namespace AdoNetTransaction
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Simple Transaction Example *****\n");

      // A simple way to allow the tx to work or not.
      bool throwEx = true;
      string userAnswer = string.Empty;

      Console.Write("Do you want to throw an exception (Y or N): ");
      userAnswer = Console.ReadLine();
      if (userAnswer.ToLower() == "n")
      {
        throwEx = false;
      }

      InventoryDAL dal = new InventoryDAL();
      dal.OpenConnection(@"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;" +
        "Initial Catalog=AutoLot");

      // Process customer 999.
      dal.ProcessCreditRisk(throwEx, 999);
      Console.ReadLine();      
    }
  }
}
