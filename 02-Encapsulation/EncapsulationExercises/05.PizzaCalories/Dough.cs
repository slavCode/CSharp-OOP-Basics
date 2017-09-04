using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;
    private double caloriesPerGramForFlour;
    private double caloriesPerGramForBakingTechnique;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get => this.flourType;

        set
        {
            this.flourType = value;
            if (value.ToLower() == "white")
            {
                this.caloriesPerGramForFlour += 1.5;
            }

            else if (value.ToLower() == "wholegrain")
            {
                this.caloriesPerGramForFlour += 1.0;
            }

            else throw new ArgumentException("Invalid type of dough.");
        }
    }

    public string BakingTechnique
    {
        get => this.bakingTechnique;

        set
        {
            this.bakingTechnique = value;
            if (value.ToLower() == "crispy")
            {
                this.caloriesPerGramForBakingTechnique = 0.9;
            }

            else if (value.ToLower() == "chewy")
            {
                this.caloriesPerGramForBakingTechnique = 1.1;
            }

            else if (value.ToLower() == "homemade")
            {
                this.caloriesPerGramForBakingTechnique = 1.0;
            }

            else throw new ArgumentException("Invalid type of dough.");
        }
    }

    public double Weight
    {
        get => this.weight;

        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.weight = value;
        }
    }

    public double CalculateCalories()
    {
        return (this.weight * 2) * this.caloriesPerGramForFlour * this.caloriesPerGramForBakingTechnique;
    }
}
