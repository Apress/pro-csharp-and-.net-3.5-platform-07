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


namespace MySpellChecker
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();
      SetF1CommandBinding();
    }

    #region Menu Handlers
    protected void FileExit_Click(object sender, RoutedEventArgs args)
    {
      // Terminate the application.
      Application.Current.Shutdown();
    }
    protected void ToolsSpellingHints_Click(object sender, RoutedEventArgs args)
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

        // Show suggestions and expand the expander.
        lblSpellingHints.Content = spellingHints;
        expanderSpelling.IsExpanded = true;
      }
    }
    protected void MouseEnterExitArea(object sender, RoutedEventArgs args)
    {
      statBarText.Text = "Exit the Application";
    }
    protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs args)
    {
      statBarText.Text = "Show Spelling Suggestions";
    }
    protected void MouseLeaveArea(object sender, RoutedEventArgs args)
    {
      statBarText.Text = "Ready";
    }
    #endregion

    #region Logic for rigging up F1 help for the window
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
      MessageBox.Show("Dude, it is not that difficult.  Just type something!", "Help!");
    }
    #endregion
  }
}