using System;
using System.Windows.Forms;

namespace CarLibrary
{
  #region SportsCar type
  public class SportsCar : Car
  {
    public SportsCar() { }
    public SportsCar(string name, int max, int curr)
      : base(name, max, curr) { }

    public override void TurboBoost()
    {
      MessageBox.Show("Ramming speed!", "Faster is better...");
    }
  }
  #endregion

  #region MiniVan type
  public class MiniVan : Car
  {
    public MiniVan() { }
    public MiniVan(string name, int max, int curr)
      : base(name, max, curr) { }

    public override void TurboBoost()
    {
      // Minivans have poor turbo capabilities!
      egnState = EngineState.engineDead;
      MessageBox.Show("Time to call AAA", "Your car is dead");
    }


    #region See Ch. 16 for info on this method...
    // Quiet down the troops...
    public void TellChildToBeQuiet(string kidName, int shameIntensity)
    {
      for (int i = 0; i < shameIntensity; i++)
        MessageBox.Show(string.Format("Be quiet {0}!!", kidName));
    }
    #endregion
  }
  #endregion
}
