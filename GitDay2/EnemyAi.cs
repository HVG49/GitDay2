public class EnemyAi
{
    public float DetectionRadius = 3f;
    public float PatrolSpeed = 2f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}