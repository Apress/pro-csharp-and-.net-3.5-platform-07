using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

// Be sure to import these namespaces:
using MathServiceLibrary;
using System.ServiceModel;

namespace MathWindowsServiceHost
{
  public partial class MathWinService : ServiceBase
  {
    // A member variable of type ServiceHost.
    private ServiceHost myHost;

    public MathWinService()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      if (myHost != null)
      {
        myHost.Close();
      }

      // Create the host. 
      myHost = new ServiceHost(typeof(MathService));

      // The A,B,Cs in code!
      Uri address = new Uri("http://localhost:8080/MathServiceLibrary");
      WSHttpBinding binding = new WSHttpBinding();
      Type contract = typeof(IBasicMath);

      // Add this endpoint.
      myHost.AddServiceEndpoint(contract, binding, address);

      // Open the host.
      myHost.Open();
    }

    protected override void OnStop()
    {
      // Shut down the host.
      if (myHost != null)
        myHost.Close();
    }
  }
}
