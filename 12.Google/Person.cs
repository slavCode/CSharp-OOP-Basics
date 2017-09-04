namespace Google
{
    using System.Collections.Generic;
    public class Person
    {
        public string name;
        public Company company;
        public List<Pokemon> pokemons;
        public List<Parent> parents;
        public List<Child> children;
        public Car car;

        public Person(string name)
        {
            this.name = name;
            this.company = new Company();
            this.parents = new List<Parent>();
            this.pokemons = new List<Pokemon>();
            this.children = new List<Child>();
            this.car = new Car();
        }
    }
}
