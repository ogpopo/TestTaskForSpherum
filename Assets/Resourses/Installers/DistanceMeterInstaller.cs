using Resourses.DistanceMeter;
using UnityEngine;
using Zenject;

namespace Resourses.Installers
{
    public class DistanceMeterInstaller : MonoInstaller
    {
        [SerializeField] private DistanceMeterUIView _meterUIView;

        private DistanceMeterPresenter _meterPresenter;

        public override void InstallBindings()
        {
            Container.Bind<DistanceMeterUIView>().FromInstance(_meterUIView).AsSingle();
            Container.Bind<DistanceMeter.DistanceMeter>().FromNew().AsSingle().NonLazy();
            Container.Bind<DistanceMeterPresenter>().AsSingle().NonLazy();
            Container.Bind<SceneMeter>().AsSingle().NonLazy();
        }
    }
}