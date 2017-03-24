// This program illustrates various ways to 
// create and manipulate array types. 
//
// Comment / uncomment method calls in Main()
// to test.

using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Arrays *****");
      SimpleArrays();
      ArrayInitialization();
      ArrayOfObjects();
      RectMultidimensionalArray();
      JaggedMultidimensionalArray();
      PassAndReceiveArrays();
      SystemArrayFunctionality();
      Console.ReadLine();
    }

    #region Helper methods
    static void SimpleArrays()
    {
      Console.WriteLine("=> Simple Array Creation.");
      // Create and fill an array of 3 Integers
      int[] myInts = new int[3];
      myInts[0] = 100;
      myInts[1] = 200;
      myInts[2] = 300;

      // Now print each value.
      foreach (int i in myInts)
        Console.WriteLine(i);
      Console.WriteLine();
    }

    static void ArrayInitialization()
    {
      Console.WriteLine("=> Array Initialization.");
      // Array initialization syntax using the new keyword.
      string[] stringArray = new string[] { "one", "two", "three" };
      Console.WriteLine("stringArray has {0} elements", stringArray.Length);

      // Array initialization syntax without using the new keyword.
      bool[] boolArray = { false, false, true };
      Console.WriteLine("boolArray has {0} elements", boolArray.Length);

      // Array initialization with new keyword and size.
      int[] intArray = new int[4] { 20, 22, 23, 0 };
      Console.WriteLine("intArray has {0} elements", intArray.Length);
      Console.WriteLine();
    }

    static void ArrayOfObjects()
    {
      Console.WriteLine("=> Array of Objects.");

      // An array of objects can be anything at all.
      object[] myObjects = new object[4];
      myObjects[0] = 10;
      myObjects[1] = false;
      myObjects[2] = new DateTime(1969, 3, 24);
      myObjects[3] = "Form & Void";

      foreach (object obj in myObjects)
      {
        // Print the type and value for each item in array.
        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
      }
      Console.WriteLine();
    }
    static void RectMultidimensionalArray()
    {
      Console.WriteLine("=> Rectangular multidimensional array.");
      // A rectangular MD array.
      int[,] myMatrix;
      myMatrix = new int[6, 6];

      // Populate (6 * 6) array.
      for (int i = 0; i < 6; i++)
        for (int j = 0; j < 6; j++)
          myMatrix[i, j] = i * j;

      // Print (6 * 6) array.
      for (int i = 0; i < 6; i++)
      {
        for (int j = 0; j < 6; j++)
          Console.Write(myMatrix[i, j] + "\t");
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    static void JaggedMultidimensionalArray()
    {
      Console.WriteLine("=> Jagged multidimensional array.");
      // A jagged MD array (i.e., an array of arrays).
      // Here we have an array of 5 different arrays.  
      int[][] myJagArray = new int[5][];

      // Create the jagged array.
      for (int i = 0; i < myJagArray.Length; i++)
        myJagArray[i] = new int[i + 7];

      // Print each row (remember, each element is defaulted to zero!)
      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < myJagArray[i].Length; j++)
          Console.Write(myJagArray[i][j] + " ");
        Console.WriteLine();
      }
      Console.WriteLine();
    }

    static void PrintArray(int[] myInts)
    {
      for (int i = 0; i < myInts.Length; i++)
        Console.WriteLine("Item {0} is {1}", i, myInts[i]);
    }

    static string[] GetStringArray()
    {
      string[] theStrings = { "Hello", "from", "GetStringArray" };
      return theStrings;
    }

    static void PassAndReceiveArrays()
    {
      Console.WriteLine("=> Arrays as params and return values.");
      int[] ages = { 20, 22, 23, 0 };
      PrintArray(ages);
      string[] strs = GetStringArray();
      foreach (string s in strs)
        Console.WriteLine(s);
      Console.WriteLine();
    }

    static void SystemArrayFunctionality()
    {
      Console.WriteLine("=> Working with System.Array.");
      // Initialize items at startup.
      string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

      // Print out names in declared order.
      Console.WriteLine(" -> Here is the array:");
      for (int i = 0; i <= gothicBands.GetUpperBound(0); i++)
      {
        // Print a name
        Console.Write(gothicBands[i] + " ");
      }
      Console.WriteLine("\n");

      // Reverse them...
      Array.Reverse(gothicBands);
      Console.WriteLine(" -> The reversed array");
      // ... and print them.
      for (int i = 0; i <= gothicBands.GetUpperBound(0); i++)
      {
        // Print a name
        Console.Write(gothicBands[i] + " ");
      }
      Console.WriteLine("\n");

      // Clear out all but the final member.
      Console.WriteLine(" -> Cleared out all but one...");
      Array.Clear(gothicBands, 1, 2);
      for (int i = 0; i <= gothicBands.GetUpperBound(0); i++)
      {
        // Print a name
        Console.Write(gothicBands[i] + " ");
      }
      Console.WriteLine();
    }
    #endregion
  }
}
