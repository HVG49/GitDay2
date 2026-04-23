public class Ui
{
    public float ScoreMultiplier = 300f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}