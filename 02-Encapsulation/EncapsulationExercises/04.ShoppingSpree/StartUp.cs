using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        try
        {
            var input = Console.ReadLine();
            var people = new List<Person>();
            var products = new List<Product>();

            var peopleInfo = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < peopleInfo.Length; i++)
            {
                var person = new Person(peopleInfo[i].Split('=')[0], double.Parse(peopleInfo[i].Split('=')[1]));
                people.Add(person);
            }

            input = Console.ReadLine();
            var productInfo = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productInfo.Length; i++)
            {
                var product = new Product(productInfo[i].Split('=')[0], double.Parse(productInfo[i].Split('=')[1]));
                products.Add(product);
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                var personProduct = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var personName = personProduct[0];
                var productName = personProduct[1];
                people.First(p => p.Name == personName).BuyProduct(products.First(pr => pr.Name == productName));

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {String.Join(", ", person.BagOfProducts.Select(p => p.Name))}");
                }

                else Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
