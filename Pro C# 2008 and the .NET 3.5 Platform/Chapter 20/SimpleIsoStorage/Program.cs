using System;
using System.IO.IsolatedStorage;
using System.IO;

namespace SimpleIsolatedStorage
{
  class WriteReadWithIsolatedStorage
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with isolated storage *****");
      WriteTextToIsoStorage();
      ReadTextFromIsoStorage();
      CreateStorageDirectories();
      Console.ReadLine();
    }

    #region Create directory structure
    private static void CreateStorageDirectories()
    {
      // Forward slashes and backwards slashes are acceptable. 
      using (IsolatedStorageFile store =
        IsolatedStorageFile.GetUserStoreForAssembly())
      {
        store.CreateDirectory(@"MyDir\XmlData");
        store.CreateDirectory("MyDir\\BinaryData");
        store.CreateDirectory("MyDir/TextData");
      }
    }
    #endregion

    #region Write text out.
    private static void WriteTextToIsoStorage()
    {
      // Open up isolated storage based on identity of
      // user + assembly evidence.  
      using (IsolatedStorageFile store =
        IsolatedStorageFile.GetUserStoreForAssembly())
      {
        // Now create an IsolatedStorageFileStream type.
        using (IsolatedStorageFileStream isStream
           = new IsolatedStorageFileStream("MyData.txt",
              FileMode.OpenOrCreate, store))
        {
          // Layer this stream into a StreamWriter
          // and write out some text. 
          using (StreamWriter sw = new StreamWriter(isStream))
          {
            sw.WriteLine("This is my data.");
            sw.WriteLine("Cool, huh?");
          }
        }
      }
    }
    #endregion

    #region Read text in.
    private static void ReadTextFromIsoStorage()
    {
      using (IsolatedStorageFile store =
        IsolatedStorageFile.GetUserStoreForAssembly())
      {
        using (IsolatedStorageFileStream isStream
           = new IsolatedStorageFileStream("MyData.txt", FileMode.Open,
             FileAccess.Read, store))
        {
          // Layer into StreamReader.  
          using (StreamReader sr = new StreamReader(isStream))
          {
            string allTheData = sr.ReadToEnd();
            Console.WriteLine(allTheData);
          }
        }
      }
    }
    #endregion
  }
}
