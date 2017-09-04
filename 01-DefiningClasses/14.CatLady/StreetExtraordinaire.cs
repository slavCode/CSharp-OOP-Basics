namespace CatLady
{
    public class StreetExtraordinaire : Cat
    {
        public int decibelsOfMeowing;

        public StreetExtraordinaire(string name, int decibelsOfMeowing)
        {
            this.name = name;
            this.decibelsOfMeowing = decibelsOfMeowing;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.name} {this.decibelsOfMeowing}";
        }

    }
}
