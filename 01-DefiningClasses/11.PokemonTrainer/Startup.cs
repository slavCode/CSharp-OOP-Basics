namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var trainers = new HashSet<Trainer>();
            while (input != "Tournament")
            {
                var inputArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var pokemon = new Pokemon(inputArgs[1], inputArgs[2], int.Parse(inputArgs[3]));
                if (!trainers.Select(t => t.name).Contains(inputArgs[0]))
                {
                    var trainer = new Trainer(inputArgs[0], new HashSet<Pokemon>() { pokemon });
                    trainers.Add(trainer);
                }

                else trainers.First(tr => tr.name == inputArgs[0]).pokemons.Add(pokemon);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.pokemons.Any(p => p.element == input)) trainer.numberOfBadges++;

                    else
                    {
                        foreach (var pokemon in trainer.pokemons)
                        {
                            pokemon.health -= 10;
                            if (pokemon.health <= 0)
                            {
                                trainer.pokemons.Remove(pokemon);
                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.numberOfBadges))
            {
                Console.WriteLine($"{trainer.name} {trainer.numberOfBadges} {trainer.pokemons.Count}");
            }
        }
    }
}
