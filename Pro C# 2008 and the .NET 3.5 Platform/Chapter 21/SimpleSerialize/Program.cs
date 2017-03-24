using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// For the formatters.
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace SimpleSerialize
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Object Serialization *****\n");

      // Make a JamesBondCar and set state.
      JamesBondCar jbc = new JamesBondCar();
      jbc.canFly = true;
      jbc.canSubmerge = false;
      jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
      jbc.theRadio.hasTweeters = true;

      // Now save / Load the car to a specific file.
      SaveAsBinaryFormat(jbc, "CarData.dat");
      LoadFromBinaryFile("CarData.dat");
      SaveAsSoapFormat(jbc, "CarData.soap");
      SaveAsXmlFormat(jbc, "CarData.xml");
      SaveListOfCars();
      SaveListOfCarsAsBinary();

      Console.ReadLine();
    }

    #region Save / Load as Binary Format
    static void SaveAsBinaryFormat(object objGraph, string fileName)
    {
      // Save object to a file named CarData.dat in binary.
      BinaryFormatter binFormat = new BinaryFormatter();

      using (Stream fStream = new FileStream(fileName,
            FileMode.Create, FileAccess.Write, FileShare.None))
      {
        binFormat.Serialize(fStream, objGraph);
      }
      Console.WriteLine("=> Saved car in binary format!");
    }

    static void LoadFromBinaryFile(string fileName)
    {
      BinaryFormatter binFormat = new BinaryFormatter();

      // Read the JamesBondCar from the binary file.
      using (Stream fStream = File.OpenRead(fileName))
      {
        JamesBondCar carFromDisk =
          (JamesBondCar)binFormat.Deserialize(fStream);
        Console.WriteLine("Can this car fly? : {0}", carFromDisk.canFly);
      }
    }
    #endregion

    #region Save as SOAP Format
    // Be sure to import System.Runtime.Serialization.Formatters.Soap 
    // and reference System.Runtime.Serialization.Formatters.Soap.dll.
    static void SaveAsSoapFormat(object objGraph, string fileName)
    {
      // Save object to a file named CarData.soap in SOAP format.
      SoapFormatter soapFormat = new SoapFormatter();

      using (Stream fStream = new FileStream(fileName,
        FileMode.Create, FileAccess.Write, FileShare.None))
      {
        soapFormat.Serialize(fStream, objGraph);
      }
      Console.WriteLine("=> Saved car in SOAP format!");
    }
    #endregion

    #region Save as XML Format
    static void SaveAsXmlFormat(object objGraph, string fileName)
    {
      // Save object to a file named CarData.xml in XML format.
      XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar),
        new Type[] { typeof(Radio), typeof(Car) });

      using (Stream fStream = new FileStream(fileName,
        FileMode.Create, FileAccess.Write, FileShare.None))
      {
        xmlFormat.Serialize(fStream, objGraph);
      }
      Console.WriteLine("=> Saved car in XML format!");
    }
    #endregion

    #region Save collection of cars
    static void SaveListOfCars()
    {
      // Now persist a List<> of JamesBondCars.
      List<JamesBondCar> myCars = new List<JamesBondCar>();
      myCars.Add(new JamesBondCar(true, true));
      myCars.Add(new JamesBondCar(true, false));
      myCars.Add(new JamesBondCar(false, true));
      myCars.Add(new JamesBondCar(false, false));

      using (Stream fStream = new FileStream("CarCollection.xml",
        FileMode.Create, FileAccess.Write, FileShare.None))
      {
        XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>),
          new Type[] { typeof(JamesBondCar), typeof(Car), typeof(Radio) });
        xmlFormat.Serialize(fStream, myCars);
      }
      Console.WriteLine("=> Saved list of cars!");
    }

    static void SaveListOfCarsAsBinary()
    {
      // Save ArrayList object (myCars) as binary.
      List<JamesBondCar> myCars = new List<JamesBondCar>();

      BinaryFormatter binFormat = new BinaryFormatter();
      using (Stream fStream = new FileStream("AllMyCars.dat",
        FileMode.Create, FileAccess.Write, FileShare.None))
      {
        binFormat.Serialize(fStream, myCars);
      }
      Console.WriteLine("=> Saved list of cars in binary!");
    }
    #endregion
  }
}
