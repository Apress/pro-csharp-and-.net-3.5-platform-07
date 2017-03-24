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
using System.Windows.Shapes;

namespace CarViewerApp
{
  /// <summary>
  /// Interaction logic for AddNewCarDialog.xaml
  /// </summary>
  public partial class AddNewCarDialog : Window
  {
    public AddNewCarDialog()
    {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
    }

    public Car SelectedCar
    {
      get 
      {
        // Cast selected item on grid to an XmlElement.
        System.Xml.XmlElement carRow = (System.Xml.XmlElement)lstCars.SelectedItem;

        if (carRow == null)
        {
          return null;
        }
        else
        {
          // Generate a random speed.
          Random r = new Random();
          int speed = r.Next(100);

          // Return new Car based on the data in selected XmlElement/speed. 
          return new Car(speed, carRow["Make"].InnerText,
            carRow["Color"].InnerText, carRow["PetName"].InnerText);
        }
      }
    }
  }
}
