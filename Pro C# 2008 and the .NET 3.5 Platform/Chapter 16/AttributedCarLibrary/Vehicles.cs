using System;
using System.Collections.Generic;
using System.Text;

// Enforce CLS compliance for all public types in this assembly.
[assembly: System.CLSCompliantAttribute(true)]

namespace AttributedCarLibrary
{
  // Assign description using a 'named property'.
  [Serializable]
  [VehicleDescription(Description = "My rocking Harley")]
  public class Motorcycle
  {
  }

  [SerializableAttribute]
  [ObsoleteAttribute("Use another vehicle!")]
  [VehicleDescription("The old gray mare, she ain't what she used to be...")]
  public class HorseAndBuggy
  {
  }

  [VehicleDescription("A very long, slow, but feature-rich auto")]
  public class Winnebago
  {
    // Not CLS compliant!
    public ulong notCompliant;
  }
}
