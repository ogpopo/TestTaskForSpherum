using System;
using Resourses.Abstarct;
using Resourses.Cube;
using UnityEngine;
using Zenject;

namespace Resourses.Installers
{
    public class RedCubeInstaller : MonoInstaller
    {
        [SerializeField] private CubeView _redCubeViewTemplate;

        [SerializeField] private Transform _spawnPoint;
        [SerializeField] [Range(0, 15)] private float _cubeSpeed;

        [Inject] private PlayerInput _input;

        private string _id = InjectionIDs.RedCubeId;

        private CubeView _redCubeView;
        private CubePresenter _redCubePresenter;

        private PlayerInputBroadcaster _redCubePlayerInputBroadcaster;

        public override void InstallBindings()
        {
            var position = _spawnPoint.position;

            _redCubeView = Container.InstantiatePrefabForComponent<CubeView>(_redCubeViewTemplate, position,
                Quaternion.identity,
                null);

            var spawnContext = new SpawnContext(position, _cubeSpeed);

            var model = new RedCube(spawnContext);

            Container.Bind<IMovable>().WithId(_id).To<Cube.Cube>().FromInstance(model);

            _redCubePresenter = new CubePresenter(model, _redCubeView);
            _redCubePlayerInputBroadcaster = new PlayerInputBroadcaster(_input.RedCube.Move, model);

            Container.Bind(typeof(IDisposable)).To<CubePresenter>().FromInstance(_redCubePresenter);
        }
    }
}