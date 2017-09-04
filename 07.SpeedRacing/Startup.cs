namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var currentCar = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(currentCar);
            }

            var input = Console.ReadLine();
            while (input != "End")
            {
                var carParams = input.Split();
                var model = carParams[1];
                var amountOfKm = int.Parse(carParams[2]);
                Car resultCar = cars.First(c => c.model == model);
                resultCar.Drive(amountOfKm);
                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.distanceTraveled}");
            }
        }
    }
}
