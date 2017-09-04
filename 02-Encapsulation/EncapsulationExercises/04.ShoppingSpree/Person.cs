using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private double money;
    private List<Product> bagOfProducts;

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get => this.name;

        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public double Money
    {
        get => this.money;

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<Product> BagOfProducts => this.bagOfProducts;

    public void BuyProduct(Product product)
    {
        if (product.Cost > this.money)
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }

        else
        {
            this.BagOfProducts.Add(product);
            this.Money -= product.Cost;
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }
    }
}
