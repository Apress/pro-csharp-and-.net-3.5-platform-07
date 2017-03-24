using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleXamlApp
{
	public partial class MyApp : Application
	{
	  void AppExit(object sender, ExitEventArgs e)
	  {
	    MessageBox.Show("App has exited");
      }
	}
}