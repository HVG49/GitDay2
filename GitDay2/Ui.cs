public class Ui
{
    public float ScoreMultiplier = 74082374092390f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}