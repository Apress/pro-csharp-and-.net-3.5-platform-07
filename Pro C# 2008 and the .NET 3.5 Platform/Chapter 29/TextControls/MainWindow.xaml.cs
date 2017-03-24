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


namespace TextControls
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>

  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    #region Button click logic
    protected void btnOK_Click(object sender, RoutedEventArgs args)
    {
      if (CheckPassword())
      {
        string spellingHints = string.Empty;

        // Try to get a spelling error at the current caret location.
        SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);
        if (error != null)
        {
          // Build a string of spelling suggestions.
          foreach (string s in error.Suggestions)
          {
            spellingHints += string.Format("{0}\n", s);

          }

          // Show suggestions.
          MessageBox.Show(spellingHints, "Try these instead");
        }
      }
      else
        MessageBox.Show("Security error!!");
    }
    #endregion

    private bool CheckPassword()
    {
      if (pwdText.Password == "Chucky")
        return true;
      else
        return false;
    }
  }
}