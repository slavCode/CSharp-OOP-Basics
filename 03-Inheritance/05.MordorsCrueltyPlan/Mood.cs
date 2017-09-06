public abstract class Mood
{
    private string moodName;

    public string MoodName
    {
        get => this.moodName;
        private set { this.moodName = value; }
    }

    public abstract string GetMood();
}
