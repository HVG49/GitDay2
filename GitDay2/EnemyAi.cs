public class EnemyAi
{
    public float DetectionRadius = 50f;
    public float PatrolSpeed = 900f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}