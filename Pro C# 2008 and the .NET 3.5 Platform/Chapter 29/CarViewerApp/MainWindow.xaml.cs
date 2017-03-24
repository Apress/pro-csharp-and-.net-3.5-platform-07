using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.ObjectModel;

namespace CarViewerApp
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    CarList myCars = new CarList();

    public MainWindow()
    {
      InitializeComponent();
    }

    private void AddNewCarWizard(object sender, RoutedEventArgs e)
    {
      AddNewCarDialog dlg = new AddNewCarDialog();
      if (true == dlg.ShowDialog())
      {
        if (dlg.SelectedCar != null)
        {
          myCars.Add(dlg.SelectedCar);
        }
      }
    }

    private void ExitApplication(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void ListItemSelected(object sender, SelectionChangedEventArgs e)
    {
      // Get correct car from the ObservableCollection based 
      // on the selected item in the list box.  Then call toString().
      txtCarStats.Text = myCars[allCars.SelectedIndex].ToString();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      // Set the data context.
      allCars.DataContext = myCars; 
    }
  }
}
