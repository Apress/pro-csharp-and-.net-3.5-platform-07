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


namespace ControlReview
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();

      // Change FontSize of Label.
      lblInstructions.FontSize = 14;

      // Handle Click event for button.
      btnPurchaseOptions.Click +=new RoutedEventHandler(btnPurchaseOptions_Click);
    }

    private void btnPurchaseOptions_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Button has been clicked");
    }
  } 
}