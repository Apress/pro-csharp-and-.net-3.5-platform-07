using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Permissions;

[assembly: IsolatedStorageFilePermission(SecurityAction.RequestMinimum, 
  UsageAllowed = IsolatedStorageContainment.AssemblyIsolationByUser)]

namespace FileOrIsoStorageWinApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnFileIO_Click(object sender, EventArgs e)
    {
      using (StreamWriter sw = new StreamWriter(@"C:\MyData.txt"))
      {
        sw.WriteLine("This is my data.");
        sw.WriteLine("Cool, huh?");
      }
    }

    private void btnIsoStorage_Click(object sender, EventArgs e)
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
  }
}
