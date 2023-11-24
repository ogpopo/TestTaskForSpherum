using Resourses.Abstarct;
using UnityEngine;

namespace Resourses.Particle
{
    public class ParticleView : MonoBehaviour, IView
    {
        public void OnMove(Vector3 newPosition)
        {
            transform.position = newPosition;
        }
    }
}