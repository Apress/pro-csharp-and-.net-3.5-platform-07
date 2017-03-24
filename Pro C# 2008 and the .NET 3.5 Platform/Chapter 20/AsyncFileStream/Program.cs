using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace AsyncFileStream
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Async File I/O *****\n");

      Console.WriteLine("Main thread started. ThreadID = {0}",
        Thread.CurrentThread.GetHashCode());

      // Must use this ctor to get a FileStream with asynchronous
      // read or write access.
      FileStream fs = new FileStream("logfile.txt", FileMode.Append,
        FileAccess.Write, FileShare.None, 4096, true);

      string msg = "this is a test";
      byte[] buffer = Encoding.ASCII.GetBytes(msg);

      // Start the asynchronous write. WriteDone invoked when finished.
      // Note that the FileStream object is passed as state info to the
      // callback method.
      fs.BeginWrite(buffer, 0, buffer.Length,
        new AsyncCallback(WriteDone), fs);
    }

    private static void WriteDone(IAsyncResult ar)
    {
      Console.WriteLine("AsyncCallback method on ThreadID = {0}",
        Thread.CurrentThread.GetHashCode());

      Stream s = (Stream)ar.AsyncState;
      s.EndWrite(ar);
      s.Close();
    }
  }
}
