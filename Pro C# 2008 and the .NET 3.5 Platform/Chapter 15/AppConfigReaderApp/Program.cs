using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace AppConfigReaderApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Reading <appSettings> Data *****\n");
      // Create a reader and get the connection string value.
      AppSettingsReader ar = new AppSettingsReader();
      Console.WriteLine(ar.GetValue("appConStr", typeof(string)));

      // Now get the number of times to say hello, and then do it!
      int numbOfTimes = (int)ar.GetValue("timesToSayHello", typeof(int));
      for (int i = 0; i < numbOfTimes; i++)
        Console.WriteLine("Howdy!");
      Console.ReadLine();
    }
  }
}
