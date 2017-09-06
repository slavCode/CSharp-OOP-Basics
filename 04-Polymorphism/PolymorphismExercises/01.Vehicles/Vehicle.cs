public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;

    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }
    public double FuelQuantity
    {
        get => this.fuelQuantity;
        private set { this.fuelQuantity = value; }
    }

    public double FuelConsumption
    {
        get => this.fuelConsumption;
       protected set { this.fuelConsumption = value; }
    }

    public abstract void Drive(double distance);
    public abstract void Refuel(double fuel);
}
