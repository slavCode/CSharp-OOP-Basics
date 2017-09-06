using System;

public static class Validator
{
    public static double ValidFueling(double fuelQuantity, double fuelConsumption, double distance, string type)
    {
        if (fuelQuantity < fuelConsumption * distance)
        {
            throw new ArgumentException($"{type} needs refueling");
        }

        return fuelQuantity - fuelConsumption * distance;
    }

    public static double ValidFuelFilledUp(double fuelQuantity, double fuel, double tankCapacity)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        else if (fuelQuantity + fuel > tankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }

        return fuelQuantity + fuel;
    }
}
