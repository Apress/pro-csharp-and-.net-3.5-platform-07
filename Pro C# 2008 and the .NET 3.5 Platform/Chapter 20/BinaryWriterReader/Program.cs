using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BinaryWriterReader
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Binary Writers / Readers *****\n");

      // Open a binary writer for a file.
      FileInfo f = new FileInfo("BinFile.dat");

      #region Move binary data into a file stream
      using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
      {
        // Print out the type of BaseStream.
        // (System.IO.FileStream in this case).
        Console.WriteLine("Base stream is: {0}", bw.BaseStream);

        // Create some data to save in the file
        double aDouble = 1234.67;
        int anInt = 34567;
        string aString = "A, B, C";

        // Write the data
        bw.Write(aDouble);
        bw.Write(anInt);
        bw.Write(aString);
      }
      #endregion
      
      #region Read binary data in from stream
      // Read the data as raw bytes
      using (BinaryReader br = new BinaryReader(f.OpenRead()))
      {
        Console.WriteLine(br.ReadDouble());
        Console.WriteLine(br.ReadInt32());
        Console.WriteLine(br.ReadString());
      }
      #endregion

      Console.ReadLine();
    }
  }
}
