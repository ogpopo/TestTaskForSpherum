using System.Collections.Generic;
using System.Linq;
using Resourses.Abstarct;
using Resourses.Particle;
using UniRx;
using UnityEngine;

public class ParticleMover
{
    private readonly Dictionary<Particle, IMovable> _movingParticlesTheirTargets;
    private readonly IMovablePattern _pattern;

    private readonly CompositeDisposable _disposable = new CompositeDisposable();

    public ParticleMover(Dictionary<Particle, IMovable> movingParticlesAndDefaultTargets, IMovablePattern pattern)
    {
        _movingParticlesTheirTargets = new Dictionary<Particle, IMovable>(movingParticlesAndDefaultTargets);
        _pattern = pattern;

        SetUpdate();
    }

    private void CheckTheyHaveReached()
    {
        foreach (var (particle, target) in _movingParticlesTheirTargets.ToList())
        {
            if (Vector3.Distance(particle.Position.Value, target.Position.Value) < .2f)
                SettingANewTarget(particle);
        }
    }

    private void SettingANewTarget(Particle particle)
    {
        _movingParticlesTheirTargets[particle] = _pattern.GetNextTarget(_movingParticlesTheirTargets[particle]);
    }

    private void SetUpdate()
    {
        Observable.EveryUpdate().Subscribe(_ =>
        {
            foreach (var (particle, target) in _movingParticlesTheirTargets.ToList())
            {
                particle.Move((target.Position.Value - particle.Position.Value));
                CheckTheyHaveReached();
            }
        }).AddTo(_disposable);
    }
}