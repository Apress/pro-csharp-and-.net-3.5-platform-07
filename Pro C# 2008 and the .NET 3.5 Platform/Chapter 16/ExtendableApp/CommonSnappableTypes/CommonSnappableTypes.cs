using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSnappableTypes
{
  public interface IAppFunctionality
  {
    void DoIt();
  }

  [AttributeUsage(AttributeTargets.Class)]
  public sealed class CompanyInfoAttribute : System.Attribute
  {
    private string companyName;
    private string companyUrl;
    public CompanyInfoAttribute() { }

    public string Name
    {
      get { return companyName; }
      set { companyName = value; }
    }

    public string Url
    {
      get { return companyUrl; }
      set { companyUrl = value; }
    }
  }
}
