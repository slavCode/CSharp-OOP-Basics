namespace CatLady
{
    class Siamese : Cat
    {
        public double furLength;

        public Siamese(string name, double furLength)
        {
            this.name = name;
            this.furLength = furLength;
        }

        public override string ToString()
        {
            return $"Siamese {this.name} {this.furLength}";
        }
    }
}
