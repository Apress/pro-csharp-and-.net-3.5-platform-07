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


namespace FunWithCommands
{
  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();

      SetF1CommandBinding();
    }

    private void SetF1CommandBinding()
    {
      CommandBinding helpBinding = new CommandBinding(ApplicationCommands.Help);
      helpBinding.CanExecute += CanHelpExecute;
      helpBinding.Executed += HelpExecuted;
      CommandBindings.Add(helpBinding);
    }

    private void CanHelpExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }
    private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      MessageBox.Show("Please contact your vendor for more support", "Help!");
    }
  }
}