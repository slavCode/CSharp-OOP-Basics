namespace CarSalesman
{
    public class Car
    {
        public string model;
        public Engine engine;
        public string weight;
        public string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = "n/a";
            this.color = "n/a";
        }
    }
}
