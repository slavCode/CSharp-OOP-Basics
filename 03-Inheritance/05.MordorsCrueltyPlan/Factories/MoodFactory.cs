public class MoodFactory
{
    public Mood GetMood(int pointsOfHappiness)
    {
        if (pointsOfHappiness < -5) return new Angry();
       
        if (pointsOfHappiness >= -5 && pointsOfHappiness < 1) return new Sad();

        if (pointsOfHappiness >= 1 && pointsOfHappiness <= 15) return new Happy();

        return new JavaScript();
    }
}
