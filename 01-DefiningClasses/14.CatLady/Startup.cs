namespace CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var cats = new List<Cat>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var catInfo = input.Split();
                var catBreed = catInfo[0];
                var catName = catInfo[1];
                var catCharacteristic = catInfo[2];

                switch (catBreed)
                {
                    case "Siamese":
                        cats.Add(new Siamese(catName, double.Parse(catCharacteristic)));
                        break;
                    case "Cymric":
                        cats.Add(new Cymric(catName, double.Parse(catCharacteristic)));
                        break;
                    case "StreetExtraordinaire":
                        cats.Add(new StreetExtraordinaire(catName, int.Parse(catCharacteristic)));
                        break;
                }

                input = Console.ReadLine();
            }

            var catToDisplay = Console.ReadLine();
            Console.WriteLine(cats.First(c => c.name == catToDisplay));
        }
    }
}
