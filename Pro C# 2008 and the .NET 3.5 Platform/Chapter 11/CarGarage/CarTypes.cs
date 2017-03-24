#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarGarage
{
  public class Car
  {
    // Define the Delegate types.
    public delegate void AboutToBlow(string msg);
    public delegate void Exploded(string msg);
    public delegate void CarMaintenanceDelegate(Car c);

    // Define member variables of each delegate. 
    private AboutToBlow almostDeadList;
    private Exploded explodedList;

    // Add member to the invocation list.
    public void OnAboutToBlow(AboutToBlow clientMethod)
    { almostDeadList += clientMethod; }

    public void OnExploded(Exploded clientMethod)
    { explodedList += clientMethod; }

    // Remove member to the invocation list.
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

    // NEW!  Are we in need of a wash?
    private bool isDirty;

    // NEW!  Are we in need of a wash?
    private bool shouldRotate;

    public Car()
    {
      maxSpeed = 100;
    }

    public Car(string name, int max, int curr, bool rotateTires, bool washCar)
    {
      currSpeed = curr;
      maxSpeed = max;
      petName = name;
      isDirty = washCar;
      shouldRotate = rotateTires;
    }

    public void CrankTunes(bool state)
    {
      theMusicBox.TurnOn(state);
    }

    public bool Dirty
    {
      get { return isDirty; }
      set { isDirty = value; }
    }

    public bool Rotate
    {
      get { return shouldRotate; }
      set { shouldRotate = value; }
    }
    #endregion

    public void Accelerate(int delta)
    {
      // If the car is dead, fire Exploded event.
      if (carIsDead && explodedList != null)
      {
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
  }
}
