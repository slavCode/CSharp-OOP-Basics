namespace RawData
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new Queue();

            for (int i = 0; i < numberOfCars; i++)
            {
                var inputParams = Console.ReadLine().Split();
                var model = inputParams[0];
                var engineSpeed = int.Parse(inputParams[1]);
                var enginePower = int.Parse(inputParams[2]);
                var cargoWeight = int.Parse(inputParams[3]);
                var cargoType = inputParams[4];
                var tireOnePressure = double.Parse(inputParams[5]);
                var tireOneAge = int.Parse(inputParams[6]);
                var tireTwoPressure = double.Parse(inputParams[7]);
                var tireTwoAge = int.Parse(inputParams[8]);
                var tireThreePressure = double.Parse(inputParams[9]);
                var tireThreeAge = int.Parse(inputParams[10]);
                var tireFourPressure = double.Parse(inputParams[11]);
                var tireFourAge = int.Parse(inputParams[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tires = new List<Tire>();
                tires.Add(new Tire(tireOnePressure, tireOneAge));
                tires.Add(new Tire(tireTwoPressure, tireTwoAge));
                tires.Add(new Tire(tireThreePressure, tireThreeAge));
                tires.Add(new Tire(tireFourPressure, tireFourAge));

                var car = new Car(model, engine, cargo, tires);
                cars.Enqueue(car);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                while (cars.Count > 0)
                {
                    Car currCar = (Car)cars.Dequeue();
                    if (currCar.cargo.cargoType == "fragile" && currCar.tires.Any(t => t.tirePressure < 1.0))
                    {
                        Console.WriteLine(currCar.model);
                    }
                }
            }

            else if (command == "flamable")
            {
                while (cars.Count > 0)
                {
                    Car currCar = (Car)cars.Dequeue();
                    if (currCar.cargo.cargoType == "flamable" && currCar.engine.enginePower > 250)
                    {
                        Console.WriteLine(currCar.model);
                    }
                }
            }
        }
    }
}
