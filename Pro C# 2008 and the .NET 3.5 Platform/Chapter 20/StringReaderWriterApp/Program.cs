using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StringReaderWriterApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with StringWriter / StringReader *****\n");

      // Create a StringWriter and emit character data to memory.
      using (StringWriter strWriter = new StringWriter())
      {
        strWriter.WriteLine("Don't forget Mother's Day this year...");
        // Get a copy of the contents (stored in a string) and pump
        // to console.
        Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);

        #region Get the underlying StringBuilder
        // Get the internal StringBuilder.
        StringBuilder sb = strWriter.GetStringBuilder();
        sb.Insert(0, "Hey!! ");
        Console.WriteLine("-> {0}", sb.ToString());
        sb.Remove(0, "Hey!! ".Length);
        Console.WriteLine("-> {0}", sb.ToString());
        #endregion

        // Read data from the StringWriter.
        using (StringReader strReader = new StringReader(strWriter.ToString()))
        {
          string input = null;
          while ((input = strReader.ReadLine()) != null)
          {
            Console.WriteLine(input);
          }
        }
      }
      Console.ReadLine();
    }
  }
}
