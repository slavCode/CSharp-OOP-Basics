namespace OpinionPoll
{
    using System;
    using System.Linq;
    using OldestFamilyMember;
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var person = new Person();

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split(' ').ToArray();
                var currPerson = new Person(personInfo[0], int.Parse(personInfo[1]));
                person.AddPerson(currPerson);
            }

            person.PrintPersonOverThirty();
        }
    }
}
