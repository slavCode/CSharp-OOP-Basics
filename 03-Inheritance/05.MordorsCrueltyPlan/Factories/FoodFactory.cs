public class FoodFactory
{
    public virtual Food CreateFood(string inputFood)
    {
        Food food;

        switch (inputFood)
        {
            case "cram":
                food = new Cram();
                break;
            case "lembas":
                food = new Lembas();
                break;
            case "apple":
                food = new Apple();
                break;
            case "melon":
                food = new Melon();
                break;
            case "honeycake":
                food = new HoneyCake();
                break;
            case "mushrooms":
                food = new Mushrooms();
                break;
            default:
                food = new Other();
                break;
        }

        return food;
    }
}