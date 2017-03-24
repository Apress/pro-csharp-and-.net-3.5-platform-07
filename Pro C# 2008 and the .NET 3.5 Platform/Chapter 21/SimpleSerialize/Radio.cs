using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSerialize
{
  [Serializable]
  public class Radio
  {
    public bool hasTweeters;
    public bool hasSubWoofers;
    public double[] stationPresets;

    [NonSerialized]
    public string radioID = "XF-552RR6";
  }
}
