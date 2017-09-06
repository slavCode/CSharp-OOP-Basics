using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
    }

    public override void Drive(double distance)
    {
        if (this.FuelQuantity < (this.FuelConsumption + 1.6) * distance)
        {
            throw new ArgumentException("Truck needs refueling");
        }

        this.FuelQuantity -= (this.FuelConsumption + 1.6) * distance;
        Console.WriteLine($"Truck travelled {distance} km");
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel * 0.95;
    }
}
