#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarEvents
{
  public class Car
  {
    // This delegate works in conjunction with the
    // Car’s events.
    public delegate void CarEventHandler(string msg);

    // This car can send these events.
    public event CarEventHandler Exploded;
    public event CarEventHandler AboutToBlow;

    #region Basic Car members...

    #region Nested radio
    // Radio as nested type
    public class Radio
    {
      public void TurnOn(bool on)
      {
        if (on)
          Console.WriteLine("Jamming...");
        else
          Console.WriteLine("Quiet time...");
      }
    }
    #endregion

    // Internal state data.
    private int currSpeed;
    private int maxSpeed;
    private string petName;

    // Is the car alive or dead?
    bool carIsDead;

    // A car has-a radio.
    private Radio theMusicBox = new Radio();

    public Car()
    {
      maxSpeed = 100;
    }

    public Car(string name, int max, int curr)
    {
      currSpeed = curr;
      maxSpeed = max;
      petName = name;
    }

    public void CrankTunes(bool state)
    {
      theMusicBox.TurnOn(state);
    }
    #endregion

    #region Accelerate method
    public void Accelerate(int delta)
    {
      // If the car is dead, fire Exploded event.
      if (carIsDead)
      {
        if (Exploded != null)
          Exploded("Sorry, this car is dead...");
      }
      else
      {
        currSpeed += delta;

        // Almost dead?
        if (10 == maxSpeed - currSpeed
          && AboutToBlow != null)
        {
          AboutToBlow("Careful buddy!  Gonna blow!");
        }

        // Still OK!
        if (currSpeed >= maxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("->CurrSpeed = {0}", currSpeed);
      }
    }
    #endregion

  }
}
