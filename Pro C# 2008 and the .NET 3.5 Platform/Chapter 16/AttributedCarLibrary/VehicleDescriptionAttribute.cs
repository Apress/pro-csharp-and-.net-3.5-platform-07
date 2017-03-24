using System;
using System.Collections.Generic;
using System.Text;

namespace AttributedCarLibrary
{
  // A custom attribute.
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
   AllowMultiple = false, Inherited = false)]
  public sealed class VehicleDescriptionAttribute : System.Attribute
  {
    private string msgData;

    public VehicleDescriptionAttribute(string description)
    { msgData = description; }
    public VehicleDescriptionAttribute() { }

    public string Description
    {
      get { return msgData; }
      set { msgData = value; }
    }
  }
}
