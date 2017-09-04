namespace CatLady
{
    public class Cymric : Cat
    {
        public double earSize;

        public Cymric(string name, double earSize)
        {
            this.name = name;
            this.earSize = earSize;
        }

        public override string ToString()
        {
            return $"Cymric {this.name} {this.earSize:F2}";
        }
    }
}
