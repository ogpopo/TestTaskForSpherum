using System;
using System.Collections.Generic;
using UniRx;

namespace Resourses.Particle
{
    public class ParticleVisibilitor : IDisposable
    {
        List<ParticleView> _particles;

        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        public ParticleVisibilitor(ReactiveProperty<float> distance, List<ParticleView> particles)
        {
            _particles = particles;
            distance.Subscribe(CheckDistance).AddTo(_disposable);
        }

        private void CheckDistance(float distance)
        {
            foreach (var particle in _particles)
            {
                particle.gameObject.SetActive(distance < 2);
            }
        }

        public void Dispose()
        {
            _disposable.Clear();
        }
    }
}