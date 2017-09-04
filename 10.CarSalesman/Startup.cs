namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));
                if (engineInfo.Length == 3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(engineInfo[2], out displacement);
                    if (!isDisplacement) engine.efficiency = engineInfo[2];
                    else engine.displacement = displacement.ToString();
                }

                else if (engineInfo.Length == 4)
                {
                    engine.displacement = engineInfo[2];
                    engine.efficiency = engineInfo[3];
                }

                engines.Add(engine);
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(carInfo[0], engines.FirstOrDefault(e => e.model == carInfo[1]));
                if (carInfo.Length == 3)
                {
                    int weight;
                    bool isWeight = int.TryParse(carInfo[2], out weight);
                    if (!isWeight) car.color = carInfo[2];
                    else car.weight = weight.ToString();
                }

                else if (carInfo.Length == 4)
                {
                    car.weight = carInfo[2];
                    car.color = carInfo[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model}:");
                Console.WriteLine($"  {car.engine.model}:");
                Console.WriteLine($"    Power: {engines.FirstOrDefault(e => e.model == car.engine.model).power}");
                Console.WriteLine($"    Displacement: {engines.FirstOrDefault(e => e.model == car.engine.model).displacement}");
                Console.WriteLine($"    Efficiency: {engines.FirstOrDefault(e => e.model == car.engine.model).efficiency}");
                Console.WriteLine($"  Weight: {car.weight}");
                Console.WriteLine($"  Color: {car.color}");
            }
        }
    }
}
