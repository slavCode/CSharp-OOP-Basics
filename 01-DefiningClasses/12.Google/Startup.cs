namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input != "End")
            {
                var inputArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (people.Exists(p => p.name == inputArgs[0]))
                {
                    switch (inputArgs[1])
                    {
                        case "company":
                            people.First(p => p.name == inputArgs[0]).company.companyName = inputArgs[2];
                            people.First(p => p.name == inputArgs[0]).company.companyDepartment = inputArgs[3];
                            people.First(p => p.name == inputArgs[0]).company.salary = decimal.Parse(inputArgs[4]);

                            break;
                        case "pokemon":
                            people.First(p => p.name == inputArgs[0]).pokemons.Add(new Pokemon(inputArgs[2], inputArgs[3]));
                            break;
                        case "parents":
                            people.First(p => p.name == inputArgs[0]).parents.Add(new Parent(inputArgs[2], inputArgs[3]));
                            break;
                        case "children":
                            people.First(p => p.name == inputArgs[0]).children.Add(new Child(inputArgs[2], inputArgs[3]));
                            break;
                        case "car":
                            people.First(p => p.name == inputArgs[0]).car.carModel = inputArgs[2];
                            people.First(p => p.name == inputArgs[0]).car.carSpeed = int.Parse(inputArgs[3]);
                            break;
                    }
                }

                else
                {
                    var person = new Person(inputArgs[0]);
                    switch (inputArgs[1])
                    {
                        case "company":
                            person.company.companyName = inputArgs[2];
                            person.company.companyDepartment = inputArgs[3];
                            person.company.salary = decimal.Parse(inputArgs[4]);
                            break;
                        case "pokemon":
                            person.pokemons.Add(new Pokemon(inputArgs[2], inputArgs[3]));
                            break;
                        case "parents":
                            person.parents.Add(new Parent(inputArgs[2], inputArgs[3]));
                            break;
                        case "children":
                            person.children.Add(new Child(inputArgs[2], inputArgs[3]));
                            break;
                        case "car":
                            person.car.carModel = inputArgs[2];
                            person.car.carSpeed = int.Parse(inputArgs[3]);
                            break;
                    }

                    people.Add(person);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            Console.WriteLine($"{people.First(p => p.name == input).name}");

            Console.WriteLine("Company:");
            if (people.First(p => p.name == input).company.salary > 0)
            Console.WriteLine($"{people.First(p => p.name == input).company.companyName} {people.First(p => p.name == input).company.companyDepartment} {people.First(p => p.name == input).company.salary:F2}");

            Console.WriteLine("Car:");
            if (people.First(p => p.name == input).car.carSpeed > 0)
            Console.WriteLine($"{people.First(p => p.name == input).car.carModel} {people.First(p => p.name == input).car.carSpeed}");

            Console.WriteLine("Pokemon:");
            foreach (var pokemon in people.First(p => p.name == input).pokemons)
            {
                Console.WriteLine($"{pokemon.pokemonName} {pokemon.pokemonType}");
            }

            Console.WriteLine("Parents:");
            foreach (var pokemon in people.First(p => p.name == input).parents)
            {
                Console.WriteLine($"{pokemon.parentName} {pokemon.parentBirthday}");
            }

            Console.WriteLine("Children:");
            foreach (var pokemon in people.First(p => p.name == input).children)
            {
                Console.WriteLine($"{pokemon.childName} {pokemon.childBirthday}");
            }
        }
    }
}
