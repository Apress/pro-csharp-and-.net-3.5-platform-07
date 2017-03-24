using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;

namespace ProcessManipulator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Processes *****\n");
      ListAllRunningProcesses();

      #region Get a specific process via PID
      //Process theProc = null;
      //try
      //{
      //  theProc = Process.GetProcessById(987);
      //}
      //catch  // Generic catch for used simplicity.
      //{
      //  Console.WriteLine("-> Sorry...bad PID!");
      //}
      #endregion

      // Prompt user for a PID and print out the set of active threads.
      Console.WriteLine("***** Enter PID of process to investigate *****");
      Console.Write("PID: ");
      string pID = Console.ReadLine();
      int theProcID = int.Parse(pID);
      EnumThreadsForPid(theProcID);

      // Prompt user for a PID and print out the set of active threads.
      Console.WriteLine("***** Enter PID of process to investigate *****");
      Console.Write("PID: ");
      pID = Console.ReadLine();
      theProcID = int.Parse(pID);
      EnumModsForPid(theProcID);

      StartAndKillProcess();

      Console.ReadLine();
    }

    #region List all processes
    static void ListAllRunningProcesses()
    {
      // Get all the processes on the local machine.
      Process[] runningProcs = Process.GetProcesses(".");

      // Print out PID and name of each process.
      foreach (Process p in runningProcs)
      {
        string info = string.Format("-> PID: {0}\tName: {1}",
          p.Id, p.ProcessName);
        Console.WriteLine(info);
      }
      Console.WriteLine("************************************\n");
    }
    #endregion

    #region List threads for PID
    static void EnumThreadsForPid(int pID)
    {
      Process theProc = null;
      try
      {
        theProc = Process.GetProcessById(pID);
      }
      catch
      {
        Console.WriteLine("-> Sorry...bad PID!");
        Console.WriteLine("************************************\n");
        return;
      }

      // List out stats for each thread in the specified process.
      Console.WriteLine("Here are the threads used by: {0}",
        theProc.ProcessName);
      ProcessThreadCollection theThreads = theProc.Threads;
      foreach (ProcessThread pt in theThreads)
      {
        string info =
          string.Format("-> Thread ID: {0}\tStart Time {1}\tPriority {2}",
            pt.Id, pt.StartTime.ToShortTimeString(), pt.PriorityLevel);
        Console.WriteLine(info);
      }
      Console.WriteLine("************************************\n");
    }
    #endregion

    #region Enum mods for PID
    static void EnumModsForPid(int pID)
    {
      Process theProc = null;
      try
      {
        theProc = Process.GetProcessById(pID);
      }
      catch
      {
        Console.WriteLine("-> Sorry...bad PID!");
        Console.WriteLine("************************************\n");
        return;
      }
      Console.WriteLine("Here are the loaded modules for: {0}",
        theProc.ProcessName);
      try
      {
        ProcessModuleCollection theMods = theProc.Modules;
        foreach (ProcessModule pm in theMods)
        {
          string info = string.Format("-> Mod Name: {0}", pm.ModuleName);
          Console.WriteLine(info);
        }
        Console.WriteLine("************************************\n");
      }
      catch
      {
        Console.WriteLine("No mods!");
      }
    }
    #endregion

    #region Start / Stop process
    static void StartAndKillProcess()
    {
      // Launch Internet Explorer.
      Process ieProc = Process.Start("IExplore.exe", "www.intertech.com");

      Console.Write("--> Hit enter to kill {0}...", ieProc.ProcessName);
      Console.ReadLine();

      // Kill the iexplorer.exe process.
      try
      {
        ieProc.Kill();
      }
      catch { }   // In case the user already killed it...
    }

    #endregion
  }
}
