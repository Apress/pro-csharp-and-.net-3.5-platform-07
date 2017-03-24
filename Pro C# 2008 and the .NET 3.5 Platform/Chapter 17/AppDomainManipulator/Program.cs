using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace AppDomainManipulator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with AppDomains *****\n");

      // Get info for current AppDomain.
      AppDomain defaultAD = AppDomain.CurrentDomain;
      defaultAD.ProcessExit += new EventHandler(defaultAD_ProcessExit);

      // This call is simply to load System.Windows.Forms.dll 
      // and System.dll into this app domain.
      System.Windows.Forms.MessageBox.Show("Hello");
      PrintAllAssembliesInAppDomain(defaultAD);

      #region Programmatically make new app domain
      // Make a new AppDomain in the current process.
      AppDomain anotherAD = AppDomain.CreateDomain("SecondAppDomain");
      
      // This code statment will add AppDomainManipulator to the 
      // otherAD AppDomain! This is because the handler is implemented
      // by the AppDomainManipulator.Program type!
      anotherAD.DomainUnload += new EventHandler(anotherAD_DomainUnload);

      // Load CarLibrary.dll into the new AppDomain.
      try
      {
        anotherAD.Load("CarLibrary");
        PrintAllAssembliesInAppDomain(anotherAD);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      // Now unload anotherAD.
      AppDomain.Unload(anotherAD);
      #endregion

      Console.ReadLine();
    }

    #region Event handlers
    static void anotherAD_DomainUnload(object sender, EventArgs e)
    {
      Console.WriteLine("***** Unloaded anotherAD! *****\n"); 
    }

    static void defaultAD_ProcessExit(object sender, EventArgs e)
    {
      Console.WriteLine("***** Unloaded defaultAD! *****\n");
    }
    #endregion

    #region Helper function
    static void PrintAllAssembliesInAppDomain(AppDomain ad)
    {
      Assembly[] loadedAssemblies = ad.GetAssemblies();
      Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n",
        ad.FriendlyName);
      foreach (Assembly a in loadedAssemblies)
      {
        Console.WriteLine("-> Name: {0}", a.GetName().Name);
        Console.WriteLine("-> Version: {0}\n", a.GetName().Version);
      }
    }
	  #endregion  
  }
}
