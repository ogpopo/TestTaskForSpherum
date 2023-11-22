using UnityEngine;

public class CubeSpawnContext
{
    public Vector3 Position { get; private set; }
    public float Speed { get; private set; }

    public CubeSpawnContext(Vector3 position, float speed)
    {
        Position = position;
        Speed = speed;
    }
}