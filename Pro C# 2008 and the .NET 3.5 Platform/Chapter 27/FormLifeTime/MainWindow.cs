using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormLifeTime
{
  public partial class MainWindow : Form
  {
    private string lifeTimeInfo = string.Empty;

    public MainWindow()
    {
      InitializeComponent();

      // Handle various lifetime events.
      Closing += new CancelEventHandler(MainWindow_Closing);
      Load += new EventHandler(MainWindow_Load);
      Closed += new EventHandler(MainWindow_Closed);
      Activated += new EventHandler(MainWindow_Activated);
      Deactivate += new EventHandler(MainWindow_Deactivate);
    }

    #region Form events
    private void MainWindow_Load(object sender, System.EventArgs e)
    { 
      lifeTimeInfo += "Load event\n"; 
    }
    
    private void MainWindow_Activated(object sender, System.EventArgs e)
    { 
      lifeTimeInfo += "Activate event\n"; 
    }
    
    private void MainWindow_Deactivate(object sender, System.EventArgs e)
    { 
      lifeTimeInfo += "Deactivate event\n"; 
    }
    
    private void MainWindow_Closed(object sender, System.EventArgs e)
    {
      lifeTimeInfo += "Closed event\n";
      MessageBox.Show(lifeTimeInfo);
    }
    
    void MainWindow_Closing(object sender, CancelEventArgs e)
    {
      lifeTimeInfo += "Closing event\n"; 
      DialogResult dr = MessageBox.Show("Do you REALLY want to close this app?",
          "Closing event!", MessageBoxButtons.YesNo);
      if (dr == DialogResult.No)
        e.Cancel = true;
      else
        e.Cancel = false;
    }
    #endregion
  }
}