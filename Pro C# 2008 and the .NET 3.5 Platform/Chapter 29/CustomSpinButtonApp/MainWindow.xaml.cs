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


namespace CustomSpinButtonApp
{
  public partial class MainWindow : System.Windows.Window
  {
    private int currValue = 0;

    public MainWindow()
    {
      InitializeComponent();
      lblCurrentValue.Content = currValue;
    }

    #region Up / Down Click logic
    protected void repeatAddValueButton_Click(object sender, RoutedEventArgs e)
    {
      currValue++;
      lblCurrentValue.Content = currValue;
    }
    protected void repeatRemoveValueButton_Click(object sender, RoutedEventArgs e)
    {
      currValue--;
      lblCurrentValue.Content = currValue;
    }
    #endregion
  }
}