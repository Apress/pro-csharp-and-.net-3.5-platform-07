using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

[WebService(Namespace = "http://intertech.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class MathService : System.Web.Services.WebService
{
  public MathService() { }

  [WebMethod]
  public int Add(int x, int y)
  { return x + y; }
  [WebMethod]
  public int Subtract(int x, int y)
  { return x - y; }
  [WebMethod]
  public int Multiply(int x, int y)
  { return x * y; }
  [WebMethod]
  public int Divide(int x, int y)
  {
    if (y == 0)
      return 0;
    else
      return x / y;
  }
}
