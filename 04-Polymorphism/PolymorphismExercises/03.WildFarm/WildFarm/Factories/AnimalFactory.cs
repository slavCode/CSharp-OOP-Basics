using System;

public class AnimalFactory
{
    public Animal CreateAnimal(string input)
    {
        var animalInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var animalType = animalInfo[0];
        var animalName = animalInfo[1];
        var animalWeight = double.Parse(animalInfo[2]);
        var animalLivingRegion = animalInfo[3];

        switch (animalType)
        {
            case "Cat":
                var catBreed = animalInfo[4];
                var cat = new Cat(animalName, animalType, animalWeight, catBreed, animalLivingRegion);
                return cat;
            case "Tiger":
                var tiger = new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                return tiger;
            case "Zebra":
                var zebra = new Zebra(animalName, animalType, animalWeight, animalLivingRegion);
                return zebra;
            case "Mouse":
                var mouse = new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                return mouse;
        }

        return null;
    }
}
