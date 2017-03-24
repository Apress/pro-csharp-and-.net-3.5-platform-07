using System;
using System.Windows.Forms;

namespace CarLibrary
{
  // Represents the state of the engine.
  public enum EngineState
  { engineAlive, engineDead }

  // Represents music options.
  public enum MusicMedia
  {
    musicCd,
    musicTape,
    musicRadio,
    musicMp3
  }

  // The abstract base class in the hierarchy.
  public abstract class Car
  {
    protected string petName;
    protected int currSpeed;
    protected int maxSpeed;
    protected EngineState egnState = EngineState.engineAlive;

    public abstract void TurboBoost();

    // This is a new method for CarLibrary.dll 2.0!
    public void TurnOnRadio(bool musicOn, MusicMedia mm)
    {
      if (musicOn)
        MessageBox.Show(string.Format("Jamming {0}", mm));
      else
        MessageBox.Show("Quiet time...");
    }

    #region Constructors
    public Car()
    {
      MessageBox.Show("CarLibrary Version 2.0!");
    }
    public Car(string name, int max, int curr)
    {
      MessageBox.Show("CarLibrary Version 2.0!");
      petName = name; maxSpeed = max; currSpeed = curr;
    }
    #endregion

    #region Properties
    public string PetName
    {
      get { return petName; }
      set { petName = value; }
    }
    public int CurrSpeed
    {
      get { return currSpeed; }
      set { currSpeed = value; }
    }
    public int MaxSpeed
    { get { return maxSpeed; } }
    public EngineState EngineState
    { get { return egnState; } }
    #endregion
  }
}
