#define DEBUG
#define MONO_BUILD

using System;
using System.Collections.Generic;
using System.Text;

namespace PreprocessorDirectives
{
  class Program
  {
    static void Main(string[] args)
    {
      #region Print machine info under DEBUG build
      // This code will only execute if the project is 
      // compiled as a Debug build.
#if DEBUG
      Console.WriteLine("App directory: {0}",
        Environment.CurrentDirectory);
      Console.WriteLine("Box: {0}",
        Environment.MachineName);
      Console.WriteLine("OS: {0}",
        Environment.OSVersion);
      Console.WriteLine(".NET Version: {0}",
        Environment.Version);
#endif
      #endregion

    }
  }
}
