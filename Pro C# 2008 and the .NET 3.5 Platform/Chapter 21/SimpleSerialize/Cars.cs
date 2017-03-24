using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SimpleSerialize
{
  [Serializable]
  public class Car
  {
    public Radio theRadio = new Radio();
    public bool isHatchBack;
  }

  [Serializable, XmlRoot(Namespace = "http://www.intertech.com")]
  public class JamesBondCar : Car
  {
    [XmlAttribute]
    public bool canFly;
    [XmlAttribute]
    public bool canSubmerge;

    public JamesBondCar(bool skyWorthy, bool seaWorthy)
    {
      canFly = skyWorthy;
      canSubmerge = seaWorthy;
    }
    // The XmlSerializer demands a default constructor!
    public JamesBondCar() { }
  }
}
