namespace CarSalesman
{
    public class Engine
    {
        public string model;
        public int power;
        public string displacement;
        public string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = "n/a";
            this.efficiency = "n/a";
        }
    }
}
