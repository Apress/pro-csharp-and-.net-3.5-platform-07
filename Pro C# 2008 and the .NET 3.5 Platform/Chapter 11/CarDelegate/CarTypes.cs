#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarDelegate
{
  public class Car
  {
    // Define the delegate types.
    public delegate void AboutToBlow(string msg);
    public delegate void Exploded(string msg);

    // Define member variables of each delegate. 
    private AboutToBlow almostDeadList;
    private Exploded explodedList;

    // Add member to the invocation list.
    public void OnAboutToBlow(AboutToBlow clientMethod)
    { almostDeadList += clientMethod; }

    public void OnExploded(Exploded clientMethod)
    { explodedList += clientMethod; }

    // Remove member from the invocation list.
    public void RemoveAboutToBlow(AboutToBlow clientMethod)
    { almostDeadList -= clientMethod; }

    public void RemoveExploded(Exploded clientMethod)
    { explodedList -= clientMethod; }

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
        if (explodedList != null)
          explodedList("Sorry, this car is dead...");
      }
      else
      {
        currSpeed += delta;

        // Almost dead?
        if (10 == maxSpeed - currSpeed
          && almostDeadList != null)
        {
          almostDeadList("Careful buddy!  Gonna blow!");
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
