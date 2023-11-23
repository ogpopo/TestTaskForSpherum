using System.Collections.Generic;
using UnityEngine;

public class ParticleHolder : MonoBehaviour
{
    [SerializeField] private List<ParticleView> _particles = new List<ParticleView>();

    public IEnumerable<ParticleView> ParticlesInHolder => _particles;
}