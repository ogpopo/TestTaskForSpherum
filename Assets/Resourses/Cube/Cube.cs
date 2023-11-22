using UniRx;
using UnityEngine;

public class Cube : IModel, IMovable
{
    public float Speed { get; }
    public ReactiveProperty<Vector3> Position { get; } = new ReactiveProperty<Vector3>();

    public Cube(CubeSpawnContext context)
    {
        Speed = context.Speed;
        Position.Value = context.Position;
    }

    public void Move(Vector2 direction)
    {
        float scaledMoveSpeed = Speed * Time.deltaTime;
        var moveDirection = new Vector3(direction.x, 0, direction.y);

        Position.Value += moveDirection * scaledMoveSpeed;
    }
}