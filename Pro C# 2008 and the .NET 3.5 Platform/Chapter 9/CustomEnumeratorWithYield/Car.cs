using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEnumeratorWithYield
{
  public class Car
  {
    #region Member variables & Constructors
    // Constant for maximum speed.
    public const int MaxSpeed = 100;

    // Internal state data.
    private int currSpeed;
    private string petName;

    // Is the car still operational?
    private bool carIsDead;

    // A car has-a radio.
    private Radio theMusicBox = new Radio();

    // Constructors.
    public Car() {}
    public Car(string name, int currSp)
    {
      currSpeed = currSp;
      petName = name;
    }
    #endregion

    #region Properties
    public int Speed
    {
      get { return currSpeed; }
      set { currSpeed = value; }
    }
    public string PetName
    {
      get { return petName; }
      set { petName = value; }
    }	
    #endregion

    #region Methods
    public void CrankTunes(bool state)
    {
      // Delegate request to inner object.
      theMusicBox.TurnOn(state);
    }

    // This time, throw an exception if the user speeds up beyond MaxSpeed.
    public void Accelerate(int delta)
    {
      if (carIsDead)
        Console.WriteLine("{0} is out of order...", petName);
      else
      {
        currSpeed += delta;
        if (currSpeed >= MaxSpeed)
        {
          carIsDead = true;
          currSpeed = 0;

          // We need to call the HelpLink property, thus we need
          // to create a local variable before throwing the Exception object.
          Exception ex =
            new Exception(string.Format("{0} has overheated!", petName));
          ex.HelpLink = "http://www.CarsRUs.com";

          // Stuff in custom data regarding the error.
          ex.Data.Add("TimeStamp",
            string.Format("The car exploded at {0}", DateTime.Now));
          ex.Data.Add("Cause", "You have a lead foot.");
          throw ex;
        }
        else
          Console.WriteLine("=> CurrSpeed = {0}", currSpeed);
      }
    }
    #endregion
  }
}
