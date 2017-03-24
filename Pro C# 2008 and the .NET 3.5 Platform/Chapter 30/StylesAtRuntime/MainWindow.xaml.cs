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


namespace StylesAtRuntime
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      // Add items to our list box.
      lstStyles.Items.Add("TiltStyle");
      lstStyles.Items.Add("GreenStyle");
      lstStyles.Items.Add("MouseOverStyle");
    }

    protected void comboStyles_Changed(object sender, RoutedEventArgs args)
    {
      // Get the selected style name from the list box.      
      System.Windows.Style currStyle = 
        (System.Windows.Style)FindResource(lstStyles.SelectedValue);

      // Set style of the button type.
      this.btnMouseOverStyle.Style = currStyle;
    }

    protected void btnMouseOverStyle_Click(object sender, RoutedEventArgs args)
    {
      MessageBox.Show("Clicked");
    }
  }
}