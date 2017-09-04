namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var family = new List<Person>();
            var personToSearch = input;
            //var personTree = new Person();
            //if (IsDate(input)) personTree.date = input;
            //else personTree.name = input;
            //family.Add(personTree);

            var membersToAdd = Console.ReadLine();
            while (membersToAdd != "End")
            {
                //if (!IsDate(personToSearch) && personToSearch == membersToAddArgs[0].Trim())
                //{
                //    if (IsDate(membersToAddArgs[1]))
                //    {
                //        family.First(p => p.name == membersToAddArgs[0].Trim()).children.Add(new Person
                //        {
                //            date = membersToAddArgs[1]

                //        });
                //    }

                //    else
                //    {
                //        family.First(p => p.name == membersToAddArgs[0].Trim()).children.Add(new Person
                //        {
                //            name = membersToAddArgs[1]

                //        });
                //    }

                //}

                //if (!isDate && family.Any(p => p.name == membersToAddArgs[0].Trim()))
                //{
                //    family.First(p => p.name == membersToAddArgs[0].Trim()).date = membersToAddArgs[1].Trim();

                //}

                //else if (isDate && family.Any(p => p.date == membersToAddArgs[1].Trim()))
                //{
                //    family.First(p => p.date == membersToAddArgs[1].Trim()).name = membersToAddArgs[0].Trim();

                //}
                if (membersToAdd.IndexOf("-") > -1)
                {
                    var membersToAddArgs = membersToAdd.Split('-');
                    var parentMember = new Person();
                    var childMember = new Person();
                    parentMember.AddFamilyMembers(membersToAddArgs[0].Trim());
                    childMember.AddFamilyMembers(membersToAddArgs[1].Trim());
                    parentMember.children.Add(childMember);
                    family.Add(parentMember);
                    family.Add(childMember);
                }


                else
                {
                    var membersToAddArgs = membersToAdd.Split();
                    var name = membersToAddArgs[0].Trim() + " " + membersToAddArgs[1].Trim();
                    var date = membersToAddArgs[2].Trim();
                    UpdateMember(name, date, family);
                }

                membersToAdd = Console.ReadLine();
            }


        }

        public static void UpdateMember(string name, string date, List<Person> family)
        {
            if (family.Any(p => p.name == name) && family.Any(p => p.date == date))
            {
                var removePerson = family.SingleOrDefault(p => p.name == name);
                family.Remove(removePerson);
            }

             if (family.Any(p => p.name == name))
            {
                family.First(p => p.name == name).date = date;
            }

            else if (family.Any(p => p.date == date))
            {
                family.First(p => p.date == date).name = name;
            }


            //foreach (var person in family)
            //{
            //    if (person.children.Any(p => p.name == name))
            //    {
            //        person.children.First(p => p.name == name).date = date;
            //    }

            //    else if (person.children.Any(p => p.date == date))
            //    {
            //        person.children.First(p => p.date == date).name = name;
            //    }

            //}

            //foreach (var person in family)
            //{
            //    if (person.children.Count > 0)
            //    {
            //        if (person.children.Any(p => p.name == name))
            //        {
            //            person.children.First(p => p.name == name).date = date;
            //        }

            //        else if (person.children.Any(p => p.date == date))
            //        {
            //            person.children.First(p => p.date == date).name = name;
            //        }
            //    }
            //}
        }

        public static bool IsDate(string info)
        {
            if (info.IndexOf("/") > -1) return true;
            return false;
        }
    }
}
