using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WPFControlEvents
{
  public partial class MainWindow : System.Windows.Window
  {
    // This is used to hold data on the mouse-event
    // activity.
    string mouseActivity = string.Empty;
    
    public MainWindow()
    {
      InitializeComponent();
    }

    #region Event Handlers
    public void btnClickMe_Clicked(object sender, RoutedEventArgs e)
    {
      // Show the final string.
      mouseActivity += "Button Click event fired!\n";
      MessageBox.Show(mouseActivity);

      // Clear string for next test.
      mouseActivity = string.Empty;
    }

    public void outerEllipse_MouseDown(object sender, RoutedEventArgs e)
    {
      // Add data to string.
      mouseActivity += "MouseDown event fired!\n";

      // Keep bubbling!
      e.Handled = false;
    }

    public void outerEllipse_PreviewMouseDown(object sender, RoutedEventArgs e)
    {
      // Add data to string.
      mouseActivity = "PreviewMouseDown event fired!\n";

      // Keep bubbling!
      e.Handled = false;
    }
    #endregion
  }
}