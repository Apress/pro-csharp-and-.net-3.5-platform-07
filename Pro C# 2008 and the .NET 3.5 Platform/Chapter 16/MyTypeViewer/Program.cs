using System;
using System.Collections.Generic;
using System.Text;

using System.Reflection;

namespace MyTypeViewer
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Welcome to MyTypeViewer *****");
      string typeName = "";
      bool userIsDone = false;

      do
      {
        Console.WriteLine("\nEnter a type name to evaluate");
        Console.Write("or enter Q to quit: ");

        // Get name of type.
        typeName = Console.ReadLine();

        // Does user want to quit?
        if (typeName.ToUpper() == "Q")
        {
          userIsDone = true;
          break;
        }

        #region Try to display type.
        try
        {
          Type t = Type.GetType(typeName);
          Console.WriteLine("");
          ListVariousStats(t);
          ListFields(t);
          ListProps(t);
          ListMethods(t);
          ListInterfaces(t);
        }
        catch
        {
          Console.WriteLine("Sorry, can't find type");
        }
        #endregion

      } while (!userIsDone);
    }

    #region Helper methods
    // Display method names of type.
    public static void ListMethods(Type t)
    {
      Console.WriteLine("***** Methods *****");
      MethodInfo[] mi = t.GetMethods();
      foreach (MethodInfo m in mi)
      {
        //// Get return value.
        //string retVal = m.ReturnType.FullName;
        //string paramInfo = "(";

        //// Get params.
        //foreach (ParameterInfo pi in m.GetParameters())
        //{
        //  paramInfo += string.Format("{0} {1} ", pi.ParameterType, pi.Name);
        //}
        //paramInfo += ")";

        //// Now display the basic method sig.
        //Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo);
        Console.WriteLine(m.ToString());
      }
      Console.WriteLine();
    }

    // Display field names of type.
    static void ListFields(Type t)
    {
      Console.WriteLine("***** Fields *****");
      FieldInfo[] fi = t.GetFields();
      foreach (FieldInfo field in fi)
        Console.WriteLine("->{0}", field.Name);
      Console.WriteLine();
    }

    // Display property names of type.
    static void ListProps(Type t)
    {
      Console.WriteLine("***** Properties *****");
      PropertyInfo[] pi = t.GetProperties();
      foreach (PropertyInfo prop in pi)
        Console.WriteLine("->{0}", prop.Name);
      Console.WriteLine();
    }

    // Display implemented interfaces.
    static void ListInterfaces(Type t)
    {
      Console.WriteLine("***** Interfaces *****");
      Type[] ifaces = t.GetInterfaces();
      foreach (Type i in ifaces)
        Console.WriteLine("->{0}", i.Name);
    }

    // Just for good measure.
    static void ListVariousStats(Type t)
    {
      Console.WriteLine("***** Various Statistics *****");
      Console.WriteLine("Base class is: {0}", t.BaseType);
      Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
      Console.WriteLine("Is type sealed? {0}", t.IsSealed);
      Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
      Console.WriteLine("Is type a class type? {0}", t.IsClass);
      Console.WriteLine();
    }
    #endregion
  }
}
