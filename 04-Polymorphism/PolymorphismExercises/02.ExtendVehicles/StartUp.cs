using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var vehicles = new List<Vehicle>();
        for (int i = 0; i < 3; i++)
        {
            var vehicleInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var vehicleType = vehicleInfo[0];
            var vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
            var vehicleFuelConsumption = double.Parse(vehicleInfo[2]);
            var vehicleTankCapacity = double.Parse(vehicleInfo[3]);
            var vehiclePrimary = new VehicleFactory();
            var vehicle = vehiclePrimary.CreateVehicle(vehicleType, vehicleFuelQuantity, vehicleFuelConsumption, vehicleTankCapacity);
            vehicles.Add(vehicle);
        }

        var numberOfCmd = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCmd; i++)
        {
            var cmdInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var cmd = cmdInfo[0];
            var type = cmdInfo[1];
            var parameter = double.Parse(cmdInfo[2]);
            var vehicle = vehicles.First(v => v.GetType() == Type.GetType(type));

            try
            {
                var simulation = new VehicleSimulation();
                simulation.Simulate(cmd, vehicle, parameter);
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        var car = vehicles.First(v => v.GetType() == Type.GetType("Car"));
        var truck = vehicles.First(v => v.GetType() == Type.GetType("Truck"));
        var bus = vehicles.First(v => v.GetType() == Type.GetType("Bus"));

        Console.WriteLine($"Car: {car.FuelQuantity:F2}\nTruck: {truck.FuelQuantity:F2}\nBus: {bus.FuelQuantity:F2}");
    }
}
