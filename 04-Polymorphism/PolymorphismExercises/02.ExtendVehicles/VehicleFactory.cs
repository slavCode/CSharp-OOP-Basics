public class VehicleFactory
{
    public Vehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        switch (type)
        {
            case "Car":
                return new Car(fuelQuantity, fuelConsumption, tankCapacity);
            case "Truck":
                return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            case "Bus":
                return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
        }

        return null;
    }
}
