using System;

public class Topping
{
    private string toppingType;
    private double weight;
    private double caloriesPerGram;

    public Topping(string toppingType, double weight)
    {
        this.ToppingType = toppingType;
        this.Weight = weight;
    }

    public string ToppingType
    {
        get => this.toppingType;
       
        set
        {
            this.toppingType = value;
            if (value.ToLower() == "meat")
            {
                this.caloriesPerGram = 1.2;
            }

            else if (value.ToLower() == "veggies")
            {
                this.caloriesPerGram = 0.8;
            }

            else if (value.ToLower() == "cheese")
            {
                this.caloriesPerGram = 1.1;
            }

            else if (value.ToLower() == "sauce")
            {
                this.caloriesPerGram = 0.9;
            }

            else throw new ArgumentException($"Cannot place {value} on top of your pizza.");
        }
    }

    public double Weight
    {
        get => this.weight;
       
        set
        {
            if (value > 50 || value < 1)
            {
                throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
            }

            this.weight = value;
        }
    }

    public double CalculateCalories() => (this.weight * 2) * this.caloriesPerGram;
}
