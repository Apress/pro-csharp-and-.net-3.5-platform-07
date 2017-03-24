// A Simple WPF Application, written without XAML.
using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleWPFAppRevisited
{
  // In this first example, we are defining a single class type to 
  // represent the application itself and the main window.
  class MyWPFApp : Application
  {
    [STAThread]
    static void Main()
    {
      // Handle the Startup and Exit events, and then run the application.
      MyWPFApp app = new MyWPFApp();
      app.Startup += AppStartUp;
      app.Exit += AppExit;
      app.Run();  // Fires the Startup event.
    }

    static void AppExit(object sender, ExitEventArgs e)
    {
      MessageBox.Show("App has exited");
    }

    static void AppStartUp(object sender, StartupEventArgs e)
    {
      // Check the incoming command line arguments and see if they specefied a flag for GODMODE.
      Application.Current.Properties["GodMode"] = false;
	  foreach(string arg in e.Args)
	  {
	    if (arg.ToLower() == "/godmode")
	    {
	      Application.Current.Properties["GodMode"] = true;
	      break;
	    }
	  }

      // Create a MainWindow object. 
      MainWindow wnd = new MainWindow("My better WPF App!", 200, 300);
      // This is just for testing...
      // MinimizeAllWindows();
    }
    
    static void MinimizeAllWindows()
    {
      foreach (Window wnd in Application.Current.Windows)
      {
        wnd.WindowState = WindowState.Minimized;
      }
    }
  }
  
  class MainWindow : Window
  {
    // Our UI element.
    private Button btnExitApp = new Button();
    private string lifeTimeData = String.Empty;
    
    protected void MainWindow_Activated(object sender, EventArgs e)
    {
      lifeTimeData += "Activate Event Fired!\n";
    }
    protected void MainWindow_Deactivated(object sender, EventArgs e)
    {
      lifeTimeData += "Deactivated Event Fired!\n";
    }
    protected void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      lifeTimeData += "Loaded Event Fired!\n";
    }
    protected void MainWindow_Closing(object sender, 
      System.ComponentModel.CancelEventArgs e)
    {
      lifeTimeData += "Closing Event Fired!\n";
      
      // See if the user really wants to shut down this window.
      string msg = "Do you want to close without saving?";
      MessageBoxResult result = MessageBox.Show(msg, 
        "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
      if (result == MessageBoxResult.No)
      {
        // If user doesn't want to close, cancel closure
        e.Cancel = true;
      }
    }  
    protected void MainWindow_Closed(object sender, EventArgs e)
    {
      lifeTimeData += "Closing Event Fired!\n";
      MessageBox.Show(lifeTimeData);
    }
    protected void MainWindow_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
    {
      // Set the title of the window to the current X,Y of the mouse.
      this.Title = e.GetPosition(this).ToString();       
    }
    protected void MainWindow_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
    {
      // Display key press.
      this.Title = e.Key.ToString();     
    }
    
    public MainWindow(string windowTitle, int height, int width)
    {
      // Rig up events.
      this.Activated += MainWindow_Activated;
      this.Deactivated += MainWindow_Deactivated;
      this.Loaded += MainWindow_Loaded;
      this.Closing += MainWindow_Closing;
      this.Closed += MainWindow_Closed;
      this.MouseMove += MainWindow_MouseMove;
      this.KeyUp += MainWindow_KeyUp;
    
      // Configure button and set the child control.
      btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
      btnExitApp.Content = "Exit Application";
      btnExitApp.Height = 25;
      btnExitApp.Width = 100;
      this.AddChild(btnExitApp);

      // Configure the window.
      this.Title = windowTitle;
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.Height = height;
      this.Width = width;
      this.Show();
    }

    private void btnExitApp_Clicked(object sender, RoutedEventArgs e)
    {
      // Did user enable GODMODE?
      if((bool)Application.Current.Properties["GodMode"])
        MessageBox.Show("Cheater!");
        
      // Get a handle to the current application and shut it down.
      Application.Current.Shutdown();
    }
  }
}
