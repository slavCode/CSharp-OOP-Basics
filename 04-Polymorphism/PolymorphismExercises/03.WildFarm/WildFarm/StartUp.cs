using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var input = string.Empty;
        var animals = new Stack<Animal>();
        var foods = new Stack<Food>();
        var linesCounter = 1;
        while ((input = Console.ReadLine()) != "End")
        {
            if (Validator.IsOdd(linesCounter))
            {
                var animal = new AnimalFactory().CreateAnimal(input);
                animals.Push(animal);
                animals.Peek().MakeSound();
            }

            else
            {
                var food = new FoodFactory().CreateFood(input);
                foods.Push(food);

                try
                {
                    animals.Peek().Eat(foods.Pop());
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }

                Console.WriteLine(animals.Pop().ToString());
            }

            linesCounter++;
        }
    }
}
