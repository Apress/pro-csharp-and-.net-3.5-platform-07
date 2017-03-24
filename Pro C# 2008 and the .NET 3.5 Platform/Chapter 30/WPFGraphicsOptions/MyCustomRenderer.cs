using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace WPFGraphicsOptions
{
  public class MyCustomRenderer : FrameworkElement 
  {
    double rectWidth = 105, rectHeight = 55;

    public double RectHeight
    {
      set { rectHeight = value; }
      get { return rectHeight; }
    }
    public double RectWidth
    {
      set { rectWidth = value; }
      get { return rectWidth; }
    }

    protected override void OnRender(DrawingContext drawCtx)
    {
      // Do parent rendering.
      base.OnRender(drawCtx);

      // Add our custom rendering.
      Rect rect = new Rect();
      rect.Width = rectWidth;
      rect.Height = rectHeight;
      drawCtx.DrawRectangle(Brushes.LightBlue, new Pen(Brushes.Blue, 5), rect);
    }
  }
}
