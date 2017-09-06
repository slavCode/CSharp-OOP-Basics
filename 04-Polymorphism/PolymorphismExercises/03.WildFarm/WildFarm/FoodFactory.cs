using System;

public class FoodFactory
{
    public Food CreateFood(string input)
    {
        var foodInfo = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var foodType = foodInfo[0];
        var foodQuantity = int.Parse(foodInfo[1]);
        switch (foodType)
        {
            case "Vegetable":
                var vegetable = new Vegetable(foodQuantity);
                return vegetable;
            case "Meat":
                var meat = new Meat(foodQuantity);
                return meat;
        }

        return null;
    }
}

