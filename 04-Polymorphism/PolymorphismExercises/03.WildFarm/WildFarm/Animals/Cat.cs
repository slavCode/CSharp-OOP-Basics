using System;

public class Cat : Feline
{
    public Cat(string animalName, string animalType, double animalWeight, string catBreed, string livingRegion) 
        : base(animalName, animalType, animalWeight, livingRegion)
    {
        this.CatBreed = catBreed;
    }
    
    public string CatBreed { get; private set; }

    public override void MakeSound() => Console.WriteLine("Meowwww");

    public override void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.CatBreed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
