using System;
using System.Collections.Generic;
using System.Linq;
using Resourses.Abstarct;
using Resourses.Cube;
using Resourses.Particle;
using Resourses.Paterns;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Resourses.Installers
{
    public class ParticleInstaller : MonoInstaller
    {
        [SerializeField] private ParticleHolder _particleViewHolder;

        private int _particleReceiptIndex;

        [Inject(Id = InjectionIDs.RedCubeId)] private IMovable _redCube;

        [Inject(Id = InjectionIDs.GreenCubeId)]
        private IMovable _greenCube;

        [Inject] private DistanceMeter.DistanceMeter _distanceMeter;

        public override void InstallBindings()
        {
            var modelsWithTargets = new Dictionary<Particle.Particle, IMovable>();

            var index = 0;

            for (; index < 10; index++)
            {
                modelsWithTargets.Add(Create(_redCube), _redCube);
            }

            for (; index < 20; index++)
            {
                modelsWithTargets.Add(Create(_greenCube), _greenCube);
            }

            Container.Bind<IMovablePattern>().To<PatternMovementToCube>().AsSingle();
            Container.Bind<Dictionary<Particle.Particle, IMovable>>().FromInstance(modelsWithTargets).AsSingle();
            Container.Bind<ParticleMover>().AsSingle().NonLazy();

            var particleVisibilitor = new Particle.ParticleVisibilitor(_distanceMeter.Distance,
                _particleViewHolder.ParticlesInHolder.ToList());

            Container.Bind(typeof(IDisposable)).To<Particle.ParticleVisibilitor>().FromInstance(particleVisibilitor);
        }

        private Particle.Particle Create(IMovable own)
        {
            var spawnContext = new SpawnContext(own.Position.Value, Random.Range(8, 13));
            var model = new Particle.Particle(spawnContext);

            ParticleView view = _particleViewHolder.ParticlesInHolder.ToList()[_particleReceiptIndex];

            view.transform.position = model.Position.Value;

            _particleReceiptIndex++;

            var presenter = new Particle.ParticlePresenter(model, view);

            Container.Bind(typeof(IDisposable)).To<Particle.ParticlePresenter>().FromInstance(presenter);

            return model;
        }
    }
}