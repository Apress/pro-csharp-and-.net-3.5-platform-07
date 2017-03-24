using System;
using System.Reflection;
using System.Security.Policy;
using System.Collections;

namespace MyEvidenceViewer
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isUserDone = false;
      string userOption = "";
      Assembly asm = null;

      Console.WriteLine("***** Evidence Viewer *****\n");

      #region Get user option
      do
      {
        Console.Write("L (load assembly) or Q (quit): ");
        userOption = Console.ReadLine();
        switch (userOption.ToLower())
        {
          case "l":
            asm = LoadAsm();
            if (asm != null)
            {
              DisplayAsmEvidence(asm);
            }
            break;

          case "q":
            isUserDone = true;
            break;

          default:
            Console.WriteLine("I have no idea what you want!");
            break;
        }
      } while (!isUserDone);
      #endregion
    }

    #region Helper methods
    private static Assembly LoadAsm()
    {
      Console.Write("Enter path to assembly: ");
      try
      {
        return Assembly.LoadFrom(Console.ReadLine());
      }
      catch
      {
        Console.WriteLine("Load error...");
        return null;
      }
    }

    private static void DisplayAsmEvidence(Assembly asm)
    {
      // Get evidence collection and underlying enumerator. 
      Evidence e = asm.Evidence;
      IEnumerator itfEnum = e.GetHostEnumerator();

      // Now print out the evidence.
      while (itfEnum.MoveNext())
      {
        Console.WriteLine(" **** Press Enter to continue ****");
        Console.ReadLine();
        Console.WriteLine(itfEnum.Current);
      }
    }
    #endregion
  }
}
