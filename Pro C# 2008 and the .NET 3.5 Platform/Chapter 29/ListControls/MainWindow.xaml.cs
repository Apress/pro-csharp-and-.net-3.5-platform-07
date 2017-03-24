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


namespace ListControls
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class MainWindow : System.Windows.Window
  {

    public MainWindow()
    {
      InitializeComponent();

      FillListBox();
    }

    #region Fill the list box
    private void FillListBox()
    {
      // Add items to the listbox.
      lstVideoGameConsoles.Items.Add("Microsoft XBox 360");
      lstVideoGameConsoles.Items.Add("Sony Playstation 3");
      lstVideoGameConsoles.Items.Add("Nintendo Wii");
      lstVideoGameConsoles.Items.Add("Sony PSP");
      lstVideoGameConsoles.Items.Add("Nintendo DS");
    } 
    #endregion

    #region Click handlers
    protected void btnGetGameSystem_Click(object sender, RoutedEventArgs args)
    {
      string data = string.Empty;
      data += string.Format("SelectedIndex = {0}\n", lstVideoGameConsoles.SelectedIndex);
      data += string.Format("SelectedItem = {0}\n", lstVideoGameConsoles.SelectedItem);
      data += string.Format("SelectedValue = {0}", lstVideoGameConsoles.SelectedValue);
      MessageBox.Show(data, "Your Game Info");
    }

    protected void btnGetColor_Click(object sender, RoutedEventArgs args)
    {
      string data = string.Empty;
      data += string.Format("SelectedIndex = {0}\n", lstColors.SelectedIndex);
      data += string.Format("SelectedItem = {0}\n", lstColors.SelectedItem);
      data += string.Format("SelectedValue = {0}", (lstColors.Items[lstColors.SelectedIndex] as StackPanel).Tag);
      MessageBox.Show(data, "Your Color Info");
    }
    #endregion 
  }
}