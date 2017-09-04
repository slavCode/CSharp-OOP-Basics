using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        try
        {
            var input = Console.ReadLine();
            var teams = new List<Team>();
            while (input != "END")
            {
                var tokens = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Team":
                        teams.Add(new Team(tokens[1]));
                        break;
                    case "Add":
                        if (IsExistingTeam(teams, tokens[1]))
                        {
                            var player = new Player(tokens[2],
                                int.Parse(tokens[3]),
                                int.Parse(tokens[4]),
                                int.Parse(tokens[5]),
                                int.Parse(tokens[6]),
                                int.Parse(tokens[7]));
                            var isValidPlayer = CheckIfValid(tokens);
                            if (isValidPlayer && teams.Count > 0) teams.First(t => t.Name == tokens[1]).AddPlayer(tokens[1], player);
                        }

                        else Console.WriteLine($"Team {tokens[1]} does not exist.");
                        break;
                    case "Remove":
                        if (IsExistingTeam(teams, tokens[1])) teams.First(t => t.Name == tokens[1]).RemovePlayer(tokens[2]);
                        else Console.WriteLine($"Team {tokens[1]} does not exist.");
                        break;
                    case "Rating":
                        if (teams.Any(t => t.Name == tokens[1]))
                        {
                            Console.WriteLine($"{tokens[1]} - {teams.First(t => t.Name == tokens[1]).ShowRating(tokens[1])}");
                        }

                        else Console.WriteLine($"Team {tokens[1]} does not exist.");
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

    private static bool IsExistingTeam(List<Team> teams, string teamName)
    {
        bool isTeamExist = teams.Any(t => t.Name == teamName);
        return isTeamExist;
    }

    public static bool CheckIfValid(string[] tokens)
    {
        var validPlayer = true;
        for (int i = 3; i < tokens.Length; i++)
        {
            if (int.Parse(tokens[i]) > 100 || int.Parse(tokens[i]) < 0)
            {
                validPlayer = false;
                break;
            }
        }

        return validPlayer;
    }
}
