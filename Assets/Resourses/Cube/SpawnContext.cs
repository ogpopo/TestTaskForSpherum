using UnityEngine;

public class SpawnContext
{
    public Vector3 Position { get; private set; }
    public float Speed { get; private set; }

    public SpawnContext(Vector3 position, float speed)
    {
        Position = position;
        Speed = speed;
    }
}