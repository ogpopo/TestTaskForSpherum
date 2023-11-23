using UniRx;
using UnityEngine;

public class Cube : IModel, IMovable
{
    public Cube(SpawnContext context)
    {
        Speed = context.Speed;
        Position.Value = context.Position;
    }
    
    public float Speed { get; }
    public ReactiveProperty<Vector3> Position { get; } = new ReactiveProperty<Vector3>();

    public void Move(Vector3 direction)
    {
        float scaledMoveSpeed = Speed * Time.deltaTime;
        var moveDirection = new Vector3(direction.x, 0, direction.y);

        Position.Value += moveDirection * scaledMoveSpeed;
    }
}