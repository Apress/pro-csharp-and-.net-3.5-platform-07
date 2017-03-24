using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseEventsApp
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    #region Mouse event handlers
    private void MainWindow_MouseMove(object sender, MouseEventArgs e)
    {
      Text = string.Format("Mouse Position: {0}", e.Location);
    }

    private void MainWindow_MouseUp(object sender, MouseEventArgs e)
    {
      // Which mouse button was clicked?
      if (e.Button == MouseButtons.Left)
        MessageBox.Show("Left click!");
      if (e.Button == MouseButtons.Right)
        MessageBox.Show("Right click!");
      if (e.Button == MouseButtons.Middle)
        MessageBox.Show("Middle click!");
    }
    #endregion
  }
}