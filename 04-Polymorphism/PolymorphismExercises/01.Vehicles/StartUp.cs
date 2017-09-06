using System;

public class StartUp
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var carFuelQuantity = double.Parse(carInfo[1]);
        var carFuelConsumption = double.Parse(carInfo[2]);
        var car = new Car(carFuelQuantity, carFuelConsumption);

        var truckInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var truckFuelQuantity = double.Parse(truckInfo[1]);
        var truckFuelConsumption = double.Parse(truckInfo[2]);
        var truck = new Truck(truckFuelQuantity, truckFuelConsumption);


        var numberOfCmd = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCmd; i++)
        {
            var cmdInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var cmd = cmdInfo[0];
            var type = cmdInfo[1];
            var parameter = double.Parse(cmdInfo[2]);

            try
            {
                if (type == "Car")
                {
                    var simulation = new VehicleSimulation();
                    simulation.Simulate(cmd, car, parameter);
                }

                else if (type == "Truck")
                {
                    var simulation = new VehicleSimulation();
                    simulation.Simulate(cmd, truck, parameter);
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        Console.WriteLine($"Car: {car.FuelQuantity:F2}\nTruck: {truck.FuelQuantity:F2}");
    }
}
