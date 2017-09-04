namespace DefineAClassPerson
{
    using System;
    using System.Reflection;
    public class Startup
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var pesho = new Person() { name = "Pesho", age = 20 };
            var gosho = new Person() { name = "Gosho", age = 18 };
            var stamat = new Person() { name = "Stamat", age = 43 };
        }
    }
}
