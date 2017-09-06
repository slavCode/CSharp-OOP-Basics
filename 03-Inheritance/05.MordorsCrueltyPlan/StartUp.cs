using System;

public class StartUp
{
    public static void Main()
    {
        var foods = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var pointsOfHappiness = 0;
        for (int i = 0; i < foods.Length; i++)
        {
           pointsOfHappiness += new FoodFactory().CreateFood(foods[i].ToLower()).PointsOfHappiness;
        }

        Console.WriteLine(pointsOfHappiness);
        Console.WriteLine(new MoodFactory().GetMood(pointsOfHappiness));
    }
}
