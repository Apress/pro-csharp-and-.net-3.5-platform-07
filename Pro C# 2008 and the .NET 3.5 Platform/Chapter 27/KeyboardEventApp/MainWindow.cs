using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyboardEventApp
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void MainWindow_KeyUp(object sender, KeyEventArgs e)
    {
      Text = string.Format("Key Pressed: {0} Modifiers: {1}",
        e.KeyCode.ToString(), e.Modifiers.ToString());
    }
  }
}