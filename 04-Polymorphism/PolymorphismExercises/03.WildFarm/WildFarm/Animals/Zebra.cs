using System;

public class Zebra : Mammal
{
    public Zebra(string animalName, string animalType, double animalWeight, string livingRegion)
        : base(animalName, animalType, animalWeight, livingRegion)
    {
    }

    public override void MakeSound() => Console.WriteLine("Zs");

    public override void Eat(Food food)
    {
        this.FoodEaten += Validator.VeritableFood(food, this.GetType().ToString());
    }
}