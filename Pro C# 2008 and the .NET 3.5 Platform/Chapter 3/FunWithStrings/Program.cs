// This program illustrates working with the 
// System.String type.
//
// Comment / uncomment method calls in Main() 
// to test.

using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithStrings
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Strings *****");
      Console.WriteLine();
      BasicStringFunctionality();
      StringConcatenation();
      EscapeChars();
      StringEquality();
      StringAreImmutable();
      FunWithStringBuilder();
      Console.ReadLine();
    }

    #region Helper functions
    static void BasicStringFunctionality()
    {
      Console.WriteLine("=> Basic String functionality:");
      string firstName = "Freddy";
      Console.WriteLine("Value of firstName: {0}", firstName);
      Console.WriteLine("firstName has {0} characters.", firstName.Length);
      Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
      Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
      Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
      Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
      Console.WriteLine();
    }

    static void StringConcatenation()
    {
      Console.WriteLine("=> String concatenation:");
      string s1 = "Programming the ";
      string s2 = "PsychoDrill (PTP)";
      string s3 = string.Concat(s1, s2);
      Console.WriteLine(s3);
      Console.WriteLine();
    }

    static void EscapeChars()
    {
      Console.WriteLine("=> Escape characters:\a");
      string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
      Console.WriteLine(strWithTabs);

      Console.WriteLine("Everyone loves \"Hello World\"\a");
      // The following string is printed verbatim 
      // thus, all escape characters are displayed.
      Console.WriteLine(@"C:\MyApp\bin\Debug\a");

      // White space is preserved with verbatim strings.
      string myLongString = @"This is a very
                 very 
                      very 
                           long string";
      Console.WriteLine(myLongString);

      Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

      // Adds a total of 4 blank lines (then beep again!).
      Console.WriteLine("All finished.\n\n\n\a");
      Console.WriteLine();
    }

    static void StringEquality()
    {
      Console.WriteLine("=> String equality:");
      string s1 = "Hello!";
      string s2 = "Yo!";
      Console.WriteLine("s1 = {0}", s1);
      Console.WriteLine("s2 = {0}", s2);
      Console.WriteLine();
 
      // Test these strings for equality.
      Console.WriteLine("s1 == s2: {0}", s1 == s2);
      Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
      Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
      Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
      Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
      Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
      Console.WriteLine();
    }

    static void StringAreImmutable()
    {
      Console.WriteLine("=> String are immutable:");
      // Set initial string value.
      string s1 = "This is my string.";
      Console.WriteLine("s1 = {0}", s1);

      // Uppercase the s1?
      string upperString = s1.ToUpper();
      Console.WriteLine("upperString = {0}", upperString);

      // Nope!  s1 is in the same format!
      Console.WriteLine("s1 = {0}", s1);

      string s2 = "My other string";
      s2 = "New string value";
      Console.WriteLine();
    }

    static void FunWithStringBuilder()
    {
      Console.WriteLine("=> Using the StringBuilder:");
      StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
      sb.Append("\n");
      sb.AppendLine("Half Life");
      sb.AppendLine("Beyond Good and Evil");
      sb.AppendLine("Deus Ex 2");
      sb.AppendLine("System Shock");
      Console.WriteLine(sb.ToString());

      sb.Replace("2", "Invisible War");
      Console.WriteLine(sb.ToString());
      Console.WriteLine("sb as {0} chars.", sb.Length);
      Console.WriteLine();
    }
    #endregion
  }
}
