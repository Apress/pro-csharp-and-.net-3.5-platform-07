using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Data;
using System.Windows.Media;

namespace SimpleDataBinding
{
  class MyColorConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, 
      System.Globalization.CultureInfo culture)
    {
      double d = (double)value;
      byte v = (byte)d;

      Color color = new Color();
      color.A = 255;
      color.G = (byte) (155 + v);

      return new SolidColorBrush(color);
    }

    public object ConvertBack(object value, Type targetType, object parameter, 
      System.Globalization.CultureInfo culture)
    {
      return value;
    }
  }
}
