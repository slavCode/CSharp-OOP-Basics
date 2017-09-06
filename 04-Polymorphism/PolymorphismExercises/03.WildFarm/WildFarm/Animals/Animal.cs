public abstract class Animal
{
    public Animal(string animalName, string animalType, double animalWeight)
    {
        this.AnimalName = animalName;
        this.AnimalType = animalType;
        this.AnimalWeight = animalWeight;
        this.FoodEaten = FoodEaten;
    }

    public string AnimalName { get; private  set; }

    public string AnimalType { get; private set; }

    public double AnimalWeight { get; private set; }

    public int FoodEaten { get; protected set; }

    public abstract void MakeSound();
    public abstract void Eat(Food food);
}

