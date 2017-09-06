﻿public abstract class Mammal : Animal
{
    public Mammal(string animalName, string animalType, double animalWeight, string livingRegion)
        : base(animalName, animalType, animalWeight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion { get; }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

