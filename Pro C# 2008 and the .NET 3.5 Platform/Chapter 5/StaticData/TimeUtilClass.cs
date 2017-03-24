using System;
using System.Collections.Generic;
using System.Text;

namespace StaticData
{
  // Static classes can only 
  // contain static members and constant fields.
  static class TimeUtilClass
  {
    public static void PrintTime()
    { Console.WriteLine(DateTime.Now.ToShortTimeString()); }
    public static void PrintDate()
    { Console.WriteLine(DateTime.Today.ToShortDateString()); }
  }
}
