namespace OldestFamilyMember
{
    using System.Collections.Generic;
    using System.Linq;
    public class Family
    {
        public List<Person> members;
        public Person member;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
