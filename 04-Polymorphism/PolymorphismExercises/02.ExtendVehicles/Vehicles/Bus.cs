using System;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        this.FuelQuantity = Validator.ValidFueling(this.FuelQuantity, this.FuelConsumption + 1.4, distance, this.GetType().ToString());
        Console.WriteLine($"Bus travelled {distance} km");
    }

    public override void DriveEmptyBus(double distance)
    {
        this.FuelQuantity = Validator.ValidFueling(this.FuelQuantity, this.FuelConsumption, distance, this.GetType().ToString());
        Console.WriteLine($"Bus travelled {distance} km");
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity = Validator.ValidFuelFilledUp(this.FuelQuantity, fuel, this.TankCapacity);
    }
}
