public abstract class Food
{
    private int pointsOfHappiness;

    protected Food()
    {
        this.PointsOfHappiness = pointsOfHappiness;
    }

    public int PointsOfHappiness
    {
        get { return this.pointsOfHappiness; }
        protected set { this.pointsOfHappiness = value; }
    }
}
