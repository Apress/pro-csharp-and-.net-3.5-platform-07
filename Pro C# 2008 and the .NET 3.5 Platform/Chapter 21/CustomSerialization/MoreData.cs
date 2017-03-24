using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CustomSerialization
{
  [Serializable]
  class MoreData
  {
    public string dataItemOne = "First data block";
    public string dataItemTwo = "More data";

    [OnSerializing]
    private void OnSerializing(StreamingContext context)
    {
      // Called during the serialization process.
      dataItemOne = dataItemOne.ToUpper();
      dataItemTwo = dataItemTwo.ToUpper();
    }

    [OnDeserialized]
    private void OnDeserialized(StreamingContext context)
    {
      // Called once the deserialization process is complete.
      dataItemOne = dataItemOne.ToLower();
      dataItemTwo = dataItemTwo.ToLower();
    }
  }
}
