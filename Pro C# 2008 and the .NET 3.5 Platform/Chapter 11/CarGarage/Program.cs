#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarGarage
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Delegates as Parameters *****\n");

			// Make the garage.
			Garage g = new Garage();

			// Make the service department.
			ServiceDepartment sd = new ServiceDepartment();

			// Wash all dirty cars.
			g.ProcessCars(new Car.CarMaintenanceDelegate(sd.WashCar));

			// Rotate the tires.
			g.ProcessCars(new Car.CarMaintenanceDelegate(sd.RotateTires));

			Console.ReadLine();
		}
	}
}
