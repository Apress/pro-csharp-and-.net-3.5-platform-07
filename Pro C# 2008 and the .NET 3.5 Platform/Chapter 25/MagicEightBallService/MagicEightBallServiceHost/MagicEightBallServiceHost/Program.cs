using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Console Based WCF Host *****");

      using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
      {
        // Open the host and start listening for incoming messages.
        serviceHost.Open();
        DisplayHostInfo(serviceHost);
        // Keep the service running until Enter key is pressed.
        Console.WriteLine("The service is ready.");
        Console.WriteLine("Press the Enter key to terminate service.");
        Console.ReadLine();
      }
    }

    #region Just for fun...
    static void DisplayHostInfo(ServiceHost host)
    {
      Console.WriteLine();
      Console.WriteLine("***** Host Info *****");

      Console.WriteLine("Name: {0}",
        host.Description.ConfigurationName);
      Console.WriteLine("Port: {0}",
        host.BaseAddresses[0].Port);
      Console.WriteLine("LocalPath: {0}",
        host.BaseAddresses[0].LocalPath);
      Console.WriteLine("Uri: {0}",
        host.BaseAddresses[0].AbsoluteUri);
      Console.WriteLine("Scheme: {0}",
        host.BaseAddresses[0].Scheme);
      Console.WriteLine("**********************");
      Console.WriteLine();
    }
    #endregion
  }
}
