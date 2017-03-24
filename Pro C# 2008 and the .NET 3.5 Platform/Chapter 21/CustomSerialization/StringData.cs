using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CustomSerialization
{
  [Serializable]
  class StringData : ISerializable
  {
    public string dataItemOne = "First data block";
    public string dataItemTwo= "More data";

    public StringData() { }
    protected StringData(SerializationInfo si, StreamingContext ctx)
    {
      // Rehydrate member variables from stream.
      dataItemOne = si.GetString("First_Item").ToLower();
      dataItemTwo = si.GetString("dataItemTwo").ToLower();
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx)
    {
      // Fill up the SerializationInfo object with the formatted data.
      info.AddValue("First_Item", dataItemOne.ToUpper());
      info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
    }
  }
}
