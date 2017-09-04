namespace PokemonTrainer
{
    using System.Collections.Generic;
    public class Trainer
    {
        public string name;
        public int numberOfBadges;
        public HashSet<Pokemon> pokemons;

        public Trainer()
        {
            this.pokemons = new HashSet<Pokemon>();
            numberOfBadges = 0;
        }

        public Trainer(string name, HashSet<Pokemon> pokemons)
        {
            this.name = name;
            this.pokemons = pokemons;
        }
    }
}
