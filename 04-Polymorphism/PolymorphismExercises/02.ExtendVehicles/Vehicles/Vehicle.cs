using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        protected set { this.fuelQuantity = value; }
    }

    public double FuelConsumption
    {
        get => this.fuelConsumption;
        private set { this.fuelConsumption = value; }
    }

    public double TankCapacity
    {
        get => this.tankCapacity;
        private set { this.tankCapacity = value; }
    }

    public abstract void Drive(double distance);
    public abstract void Refuel(double fuel);

    public virtual void DriveEmptyBus(double distance)
    {
    }

}
