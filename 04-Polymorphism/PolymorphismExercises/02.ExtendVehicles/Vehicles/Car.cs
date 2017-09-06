using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        this.FuelQuantity = Validator.ValidFueling(this.FuelQuantity, this.FuelConsumption + 0.9, distance, this.GetType().ToString());
        Console.WriteLine($"Car travelled {distance} km");
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity = Validator.ValidFuelFilledUp(this.FuelQuantity, fuel, this.TankCapacity);
    }
}
