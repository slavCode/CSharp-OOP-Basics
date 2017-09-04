namespace RectangleIntersection
{
    public class Rectangle
    {
        public string id;
        public int width;
        public int height;
        public int[] coordinates;

        public Rectangle(string id, int width, int height, int[] coordinates)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.coordinates = coordinates;
        }
        public bool IsRectanglesMatch(Rectangle secondRectangle)
        {
            if (this.coordinates[0] + this.width < secondRectangle.coordinates[0] ||
                secondRectangle.coordinates[0] + secondRectangle.width < this.coordinates[0]) return false;
            if (this.coordinates[1] + this.height < secondRectangle.coordinates[1] ||
                secondRectangle.coordinates[1] + secondRectangle.height < this.coordinates[1]) return false;
            return true;
        }
    }
}
