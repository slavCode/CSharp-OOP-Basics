﻿public class Dog : Animal
{
    public Dog(string name, string favoriteFood) : base(name, favoriteFood)
    {
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + $"\nDJAAF";
    }
}
