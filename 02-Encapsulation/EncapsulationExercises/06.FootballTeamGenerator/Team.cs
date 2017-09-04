using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private List<Player> players;
    private double rating;

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
        this.Rating = rating;
    }

    private double Rating
    {
        get => this.rating;

        set
        {
            if (players.Count > 0) this.rating = this.players.Select(p => p.ShowStats()).Average();

            else this.rating = value;
        }
    }

    public string Name
    {
        get => this.name;

        set
        {
            if (String.IsNullOrWhiteSpace(value)) Console.WriteLine("A name should not be empty.");

            else this.name = value;
        }
    }

    public void RemovePlayer(string playerName)
    {
        if (!this.players.Any(p => p.Name == playerName))
        {
            Console.WriteLine($"Player {playerName} is not in {this.Name} team.");
        }

        else this.players.Remove(this.players.First(p => p.Name == playerName));
    }

    public void AddPlayer(string teamName, Player player)
    {
        if (!teamName.Equals(this.Name)) Console.WriteLine($"Team {teamName} does not exist.");

        else this.players.Add(player);
    }

    public string ShowRating(string teamName)
    {
        if (!teamName.Equals(this.Name)) return ($"Team {teamName} does not exist.");
        if (players.Count > 0) return Math.Round(this.players.Select(p => p.ShowStats()).Average()).ToString();

        return Math.Round(this.rating).ToString();
    }
}
