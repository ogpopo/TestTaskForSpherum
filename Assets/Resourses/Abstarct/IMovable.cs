using UniRx;
using UnityEngine;

public interface IMovable
{
    public float Speed { get; }
    public ReactiveProperty<Vector3> Position { get; }

    public void Move(Vector3 direction);
}