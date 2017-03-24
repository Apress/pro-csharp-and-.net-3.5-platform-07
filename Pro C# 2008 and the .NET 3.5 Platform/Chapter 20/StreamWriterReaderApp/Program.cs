using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StreamWriterReaderApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");

      #region Write textual data to file
      // Get a StreamWriter and write string data.
      using (StreamWriter writer = new StreamWriter("reminders.txt"))
      {
        writer.WriteLine("Don't forget Mother's Day this year...");
        writer.WriteLine("Don't forget Father's Day this year...");
        writer.WriteLine("Don't forget these numbers:");
        for (int i = 0; i < 10; i++)
          writer.Write(i + " ");

        // Insert a new line.
        writer.Write(writer.NewLine);
      }
      Console.WriteLine("Created file and wrote some thoughts...");
      #endregion

      #region Read textual data from file
      // Now read data from file.
      Console.WriteLine("Here are your thoughts:\n");
      using (StreamReader sr = new StreamReader("reminders.txt"))
      {
        string input = null;
        while ((input = sr.ReadLine()) != null)
        {
          Console.WriteLine(input);
        }
      }
      #endregion

      Console.ReadLine();
    }
  }
}
