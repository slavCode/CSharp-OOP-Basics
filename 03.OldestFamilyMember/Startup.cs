namespace OldestFamilyMember
{
    using System;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var memberInfo = Console.ReadLine().Split(' ').ToArray();
                var member = new Person(memberInfo[0], int.Parse(memberInfo[1]));
                family.AddMember(member);
            }

            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }
}
