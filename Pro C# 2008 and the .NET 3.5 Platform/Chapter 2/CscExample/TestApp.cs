using System;

// Don't need this anymore.
// using System.Windows.Forms;

class TestApp
{
  public static void Main()
  {
    Console.WriteLine("Testing! 1, 2, 3");

    // Don't need this anymore either.
    // MessageBox.Show("Hello...");
        
    // Exercise the HelloMessage class! 
    HelloMessage h = new HelloMessage();
    h.Speak();
  }
}
