using System;

public class Tiger : Feline
{
    public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) 
        : base(animalName, animalType, animalWeight, livingRegion)
    {
    }

    public override void MakeSound() => Console.WriteLine("ROAAR!!!");

    public override void Eat(Food food)
    {
        this.FoodEaten += Validator.OnlyMeal(food, this.GetType().ToString());
    }
}
