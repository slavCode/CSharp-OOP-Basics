public class Animal
{
    private string name;
    private string favoriteFood;

    public Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public string FavoriteFood
    {
        get => this.favoriteFood;
        private set { this.favoriteFood = value; }
    }

    public string Name
    {
        get => name;
        private set { this.name = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}
