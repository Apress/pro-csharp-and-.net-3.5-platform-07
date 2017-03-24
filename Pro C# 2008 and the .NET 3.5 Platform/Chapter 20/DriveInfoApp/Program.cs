using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DriveInfoApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with DriveInfo *****\n");

      // Get info regarding all drives.
      DriveInfo[] myDrives = DriveInfo.GetDrives();

      // Now print drive stats. 
      foreach (DriveInfo d in myDrives)
      {
        Console.WriteLine("Name: {0}", d.Name);
        Console.WriteLine("Type: {0}", d.DriveType);

        // Check to see if the drive is mounted.
        if (d.IsReady)
        {
          Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
          Console.WriteLine("Format: {0}", d.DriveFormat);
          Console.WriteLine("Label: {0}", d.VolumeLabel);
          Console.WriteLine();
        }
        Console.WriteLine();
      }
      Console.ReadLine();
    }
  }
}
