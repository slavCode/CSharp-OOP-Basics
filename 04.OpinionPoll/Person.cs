namespace OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        private string name;
        private int age;
        private List<Person> people;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person()
        {
            this.people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public void PrintPersonOverThirty()
        {
            foreach (var person in people.OrderBy(p => p.name))
            {
                if (person.age > 30)
                {
                    Console.WriteLine($"{person.name} - {person.age}");
                }
            }
        }
    }
}
