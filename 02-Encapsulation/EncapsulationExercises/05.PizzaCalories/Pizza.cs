using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private int numberOfToppings;
    private List<Topping> toppings;
    private Dough dough;
    private double totalCalories;

    public Pizza(string name, int numberOfToppings)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = new List<Topping>();
    }

    public string Name
    {
        get => this.name;
      
        set
        {
            if (value.Length < 1 || value.Length > 15 || value == String.Empty)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public int NumberOfToppings
    {
        get => this.numberOfToppings;
       
        set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.numberOfToppings = value;
        }
    }

    public Dough Dough
    {
        get => this.dough;

        set { this.dough = value; }
    }

    public double TotalCalories { get => totalCalories; set => totalCalories = value; }

    public double GetTotalCalories()
    {
         return this.totalCalories = this.toppings.Select(t => t.CalculateCalories()).Sum() + this.dough.CalculateCalories();
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }
}
