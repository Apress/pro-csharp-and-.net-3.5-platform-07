using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace CustomSerialization
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Custom Serialization *****");

      // Recall, this type implements ISerializable.
      // Uncomment to persist.
      // StringData myData = new StringData();

      // This type customizes the serialization process
      // using .NET attributes. 
      MoreData myData = new MoreData();

      // Save to a local file in SOAP format. 
      SoapFormatter soapFormat = new SoapFormatter();
      using (Stream fStream = new FileStream("MyData.soap",
        FileMode.Create, FileAccess.Write, FileShare.None))
      {
        soapFormat.Serialize(fStream, myData);
      }

      Console.WriteLine("Done!  Check app directory for output");
      Console.ReadLine();
    }
  }
}
