using System;
using System.Collections.Generic;
using System.Text;

namespace PreprocessorDirectives
{
class Car
{
  private string petName;
  private int currSp;

  #region Constructors
  public Car()
  {}
  public Car(int currSp, string petName)
  {}
  #endregion

  #region Properties
  public int Speed 
  {
    get {return currSp;}
    set { currSp = value;}
  }
  public string Name
  {
    get { return petName; }
    set { petName = value; }
  }
  #endregion
}

}
