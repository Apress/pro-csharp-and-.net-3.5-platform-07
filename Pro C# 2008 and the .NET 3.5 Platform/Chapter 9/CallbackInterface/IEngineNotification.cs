using System;
using System.Collections.Generic;
using System.Text;

namespace CallbackInterface
{
  public interface IEngineNotification
  {
    void AboutToBlow(string msg);
    void Exploded(string msg);
  }
}
