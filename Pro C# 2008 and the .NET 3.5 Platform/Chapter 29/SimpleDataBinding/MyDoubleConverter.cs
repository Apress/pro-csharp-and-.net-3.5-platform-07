using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Data;

namespace SimpleDataBinding
{
  class MyDoubleConverter : IValueConverter 
  {
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      // Convert the double to an int.
      double v = (double)value;
      return (int)v;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      // Return the incoming value directly.
      // this will be used for 2-way bindings.
      // In our example, when the user tabs
      // of the TextBlock.
      return value;
    } 
  }
}
