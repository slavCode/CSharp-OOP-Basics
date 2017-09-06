using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        this.FuelQuantity = Validator.ValidFueling(this.FuelQuantity, this.FuelConsumption + 1.6, distance, this.GetType().ToString());
        Console.WriteLine($"Truck travelled {distance} km");
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel * 0.95;
    }
}
