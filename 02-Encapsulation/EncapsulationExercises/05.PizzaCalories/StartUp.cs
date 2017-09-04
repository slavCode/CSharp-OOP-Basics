using System;
public class StartUp
{
    public static void Main()
    {
        try
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(' ');
                switch (tokens[0])
                {
                    case "Dough":
                        var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                        Console.WriteLine($"{dough.CalculateCalories():f2}");
                        break;

                    case "Topping":
                        var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                        Console.WriteLine($"{topping.CalculateCalories():f2}");
                        break;

                    case "Pizza":
                        var numberOfToppings = int.Parse(tokens[2]);
                        var pizza = new Pizza(tokens[1], numberOfToppings);
                        var doughInfo = Console.ReadLine().Split(' ');
                        var ddough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
                        pizza.Dough = ddough;

                        for (int i = 0; i < numberOfToppings; i++)
                        {
                            var toppingInfo = Console.ReadLine().Split(' ');
                            var currTopping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                            pizza.AddTopping(currTopping);
                        }

                        Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
                        break;
                }

                input = Console.ReadLine();
            }
        }

        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}
