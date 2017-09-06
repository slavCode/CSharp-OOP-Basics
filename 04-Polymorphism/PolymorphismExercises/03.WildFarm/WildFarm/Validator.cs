using System;

public static class Validator
{
    public static bool IsOdd(int linesCounter)
    {
        bool isOdd = linesCounter % 2 != 0;
        return isOdd;
    }

    public static int VeritableFood(Food food, string animalType)
    {
        if (food.GetType() != Type.GetType("Vegetable"))
        {
            throw new ArgumentException($"{animalType}s are not eating that type of food!");
        }

        return food.Quantity;
    }

    public static int OnlyMeal(Food food, string animalType)
    {
        if (food.GetType() != Type.GetType("Meal"))
        {
            throw new ArgumentException($"{animalType}s are not eating that type of food!");
        }

        return food.Quantity;
    }
}
