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

namespace WPFGraphicsOptions
{  
  public partial class MainWindow : System.Windows.Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }
  }

  #region Rectangles, the long way...
  /*
  public partial class MainWindow : System.Windows.Window
  {
    // Our drawing visual. 
    private DrawingVisual rectVisual = new DrawingVisual();
    private const int NumberOfVisualItems = 1;

    public MainWindow()
    {
      InitializeComponent();
      CreateRectVisual();
    }

    private void CreateRectVisual()
    {
      using (DrawingContext drawCtx = rectVisual.RenderOpen())
      {
        // The top, left, bottom, right position of the rectangle. 
        Rect rect = new Rect(50, 50, 105, 55);
        drawCtx.DrawRectangle(Brushes.AliceBlue, new Pen(Brushes.Blue, 5), rect);
      }

      // Register our visual w/ the object tree,
      // to ensure it supports routed events, hit testing, etc.
      AddVisualChild(rectVisual);
      AddLogicalChild(rectVisual);
    }

    // Necessary overrides.  The WPF graphics system
    // will call these to figure out how many items to 
    // render and what to render. 
    protected override int VisualChildrenCount
    {
      get { return NumberOfVisualItems; }
    }

    protected override Visual GetVisualChild(int index)
    {
      // Collection is zero based, so subtract 1.
      if (index != (NumberOfVisualItems - 1))
        throw new ArgumentOutOfRangeException("index", "Don't have that visual!");
      return rectVisual;
    }
  }
  */
  #endregion
}