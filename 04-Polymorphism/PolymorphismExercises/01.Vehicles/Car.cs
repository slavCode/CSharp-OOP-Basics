using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
    }

    public override void Drive(double distance)
    {
        if (this.FuelQuantity < (this.FuelConsumption + 0.9) * distance)
        {
            throw new ArgumentException("Car needs refueling");
        }

        this.FuelQuantity -= (this.FuelConsumption + 0.9) * distance;
        Console.WriteLine($"Car travelled {distance} km");
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }
}
