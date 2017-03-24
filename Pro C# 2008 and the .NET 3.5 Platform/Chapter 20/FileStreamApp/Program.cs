using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileStreamApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with FileStreams *****\n");

      // Obtain a FileStream object.
      using (FileStream fStream = File.Open(@"C:\myMessage.dat",
        FileMode.Create))
      {
        #region Write out array of types to stream.
        // Encode a string as an array of bytes.
        string msg = "Hello!";
        byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

        // Write byte[] to file.
        fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

        // Reset internal position of stream.
        fStream.Position = 0;
        #endregion

        #region Read back data into memory.
        // Read the types from file and display to console.
        Console.Write("Your message as an array of bytes: ");
        byte[] bytesFromFile = new byte[msgAsByteArray.Length];
        for (int i = 0; i < msgAsByteArray.Length; i++)
        {
          bytesFromFile[i] = (byte)fStream.ReadByte();
          Console.Write(bytesFromFile[i]);
        }
        #endregion

        // Display decoded messages.
        Console.Write("\nDecoded Message: ");
        Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
      }
      Console.ReadLine();
    }
  }
}
