namespace SpeedRacing
{
    using System;
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelConsumptionFor1Km;
        public double distanceTraveled;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionFor1Km = fuelConsumptionFor1Km;
        }

        public void Drive(int amountOfKm)
        {
            if (amountOfKm * fuelConsumptionFor1Km <= fuelAmount)
            {
                this.distanceTraveled += amountOfKm;
                this.fuelAmount -= amountOfKm * fuelConsumptionFor1Km;
            }

            else Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
