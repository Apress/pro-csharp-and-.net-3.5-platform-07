using System;
using System.Collections.Generic;
using System.Text;

namespace ContextManipulator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Object Context *****\n");

      // Objects will display contextual info upon creation.
      SportsCar sport = new SportsCar();
      Console.WriteLine();

      SportsCar sport2 = new SportsCar();
      Console.WriteLine();

      SportsCarTS synchroSport = new SportsCarTS();
      Console.ReadLine();
    }
  }
}
