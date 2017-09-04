namespace FamilyTree
{
    using System.Collections.Generic;
    public class Person
    {
        public string name;
        public string date;
        public List<Person> parents;
        public List<Person> children;

        public Person()
        {
            this.parents = new List<Person>();
            this.children = new List<Person>();
            this.name = "No name";
            this.date = "No date";
        }

        public void AddFamilyMembers(string personArg)
        {
            if (personArg.IndexOf("/") == -1)
            {
                this.name = personArg;
            }

            else
            {
                this.date = personArg;
            }
        }
    }
}
