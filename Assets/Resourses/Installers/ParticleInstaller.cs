using System.Collections.Generic;
using Resourses.Abstarct;
using Resourses.Particle;
using Resourses.Paterns;
using UnityEngine;
using Zenject;

public class ParticleInstaller : MonoInstaller
{
    [SerializeField] private ParticleView _particleViewTemplate;

    [Inject(Id = InjectionIDs.RedCubeId)] private IMovable _redCube;

    [Inject(Id = InjectionIDs.GreenCubeId)]
    private IMovable _greenCube;

    public override void InstallBindings()
    {
        var modelsWithTargets = new Dictionary<Particle, IMovable>();

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
        Container.Bind<Dictionary<Particle, IMovable>>().FromInstance(modelsWithTargets).AsSingle();
        Container.Bind<ParticleMover>().AsSingle().NonLazy();
        //var mover = new ParticleMover();
    }

    private Particle Create(IMovable own)
    {
        var spawnContext = new SpawnContext(own.Position.Value, Random.Range(8, 13));
        var model = new Particle(spawnContext);

        ParticleView view = Container.InstantiatePrefabForComponent<ParticleView>(_particleViewTemplate,
            own.Position.Value,
            Quaternion.identity,
            null);

        var presenter = new ParticlePresenter(model, view);

        return model;
    }
}