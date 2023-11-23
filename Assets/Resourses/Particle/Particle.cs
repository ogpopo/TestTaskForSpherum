using UniRx;
using UnityEngine;

namespace Resourses.Particle
{
    public class Particle : IModel, IMovable
    {
        public Particle(SpawnContext context)
        {
            Speed = context.Speed;
            Position.Value = context.Position;
        }

        public float Speed { get; }
        public ReactiveProperty<Vector3> Position { get; } = new ReactiveProperty<Vector3>();

        public void Move(Vector3 direction)
        {
            Vector3 normalizedDirection = direction.normalized;
            float scaledMoveSpeed = Speed * Time.deltaTime;
            var moveDirection = new Vector3(normalizedDirection.x, 0, normalizedDirection.z);

            Position.Value += moveDirection * scaledMoveSpeed;
        }
    }
}