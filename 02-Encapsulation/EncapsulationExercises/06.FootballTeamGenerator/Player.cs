using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;
    private double stats;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
        this.Stats = stats;
    }

    public string Name
    {
        get => this.name;

        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("A name should not be empty.");
            }

            else this.name = value;
        }
    }

    public int Endurance
    {
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine($"{nameof(Endurance)} should be between 0 and 100.");
            }

            else this.endurance = value;
        }
    }

    public int Sprint
    {
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine($"{nameof(Sprint)} should be between 0 and 100.");
            }

            else this.sprint = value;
        }
    }

    public int Dribble
    {
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine($"{nameof(Dribble)} should be between 0 and 100.");
            }

            else this.dribble = value;
        }
    }

    public int Passing
    {
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine($"{nameof(Passing)} should be between 0 and 100.");
            }

            else this.passing = value;
        }
    }

    public int Shooting
    {
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine($"{nameof(Shooting)} should be between 0 and 100.");
            }

            else this.shooting = value;
        }
    }

    public double Stats
    {
        get => this.stats;

        set
        {
            var allStats = new List<int> { this.endurance, this.sprint, this.dribble, this.passing, this.shooting };
            this.stats = allStats.Average();
        }
    }

    public double ShowStats() => this.Stats;
}
