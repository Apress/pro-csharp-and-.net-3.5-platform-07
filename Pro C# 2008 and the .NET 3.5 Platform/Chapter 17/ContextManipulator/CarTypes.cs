using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Contexts;  // For Context type.
using System.Threading;  // For Thread type.

namespace ContextManipulator
{

  // SportsCar has no special contextual
  // needs and will be loaded into the 
  // default context of the app domain.
  class SportsCar
  {
    public SportsCar()
    {
      // Get context information and print out context ID.
      Context ctx = Thread.CurrentContext;
      Console.WriteLine("{0} object in context {1}",
        this.ToString(), ctx.ContextID);
      foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
        Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
    }
  }

  // SportsCarTS demands to be loaded in 
  // a synchronization context.
  [Synchronization]
  class SportsCarTS : ContextBoundObject
  {
    public SportsCarTS()
    {
      // Get context information and print out context ID.
      Context ctx = Thread.CurrentContext;
      Console.WriteLine("{0} object in context {1}",
        this.ToString(), ctx.ContextID);
      foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
        Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
    }
  }
}
